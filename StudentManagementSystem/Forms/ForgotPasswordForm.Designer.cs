namespace StudentManagementSystem.Forms
{
    partial class ForgotPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVerifyUsername = new Button();
            panel1 = new Panel();
            txtUsername = new TextBox();
            personIcon = new PictureBox();
            logoImage = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            backToLoginLink = new Label();
            ((System.ComponentModel.ISupportInitialize)personIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnVerifyUsername
            // 
            btnVerifyUsername.BackColor = Color.FromArgb(11, 45, 107);
            btnVerifyUsername.Cursor = Cursors.Hand;
            btnVerifyUsername.FlatAppearance.BorderSize = 0;
            btnVerifyUsername.FlatStyle = FlatStyle.Flat;
            btnVerifyUsername.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerifyUsername.ForeColor = SystemColors.HighlightText;
            btnVerifyUsername.Location = new Point(552, 207);
            btnVerifyUsername.Margin = new Padding(3, 2, 3, 2);
            btnVerifyUsername.Name = "btnVerifyUsername";
            btnVerifyUsername.Size = new Size(219, 49);
            btnVerifyUsername.TabIndex = 16;
            btnVerifyUsername.Text = "Continue";
            btnVerifyUsername.UseVisualStyleBackColor = false;
            btnVerifyUsername.Click += btnVerifyUsername_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 40, 84);
            panel1.Location = new Point(507, 183);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 2);
            panel1.TabIndex = 13;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(248, 250, 252);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.FromArgb(28, 77, 141);
            txtUsername.Location = new Point(560, 154);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(249, 22);
            txtUsername.TabIndex = 18;
            // 
            // personIcon
            // 
            personIcon.Image = Properties.Resources.person;
            personIcon.Location = new Point(507, 148);
            personIcon.Margin = new Padding(3, 2, 3, 2);
            personIcon.Name = "personIcon";
            personIcon.Size = new Size(44, 31);
            personIcon.SizeMode = PictureBoxSizeMode.Zoom;
            personIcon.TabIndex = 12;
            personIcon.TabStop = false;
            // 
            // logoImage
            // 
            logoImage.BackgroundImageLayout = ImageLayout.Zoom;
            logoImage.Image = Properties.Resources.mail;
            logoImage.Location = new Point(90, 78);
            logoImage.Margin = new Padding(3, 2, 3, 2);
            logoImage.Name = "logoImage";
            logoImage.Size = new Size(269, 134);
            logoImage.SizeMode = PictureBoxSizeMode.Zoom;
            logoImage.TabIndex = 11;
            logoImage.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(248, 250, 252);
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(11, 45, 107);
            label1.Location = new Point(507, 58);
            label1.Name = "label1";
            label1.Size = new Size(227, 32);
            label1.TabIndex = 22;
            label1.Text = "Forgot Password";
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(507, 90);
            label2.Name = "label2";
            label2.Size = new Size(273, 56);
            label2.TabIndex = 23;
            label2.Text = "Having trouble accessing your account? Enter your username to identify your account and get assistance with password recovery.";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.wave2;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(backToLoginLink);
            panel2.Location = new Point(-42, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(938, 238);
            panel2.TabIndex = 24;
            // 
            // backToLoginLink
            // 
            backToLoginLink.AutoSize = true;
            backToLoginLink.BackColor = Color.Transparent;
            backToLoginLink.Cursor = Cursors.Hand;
            backToLoginLink.FlatStyle = FlatStyle.Flat;
            backToLoginLink.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backToLoginLink.ForeColor = Color.White;
            backToLoginLink.Location = new Point(638, 260);
            backToLoginLink.Name = "backToLoginLink";
            backToLoginLink.Size = new Size(134, 22);
            backToLoginLink.TabIndex = 21;
            backToLoginLink.Text = "Back to Login";
            backToLoginLink.Click += backToLoginLink_Click;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(885, 327);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(btnVerifyUsername);
            Controls.Add(panel1);
            Controls.Add(personIcon);
            Controls.Add(logoImage);
            Controls.Add(panel2);
            ForeColor = SystemColors.Highlight;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPasswordForm";
            ((System.ComponentModel.ISupportInitialize)personIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoImage).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVerifyUsername;
        private Panel panel1;
        private TextBox txtUsername;
        private PictureBox personIcon;
        private PictureBox logoImage;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label backToLoginLink;
    }
}