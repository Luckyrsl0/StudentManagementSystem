using System;
using System.Windows.Forms;
using StudentManagementSystem.Forms;
using StudentManagementSystem.Model;

namespace StudentManagementSystem
{
    public partial class LoginForm : Form
    {
        private readonly UserRepository userRepo = new UserRepository();
        // true = password is visible (open eye), false = password is masked (slashed eye)
        private bool isPasswordVisible = false;

        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = loginBtn;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void eyeIcon_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtPassword.UseSystemPasswordChar = false;
                eyeIcon.Image = Properties.Resources.showEyeIcon;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                eyeIcon.Image = Properties.Resources.hiddenEyeIcon;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string inputUser = txtUsername.Text.Trim();
            string inputPass = txtPassword.Text;

            if (string.IsNullOrEmpty(inputUser) || string.IsNullOrEmpty(inputPass))
            {
                MessageBox.Show("Please enter both your username and password.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                User? currentUser = userRepo.GetUserByUsername(inputUser);

                if (currentUser != null && currentUser.Login(inputPass))
                {
                    MessageBox.Show($"Login successful! Welcome, {currentUser.Username} ({currentUser.Role}).", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainForm mainForm = new MainForm();
                    mainForm.FormClosed += (s, args) => this.Close();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A database error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void forgotPasswordLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (ForgotPasswordForm forgotForm = new ForgotPasswordForm())
            {
                forgotForm.ShowDialog();
            }
            this.Show(); 
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}