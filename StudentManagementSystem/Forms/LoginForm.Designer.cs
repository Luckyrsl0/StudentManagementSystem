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
            ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeIcon).BeginInit();
            SuspendLayout();
            // 
            // logoImage
            // 
            logoImage.BackgroundImageLayout = ImageLayout.Zoom;
            logoImage.Image = Properties.Resources.Logo;
            logoImage.Location = new Point(63, 11);
            logoImage.Margin = new Padding(3, 2, 3, 2);
            logoImage.Name = "logoImage";
            logoImage.Size = new Size(269, 134);
            logoImage.SizeMode = PictureBoxSizeMode.Zoom;
            logoImage.TabIndex = 0;
            logoImage.TabStop = false;
            // 
            // personIcon
            // 
            personIcon.Image = Properties.Resources.PersonIcon;
            personIcon.Location = new Point(47, 194);
            personIcon.Margin = new Padding(3, 2, 3, 2);
            personIcon.Name = "personIcon";
            personIcon.Size = new Size(44, 31);
            personIcon.SizeMode = PictureBoxSizeMode.Zoom;
            personIcon.TabIndex = 1;
            personIcon.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(47, 229);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 2);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(47, 303);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 2);
            panel2.TabIndex = 4;
            // 
            // eyeIcon
            // 
            eyeIcon.Cursor = Cursors.Hand;
            eyeIcon.Image = Properties.Resources.HiddenEyeIcon;
            eyeIcon.Location = new Point(47, 268);
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
            loginBtn.BackColor = SystemColors.HotTrack;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = SystemColors.Control;
            loginBtn.Location = new Point(108, 357);
            loginBtn.Margin = new Padding(3, 2, 3, 2);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(176, 49);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Log in";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.BackColor = SystemColors.Control;
            loginLabel.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel.ForeColor = SystemColors.Highlight;
            loginLabel.Location = new Point(125, 147);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(139, 39);
            loginLabel.TabIndex = 6;
            loginLabel.Text = "LOG IN";
            loginLabel.TextAlign = ContentAlignment.MiddleCenter;
            loginLabel.Click += loginLabel_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Control;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = SystemColors.Highlight;
            txtUsername.Location = new Point(97, 200);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(249, 22);
            txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = SystemColors.Highlight;
            txtPassword.Location = new Point(97, 274);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(249, 22);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 434);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
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
    }
}