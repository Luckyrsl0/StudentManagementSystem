using System;
using System.Linq;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    public partial class ResetPasswordForm : Form
    {
        private readonly UserRepository userRepo = new UserRepository();
        private readonly string targetUsername = string.Empty;
        private bool isNewPasswordVisible = false;
        private bool isConfirmPasswordVisible = false;

        // Gi-keep para dili mag-error ang WinForms Designer
        public ResetPasswordForm()
        {
            InitializeComponent();
            this.AcceptButton = btnResetPassword;
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        public ResetPasswordForm(string username) : this()
        {
            this.targetUsername = username;
        }

        private bool IsPasswordValid(string password)
        {
            return password.Length >= 8
                && password.Any(char.IsUpper)
                && password.Any(char.IsLower)
                && password.Any(char.IsDigit);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string newPass = txtNewPassword.Text;
            string confirmPass = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Please fill in both password fields.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsPasswordValid(newPass))
            {
                MessageBox.Show(
                    "Password must contain:\n" +
                    "• At least 8 characters\n" +
                    "• One uppercase letter (A-Z)\n" +
                    "• One lowercase letter (a-z)\n" +
                    "• One number (0-9)",
                    "Weak Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Automatic na ma-hash via BCrypt sa sulod sa UpdatePassword()
                bool isUpdated = userRepo.UpdatePassword(targetUsername, newPass);

                if (isUpdated)
                {
                    MessageBox.Show("Password has been reset successfully! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoginForm loginForm = new LoginForm();
                    loginForm.FormClosed += (s, args) => this.Show();
                    loginForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to update password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A database error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newPassEyeIcon_Click(object sender, EventArgs e)
        {
            isNewPasswordVisible = !isNewPasswordVisible;
            txtNewPassword.UseSystemPasswordChar = !isNewPasswordVisible;
            newPassEyeIcon.Image = isNewPasswordVisible
                ? Properties.Resources.showEyeIcon
                : Properties.Resources.hiddenEyeIcon;
        }

        private void confirmPassEyeIcon_Click(object sender, EventArgs e)
        {
            isConfirmPasswordVisible = !isConfirmPasswordVisible;
            txtConfirmPassword.UseSystemPasswordChar = !isConfirmPasswordVisible;
            confirmPassEyeIcon.Image = isConfirmPasswordVisible
                ? Properties.Resources.showEyeIcon
                : Properties.Resources.hiddenEyeIcon;
        }

        private void backToLoginLink_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}