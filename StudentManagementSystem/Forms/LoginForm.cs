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

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
