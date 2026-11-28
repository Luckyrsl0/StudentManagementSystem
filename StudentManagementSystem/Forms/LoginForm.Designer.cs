namespace StudentManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logoImage = new PictureBox();
            personIcon = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            eyeIcon = new PictureBox();
            loginBtn = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            forgotPasswordLink = new Label();
            wavesPanel = new Panel();
            ExitLabel = new Label();
            loginLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeIcon).BeginInit();
            wavesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // logoImage
            // 
            logoImage.BackgroundImageLayout = ImageLayout.Zoom;
            logoImage.Image = Properties.Resources.logo;
            logoImage.Location = new Point(73, 44);
            logoImage.Margin = new Padding(3, 2, 3, 2);
            logoImage.Name = "logoImage";
            logoImage.Size = new Size(269, 134);
            logoImage.SizeMode = PictureBoxSizeMode.Zoom;
            logoImage.TabIndex = 0;
            logoImage.TabStop = false;
            // 
            // personIcon
            // 
            personIcon.Image = Properties.Resources.person;
            personIcon.Location = new Point(501, 57);
            personIcon.Margin = new Padding(3, 2, 3, 2);
            personIcon.Name = "personIcon";
            personIcon.Size = new Size(44, 31);
            personIcon.SizeMode = PictureBoxSizeMode.Zoom;
            personIcon.TabIndex = 1;
            personIcon.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 40, 84);
            panel1.Location = new Point(501, 92);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 2);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 40, 84);
            panel2.Location = new Point(501, 166);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 2);
            panel2.TabIndex = 4;
            // 
            // eyeIcon
            // 
            eyeIcon.Cursor = Cursors.Hand;
            eyeIcon.Image = Properties.Resources.hiddenEyeIcon;
            eyeIcon.Location = new Point(501, 130);
            eyeIcon.Margin = new Padding(3, 2, 3, 2);
            eyeIcon.Name = "eyeIcon";
            eyeIcon.Size = new Size(44, 31);
            eyeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            eyeIcon.TabIndex = 3;
            eyeIcon.TabStop = false;
            eyeIcon.Click += eyeIcon_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(15, 40, 84);
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = SystemColors.Control;
            loginBtn.Location = new Point(570, 208);
            loginBtn.Margin = new Padding(3, 2, 3, 2);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(176, 49);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Log in";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(248, 250, 252);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.FromArgb(28, 77, 141);
            txtUsername.Location = new Point(555, 63);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(249, 22);
            txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(248, 250, 252);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(28, 77, 141);
            txtPassword.Location = new Point(551, 136);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(249, 20);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // forgotPasswordLink
            // 
            forgotPasswordLink.AutoSize = true;
            forgotPasswordLink.Cursor = Cursors.Hand;
            forgotPasswordLink.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forgotPasswordLink.ForeColor = Color.FromArgb(28, 77, 141);
            forgotPasswordLink.Location = new Point(690, 170);
            forgotPasswordLink.Name = "forgotPasswordLink";
            forgotPasswordLink.Size = new Size(105, 17);
            forgotPasswordLink.TabIndex = 11;
            forgotPasswordLink.Text = "Forgot Password";
            forgotPasswordLink.Click += forgotPasswordLink_Click;
            // 
            // wavesPanel
            // 
            wavesPanel.BackgroundImage = Properties.Resources.wave;
            wavesPanel.BackgroundImageLayout = ImageLayout.Stretch;
            wavesPanel.Controls.Add(ExitLabel);
            wavesPanel.Controls.Add(loginLabel);
            wavesPanel.Location = new Point(-4, 44);
            wavesPanel.Name = "wavesPanel";
            wavesPanel.Size = new Size(894, 303);
            wavesPanel.TabIndex = 12;
            // 
            // ExitLabel
            // 
            ExitLabel.AutoSize = true;
            ExitLabel.BackColor = Color.Transparent;
            ExitLabel.Cursor = Cursors.Hand;
            ExitLabel.FlatStyle = FlatStyle.Flat;
            ExitLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitLabel.ForeColor = Color.White;
            ExitLabel.Location = new Point(645, 213);
            ExitLabel.Name = "ExitLabel";
            ExitLabel.Size = new Size(39, 22);
            ExitLabel.TabIndex = 10;
            ExitLabel.Text = "Exit";
            ExitLabel.Click += ExitLabel_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.BackColor = Color.Transparent;
            loginLabel.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel.ForeColor = Color.FromArgb(15, 40, 84);
            loginLabel.Location = new Point(134, 141);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(141, 47);
            loginLabel.TabIndex = 7;
            loginLabel.Text = "LOG IN";
            loginLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(885, 327);
            Controls.Add(forgotPasswordLink);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(loginBtn);
            Controls.Add(panel2);
            Controls.Add(eyeIcon);
            Controls.Add(panel1);
            Controls.Add(personIcon);
            Controls.Add(logoImage);
            Controls.Add(wavesPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)logoImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)personIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeIcon).EndInit();
            wavesPanel.ResumeLayout(false);
            wavesPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoImage;
        private PictureBox personIcon;
        private Panel panel1;
        private Panel panel2;
        private PictureBox eyeIcon;
        private Button loginBtn;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label forgotPasswordLink;
        private Panel wavesPanel;
        private Label ExitLabel;
        private Label loginLabel;
    }
}