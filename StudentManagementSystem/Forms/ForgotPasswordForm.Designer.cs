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
            panel3 = new Panel();
            backLabel = new Label();
            continueBtn = new Button();
            logoImage = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            txtUsername = new TextBox();
            personIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personIcon).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.ForeColor = SystemColors.ControlLight;
            panel3.Location = new Point(424, 43);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(2, 242);
            panel3.TabIndex = 21;
            // 
            // backLabel
            // 
            backLabel.AutoSize = true;
            backLabel.Cursor = Cursors.Hand;
            backLabel.FlatStyle = FlatStyle.Flat;
            backLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backLabel.ForeColor = SystemColors.Highlight;
            backLabel.Location = new Point(591, 258);
            backLabel.Name = "backLabel";
            backLabel.Size = new Size(134, 22);
            backLabel.TabIndex = 20;
            backLabel.Text = "Back to Login";
            // 
            // continueBtn
            // 
            continueBtn.BackColor = SystemColors.HotTrack;
            continueBtn.Cursor = Cursors.Hand;
            continueBtn.FlatStyle = FlatStyle.Flat;
            continueBtn.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            continueBtn.ForeColor = SystemColors.HighlightText;
            continueBtn.Location = new Point(552, 207);
            continueBtn.Margin = new Padding(3, 2, 3, 2);
            continueBtn.Name = "continueBtn";
            continueBtn.Size = new Size(219, 49);
            continueBtn.TabIndex = 16;
            continueBtn.Text = "Continue";
            continueBtn.UseVisualStyleBackColor = false;
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
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(507, 183);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 2);
            panel1.TabIndex = 13;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Control;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(560, 154);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(249, 22);
            txtUsername.TabIndex = 18;
            // 
            // personIcon
            // 
            personIcon.Image = Properties.Resources.PersonIcon;
            personIcon.Location = new Point(507, 148);
            personIcon.Margin = new Padding(3, 2, 3, 2);
            personIcon.Name = "personIcon";
            personIcon.Size = new Size(44, 31);
            personIcon.SizeMode = PictureBoxSizeMode.Zoom;
            personIcon.TabIndex = 12;
            personIcon.TabStop = false;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 327);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(backLabel);
            Controls.Add(txtUsername);
            Controls.Add(continueBtn);
            Controls.Add(panel1);
            Controls.Add(personIcon);
            Controls.Add(logoImage);
            ForeColor = SystemColors.Highlight;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPasswordForm";
            ((System.ComponentModel.ISupportInitialize)logoImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)personIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Label backLabel;
        private Button continueBtn;
        private PictureBox logoImage;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private TextBox txtUsername;
        private PictureBox personIcon;
    }
}