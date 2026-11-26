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
            panel3.Location = new Point(484, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(2, 322);
            panel3.TabIndex = 21;
            // 
            // backLabel
            // 
            backLabel.AutoSize = true;
            backLabel.Cursor = Cursors.Hand;
            backLabel.FlatStyle = FlatStyle.Flat;
            backLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backLabel.ForeColor = Color.Black;
            backLabel.Location = new Point(670, 344);
            backLabel.Name = "backLabel";
            backLabel.Size = new Size(173, 30);
            backLabel.TabIndex = 20;
            backLabel.Text = "Back to Login";
            // 
            // continueBtn
            // 
            continueBtn.BackColor = SystemColors.Control;
            continueBtn.Cursor = Cursors.Hand;
            continueBtn.FlatStyle = FlatStyle.Flat;
            continueBtn.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            continueBtn.ForeColor = Color.Black;
            continueBtn.Location = new Point(631, 276);
            continueBtn.Name = "continueBtn";
            continueBtn.Size = new Size(250, 65);
            continueBtn.TabIndex = 16;
            continueBtn.Text = "Continue";
            continueBtn.UseVisualStyleBackColor = false;
            // 
            // logoImage
            // 
            logoImage.BackgroundImageLayout = ImageLayout.Zoom;
            logoImage.Location = new Point(103, 104);
            logoImage.Name = "logoImage";
            logoImage.Size = new Size(307, 179);
            logoImage.SizeMode = PictureBoxSizeMode.Zoom;
            logoImage.TabIndex = 11;
            logoImage.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(579, 77);
            label1.Name = "label1";
            label1.Size = new Size(79, 40);
            label1.TabIndex = 22;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(579, 117);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 23;
            label2.Text = "caption";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(579, 244);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 3);
            panel1.TabIndex = 13;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Control;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(640, 206);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(285, 29);
            txtUsername.TabIndex = 18;
            // 
            // personIcon
            // 
            personIcon.Location = new Point(579, 198);
            personIcon.Name = "personIcon";
            personIcon.Size = new Size(50, 41);
            personIcon.SizeMode = PictureBoxSizeMode.Zoom;
            personIcon.TabIndex = 12;
            personIcon.TabStop = false;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 436);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(backLabel);
            Controls.Add(txtUsername);
            Controls.Add(continueBtn);
            Controls.Add(panel1);
            Controls.Add(personIcon);
            Controls.Add(logoImage);
            FormBorderStyle = FormBorderStyle.None;
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