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
            loginLabel = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            ExitLabel = new Label();
            panel3 = new Panel();
            forgotLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeIcon).BeginInit();
            SuspendLayout();
            // 
            // logoImage
            // 
            logoImage.BackgroundImageLayout = ImageLayout.Zoom;
            logoImage.Image = Properties.Resources.Logo;
            logoImage.Location = new Point(83, 58);
            logoImage.Name = "logoImage";
            logoImage.Size = new Size(307, 179);
            logoImage.SizeMode = PictureBoxSizeMode.Zoom;
            logoImage.TabIndex = 0;
            logoImage.TabStop = false;
            // 
            // personIcon
            // 
            personIcon.Image = Properties.Resources.PersonIcon;
            personIcon.Location = new Point(573, 76);
            personIcon.Name = "personIcon";
            personIcon.Size = new Size(50, 41);
            personIcon.SizeMode = PictureBoxSizeMode.Zoom;
            personIcon.TabIndex = 1;
            personIcon.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(573, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 3);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(573, 221);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 3);
            panel2.TabIndex = 4;
            // 
            // eyeIcon
            // 
            eyeIcon.Cursor = Cursors.Hand;
            eyeIcon.Image = Properties.Resources.HiddenEyeIcon;
            eyeIcon.Location = new Point(573, 174);
            eyeIcon.Name = "eyeIcon";
            eyeIcon.Size = new Size(50, 41);
            eyeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            eyeIcon.TabIndex = 3;
            eyeIcon.TabStop = false;
            eyeIcon.Click += eyeIcon_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = SystemColors.HotTrack;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = SystemColors.Control;
            loginBtn.Location = new Point(652, 277);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(201, 65);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Log in";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.BackColor = SystemColors.Control;
            loginLabel.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel.ForeColor = SystemColors.Highlight;
            loginLabel.Location = new Point(153, 250);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(178, 60);
            loginLabel.TabIndex = 6;
            loginLabel.Text = "LOG IN";
            loginLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Control;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.FromArgb(19, 99, 212);
            txtUsername.Location = new Point(634, 84);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(285, 29);
            txtUsername.TabIndex = 7;
            txtUsername.PlaceholderText = "Username";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(19, 99, 212);
            txtPassword.Location = new Point(630, 182);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(285, 25);
            txtPassword.TabIndex = 8;
            txtPassword.PlaceholderText = "Password";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // ExitLabel
            // 
            ExitLabel.AutoSize = true;
            ExitLabel.Cursor = Cursors.Hand;
            ExitLabel.FlatStyle = FlatStyle.Flat;
            ExitLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitLabel.ForeColor = SystemColors.HotTrack;
            ExitLabel.Location = new Point(726, 350);
            ExitLabel.Name = "ExitLabel";
            ExitLabel.Size = new Size(52, 30);
            ExitLabel.TabIndex = 9;
            ExitLabel.Text = "Exit";
            ExitLabel.Click += ExitLabel_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.Location = new Point(480, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(2, 322);
            panel3.TabIndex = 10;
            // 
            // forgotLabel
            // 
            forgotLabel.AutoSize = true;
            forgotLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forgotLabel.ForeColor = SystemColors.MenuHighlight;
            forgotLabel.Location = new Point(789, 227);
            forgotLabel.Name = "forgotLabel";
            forgotLabel.Size = new Size(130, 20);
            forgotLabel.TabIndex = 11;
            forgotLabel.Text = "Forgot Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 436);
            Controls.Add(forgotLabel);
            Controls.Add(panel3);
            Controls.Add(ExitLabel);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(loginLabel);
            Controls.Add(loginBtn);
            Controls.Add(panel2);
            Controls.Add(eyeIcon);
            Controls.Add(panel1);
            Controls.Add(personIcon);
            Controls.Add(logoImage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)logoImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)personIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeIcon).EndInit();
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
        private Label loginLabel;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label ExitLabel;
        private Panel panel3;
        private Label forgotLabel;
    }
}