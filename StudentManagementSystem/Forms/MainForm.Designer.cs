namespace StudentManagementSystem.Forms
{
    partial class MainForm
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
            panel1 = new Panel();
            helpBtn = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            filterText = new TextBox();
            LogoutBtn = new Button();
            userManageBtn = new Button();
            enrollBtn = new Button();
            courseBtn = new Button();
            studentBtn = new Button();
            addStudentBtn = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            Home = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 99, 212);
            panel1.Controls.Add(helpBtn);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-10, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1169, 67);
            panel1.TabIndex = 1;
            // 
            // helpBtn
            // 
            helpBtn.Cursor = Cursors.Hand;
            helpBtn.FlatAppearance.BorderSize = 0;
            helpBtn.FlatStyle = FlatStyle.Flat;
            helpBtn.Font = new Font("Century Gothic", 9F);
            helpBtn.ForeColor = Color.White;
            helpBtn.Image = Properties.Resources.help;
            helpBtn.ImageAlign = ContentAlignment.MiddleLeft;
            helpBtn.Location = new Point(587, 13);
            helpBtn.Name = "helpBtn";
            helpBtn.Size = new Size(115, 43);
            helpBtn.TabIndex = 4;
            helpBtn.Text = "Help";
            helpBtn.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 9F);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.person;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(475, 13);
            button4.Name = "button4";
            button4.Size = new Size(109, 43);
            button4.TabIndex = 3;
            button4.Text = "Users";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 9F);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.list;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(318, 13);
            button3.Name = "button3";
            button3.Size = new Size(153, 44);
            button3.TabIndex = 2;
            button3.Text = "Enrollments";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9F);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.book;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(176, 13);
            button2.Name = "button2";
            button2.Size = new Size(135, 43);
            button2.TabIndex = 1;
            button2.Text = "Courses";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(19, 99, 212);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.people;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(32, 13);
            button1.Name = "button1";
            button1.Size = new Size(137, 43);
            button1.TabIndex = 0;
            button1.Text = "Student";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveBorder;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(filterText);
            panel2.Controls.Add(LogoutBtn);
            panel2.Controls.Add(userManageBtn);
            panel2.Controls.Add(enrollBtn);
            panel2.Controls.Add(courseBtn);
            panel2.Controls.Add(studentBtn);
            panel2.Controls.Add(addStudentBtn);
            panel2.Location = new Point(22, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 597);
            panel2.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(212, 212, 212);
            panel6.Location = new Point(13, 501);
            panel6.Name = "panel6";
            panel6.Size = new Size(280, 1);
            panel6.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(212, 212, 212);
            panel5.Location = new Point(13, 167);
            panel5.Name = "panel5";
            panel5.Size = new Size(280, 1);
            panel5.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(107, 103, 103);
            label2.Location = new Point(13, 181);
            label2.Name = "label2";
            label2.Size = new Size(71, 18);
            label2.TabIndex = 8;
            label2.Text = "Modules";
            // 
            // filterText
            // 
            filterText.Cursor = Cursors.Hand;
            filterText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterText.ForeColor = Color.FromArgb(19, 99, 212); 
            filterText.Location = new Point(18, 97);
            filterText.Multiline = true;
            filterText.Name = "filterText";
            filterText.Size = new Size(271, 44);
            filterText.TabIndex = 7;
            filterText.PlaceholderText = "Search";
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.IndianRed;
            LogoutBtn.Cursor = Cursors.Hand;
            LogoutBtn.FlatAppearance.BorderColor = Color.Red;
            LogoutBtn.FlatAppearance.BorderSize = 0;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            LogoutBtn.ForeColor = Color.White;
            LogoutBtn.Image = Properties.Resources.logout;
            LogoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutBtn.Location = new Point(18, 512);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(272, 52);
            LogoutBtn.TabIndex = 6;
            LogoutBtn.Text = "Log Out";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // userManageBtn
            // 
            userManageBtn.BackColor = Color.RoyalBlue;
            userManageBtn.Cursor = Cursors.Hand;
            userManageBtn.FlatAppearance.BorderSize = 0;
            userManageBtn.FlatStyle = FlatStyle.Flat;
            userManageBtn.Font = new Font("Century Gothic", 11.25F);
            userManageBtn.ForeColor = Color.White;
            userManageBtn.Image = Properties.Resources.people;
            userManageBtn.ImageAlign = ContentAlignment.MiddleLeft;
            userManageBtn.Location = new Point(18, 387);
            userManageBtn.Name = "userManageBtn";
            userManageBtn.Size = new Size(272, 48);
            userManageBtn.TabIndex = 5;
            userManageBtn.Text = "User Management";
            userManageBtn.UseVisualStyleBackColor = false;
            // 
            // enrollBtn
            // 
            enrollBtn.BackColor = Color.RoyalBlue;
            enrollBtn.Cursor = Cursors.Hand;
            enrollBtn.FlatAppearance.BorderSize = 0;
            enrollBtn.FlatStyle = FlatStyle.Flat;
            enrollBtn.Font = new Font("Century Gothic", 11.25F);
            enrollBtn.ForeColor = Color.White;
            enrollBtn.Image = Properties.Resources.list;
            enrollBtn.ImageAlign = ContentAlignment.MiddleLeft;
            enrollBtn.Location = new Point(18, 329);
            enrollBtn.Name = "enrollBtn";
            enrollBtn.Size = new Size(272, 52);
            enrollBtn.TabIndex = 4;
            enrollBtn.Text = "Enrollments";
            enrollBtn.UseVisualStyleBackColor = false;
            // 
            // courseBtn
            // 
            courseBtn.BackColor = Color.RoyalBlue;
            courseBtn.Cursor = Cursors.Hand;
            courseBtn.FlatAppearance.BorderSize = 0;
            courseBtn.FlatStyle = FlatStyle.Flat;
            courseBtn.Font = new Font("Century Gothic", 11.25F);
            courseBtn.ForeColor = Color.White;
            courseBtn.Image = Properties.Resources.book;
            courseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            courseBtn.Location = new Point(18, 277);
            courseBtn.Name = "courseBtn";
            courseBtn.Size = new Size(272, 47);
            courseBtn.TabIndex = 3;
            courseBtn.Text = "Courses";
            courseBtn.UseVisualStyleBackColor = false;
            // 
            // studentBtn
            // 
            studentBtn.BackColor = Color.RoyalBlue;
            studentBtn.Cursor = Cursors.Hand;
            studentBtn.FlatAppearance.BorderSize = 0;
            studentBtn.FlatStyle = FlatStyle.Flat;
            studentBtn.Font = new Font("Century Gothic", 11.25F);
            studentBtn.ForeColor = Color.White;
            studentBtn.Image = Properties.Resources.people;
            studentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            studentBtn.Location = new Point(18, 225);
            studentBtn.Name = "studentBtn";
            studentBtn.Size = new Size(272, 47);
            studentBtn.TabIndex = 2;
            studentBtn.Text = "Student";
            studentBtn.UseVisualStyleBackColor = false;
            // 
            // addStudentBtn
            // 
            addStudentBtn.BackColor = Color.FromArgb(19, 99, 212);
            addStudentBtn.Cursor = Cursors.Hand;
            addStudentBtn.FlatStyle = FlatStyle.Flat;
            addStudentBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addStudentBtn.ForeColor = Color.White;
            addStudentBtn.Image = Properties.Resources.add;
            addStudentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addStudentBtn.Location = new Point(18, 41);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(272, 51);
            addStudentBtn.TabIndex = 1;
            addStudentBtn.Text = "New Student";
            addStudentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addStudentBtn.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveBorder;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(Home);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(333, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(803, 561);
            panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(19, 99, 212);
            pictureBox1.Image = Properties.Resources.home_filled;
            pictureBox1.Location = new Point(17, 15);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            Home.AutoSize = true;
            Home.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Home.Location = new Point(62, 15);
            Home.Name = "Home";
            Home.RightToLeft = RightToLeft.Yes;
            Home.Size = new Size(65, 23);
            Home.TabIndex = 1;
            Home.Text = "Home";
            // 
            // panel4
            // 
            panel4.BackColor = Color.RoyalBlue;
            panel4.Location = new Point(33, 83);
            panel4.Name = "panel4";
            panel4.Size = new Size(739, 449);
            panel4.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 222, 222);
            ClientSize = new Size(1150, 640);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel3;
        private Panel panel4;
        private Button helpBtn;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button LogoutBtn;
        private Button userManageBtn;
        private Button enrollBtn;
        private Button courseBtn;
        private Button studentBtn;
        private Button addStudentBtn;
        private Label label2;
        private TextBox filterText;
        private Label Home;
        private PictureBox pictureBox1;
        private Panel panel6;
    }
}