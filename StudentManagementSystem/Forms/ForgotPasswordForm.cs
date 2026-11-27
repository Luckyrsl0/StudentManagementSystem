using System;
using System.Windows.Forms;
using StudentManagementSystem.Model;

namespace StudentManagementSystem.Forms
{
    public partial class ForgotPasswordForm : Form
    {
        private readonly UserRepository userRepo = new UserRepository();

        public ForgotPasswordForm()
        {
            InitializeComponent();
            this.AcceptButton = btnVerifyUsername;
        }

        private void btnVerifyUsername_Click(object sender, EventArgs e)
        {
            string inputUser = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(inputUser))
            {
                MessageBox.Show("Please enter your username.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                User? user = userRepo.GetUserByUsername(inputUser);

                if (user != null)
                {
                    this.Hide();
                    using (ResetPasswordForm resetForm = new ResetPasswordForm(user.Username))
                    {
                        resetForm.ShowDialog();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username not found. Please check and try again.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A database error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backToLoginLink_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}