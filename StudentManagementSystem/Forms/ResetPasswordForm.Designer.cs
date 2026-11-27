namespace StudentManagementSystem.Forms
{
    partial class ResetPasswordForm
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
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            backToLoginLink = new Label();
            btnResetPassword = new Button();
            logoImage = new PictureBox();
            txtConfirmPassword = new TextBox();
            panel2 = new Panel();
            confirmPassEyeIcon = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtNewPassword = new TextBox();
            panel1 = new Panel();
            newPassEyeIcon = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)confirmPassEyeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newPassEyeIcon).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(499, 53);
            label2.Name = "label2";
            label2.Size = new Size(294, 38);
            label2.TabIndex = 32;
            label2.Text = "Create a new password for your account. Make sure it is secure and easy for you to remember.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(499, 23);
            label1.Name = "label1";
            label1.Size = new Size(215, 32);
            label1.TabIndex = 31;
            label1.Text = "Reset Password";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.ForeColor = SystemColors.ControlLight;
            panel3.Location = new Point(416, 43);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(2, 242);
            panel3.TabIndex = 30;
            // 
            // backToLoginLink
            // 
            backToLoginLink.AutoSize = true;
            backToLoginLink.Cursor = Cursors.Hand;
            backToLoginLink.FlatStyle = FlatStyle.Flat;
            backToLoginLink.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backToLoginLink.ForeColor = SystemColors.HotTrack;
            backToLoginLink.Location = new Point(581, 292);
            backToLoginLink.Name = "backToLoginLink";
            backToLoginLink.Size = new Size(134, 22);
            backToLoginLink.TabIndex = 29;
            backToLoginLink.Text = "Back to Login";
            backToLoginLink.Click += backToLoginLink_Click;
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = SystemColors.HotTrack;
            btnResetPassword.Cursor = Cursors.Hand;
            btnResetPassword.FlatStyle = FlatStyle.Flat;
            btnResetPassword.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetPassword.ForeColor = SystemColors.Control;
            btnResetPassword.Location = new Point(544, 251);
            btnResetPassword.Margin = new Padding(3, 2, 3, 2);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(219, 38);
            btnResetPassword.TabIndex = 27;
            btnResetPassword.Text = "Continue";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // logoImage
            // 
            logoImage.BackgroundImageLayout = ImageLayout.Zoom;
            logoImage.Image = Properties.Resources.shiel;
            logoImage.Location = new Point(82, 78);
            logoImage.Margin = new Padding(3, 2, 3, 2);
            logoImage.Name = "logoImage";
            logoImage.Size = new Size(269, 134);
            logoImage.SizeMode = PictureBoxSizeMode.Zoom;
            logoImage.TabIndex = 24;
            logoImage.TabStop = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = SystemColors.Control;
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.ForeColor = Color.FromArgb(19, 99, 212);
            txtConfirmPassword.Location = new Point(544, 155);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Confirm new password";
            txtConfirmPassword.Size = new Size(200, 20);
            txtConfirmPassword.TabIndex = 35;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(494, 184);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 2);
            panel2.TabIndex = 34;
            // 
            // confirmPassEyeIcon
            // 
            confirmPassEyeIcon.Cursor = Cursors.Hand;
            confirmPassEyeIcon.Image = Properties.Resources.HiddenEyeIcon;
            confirmPassEyeIcon.Location = new Point(750, 149);
            confirmPassEyeIcon.Margin = new Padding(3, 2, 3, 2);
            confirmPassEyeIcon.Name = "confirmPassEyeIcon";
            confirmPassEyeIcon.Size = new Size(44, 31);
            confirmPassEyeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            confirmPassEyeIcon.TabIndex = 33;
            confirmPassEyeIcon.TabStop = false;
            confirmPassEyeIcon.Click += confirmPassEyeIcon_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources._lock;
            pictureBox1.Location = new Point(494, 149);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(494, 93);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = SystemColors.Control;
            txtNewPassword.BorderStyle = BorderStyle.None;
            txtNewPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.ForeColor = Color.FromArgb(19, 99, 212);
            txtNewPassword.Location = new Point(544, 99);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PlaceholderText = "Enter new password";
            txtNewPassword.Size = new Size(200, 20);
            txtNewPassword.TabIndex = 39;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(494, 128);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 2);
            panel1.TabIndex = 38;
            // 
            // newPassEyeIcon
            // 
            newPassEyeIcon.Cursor = Cursors.Hand;
            newPassEyeIcon.Image = Properties.Resources.HiddenEyeIcon;
            newPassEyeIcon.Location = new Point(750, 93);
            newPassEyeIcon.Margin = new Padding(3, 2, 3, 2);
            newPassEyeIcon.Name = "newPassEyeIcon";
            newPassEyeIcon.Size = new Size(44, 31);
            newPassEyeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            newPassEyeIcon.TabIndex = 37;
            newPassEyeIcon.TabStop = false;
            newPassEyeIcon.Click += newPassEyeIcon_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(510, 196);
            label3.Name = "label3";
            label3.Size = new Size(132, 17);
            label3.TabIndex = 41;
            label3.Text = "At least 8 characters";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(510, 211);
            label4.Name = "label4";
            label4.Size = new Size(251, 17);
            label4.TabIndex = 42;
            label4.Text = "Include uppercase and lowercase letters";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(510, 226);
            label5.Name = "label5";
            label5.Size = new Size(174, 17);
            label5.TabIndex = 43;
            label5.Text = "Include at least one number";
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 327);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtNewPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(newPassEyeIcon);
            Controls.Add(confirmPassEyeIcon);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(backToLoginLink);
            Controls.Add(btnResetPassword);
            Controls.Add(logoImage);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ResetPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetPasswordForm";
            ((System.ComponentModel.ISupportInitialize)logoImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)confirmPassEyeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)newPassEyeIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel3;
        private Label backToLoginLink;
        private Button btnResetPassword;
        private PictureBox logoImage;
        private TextBox txtConfirmPassword;
        private Panel panel2;
        private PictureBox confirmPassEyeIcon;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtNewPassword;
        private Panel panel1;
        private PictureBox newPassEyeIcon;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}