using StudentManagementSystem.Forms;

namespace StudentManagementSystem
{
    public partial class LoginForm : Form
    {
        // true = password is visible (open eye), false = password is masked (slashed eye)
        private bool isPasswordVisible = false;

        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = loginBtn;
        }

        private void eyeIcon_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtPassword.UseSystemPasswordChar = false;
                eyeIcon.Image = Properties.Resources.ShowEyeIcon;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                eyeIcon.Image = Properties.Resources.HiddenEyeIcon;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin1234")
            {
                MessageBox.Show("Login successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm mainForm = new MainForm();
                mainForm.FormClosed += (s, args) => this.Close(); // Mo-exit ang tibuok app inig close sa MainForm
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.FromArgb(19, 99, 212);
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.FromArgb(19, 99, 212);
                txtPassword.UseSystemPasswordChar = true; // Mask the password when user starts typing
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
                txtPassword.UseSystemPasswordChar = false; // Show the placeholder text when the field is empty
            }
        }
    }
}
