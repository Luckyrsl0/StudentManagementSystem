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
            RibbonMenuPanel1 = new Panel();
            helpBtn = new Button();
            usbutton4 = new Button();
            Enbutton3 = new Button();
            Courbutton2 = new Button();
            Studbutton1 = new Button();
            AddSeaModPanel = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            Modlabel2 = new Label();
            filterText = new TextBox();
            LogoutBtn = new Button();
            userManageBtn = new Button();
            enrollBtn = new Button();
            courseBtn = new Button();
            studentBtn = new Button();
            addStudentBtn = new Button();
            panel3Front = new Panel();
            pictureBox1 = new PictureBox();
            Home = new Label();
            Bluepanel4 = new Panel();
            RibbonMenuPanel1.SuspendLayout();
            AddSeaModPanel.SuspendLayout();
            panel3Front.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // RibbonMenuPanel1
            // 
            RibbonMenuPanel1.BackColor = Color.FromArgb(19, 99, 212);
            RibbonMenuPanel1.Controls.Add(helpBtn);
            RibbonMenuPanel1.Controls.Add(usbutton4);
            RibbonMenuPanel1.Controls.Add(Enbutton3);
            RibbonMenuPanel1.Controls.Add(Courbutton2);
            RibbonMenuPanel1.Controls.Add(Studbutton1);
            RibbonMenuPanel1.Location = new Point(-9, -4);
            RibbonMenuPanel1.Margin = new Padding(3, 2, 3, 2);
            RibbonMenuPanel1.Name = "RibbonMenuPanel1";
            RibbonMenuPanel1.Size = new Size(910, 50);
            RibbonMenuPanel1.TabIndex = 1;
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
            helpBtn.Location = new Point(514, 10);
            helpBtn.Margin = new Padding(3, 2, 3, 2);
            helpBtn.Name = "helpBtn";
            helpBtn.Size = new Size(101, 32);
            helpBtn.TabIndex = 4;
            helpBtn.Text = "Help";
            helpBtn.UseVisualStyleBackColor = false;
            // 
            // usbutton4
            // 
            usbutton4.Cursor = Cursors.Hand;
            usbutton4.FlatAppearance.BorderSize = 0;
            usbutton4.FlatStyle = FlatStyle.Flat;
            usbutton4.Font = new Font("Century Gothic", 9F);
            usbutton4.ForeColor = Color.White;
            usbutton4.Image = Properties.Resources.person;
            usbutton4.ImageAlign = ContentAlignment.MiddleLeft;
            usbutton4.Location = new Point(416, 10);
            usbutton4.Margin = new Padding(3, 2, 3, 2);
            usbutton4.Name = "usbutton4";
            usbutton4.Size = new Size(95, 32);
            usbutton4.TabIndex = 3;
            usbutton4.Text = "Users";
            usbutton4.UseVisualStyleBackColor = false;
            usbutton4.Click += Usebutton4_Click;
            // 
            // Enbutton3
            // 
            Enbutton3.Cursor = Cursors.Hand;
            Enbutton3.FlatAppearance.BorderSize = 0;
            Enbutton3.FlatStyle = FlatStyle.Flat;
            Enbutton3.Font = new Font("Century Gothic", 9F);
            Enbutton3.ForeColor = Color.White;
            Enbutton3.Image = Properties.Resources.list;
            Enbutton3.ImageAlign = ContentAlignment.MiddleLeft;
            Enbutton3.Location = new Point(278, 10);
            Enbutton3.Margin = new Padding(3, 2, 3, 2);
            Enbutton3.Name = "Enbutton3";
            Enbutton3.Size = new Size(134, 33);
            Enbutton3.TabIndex = 2;
            Enbutton3.Text = "Enrollments";
            Enbutton3.UseVisualStyleBackColor = false;
            // 
            // Courbutton2
            // 
            Courbutton2.Cursor = Cursors.Hand;
            Courbutton2.FlatAppearance.BorderSize = 0;
            Courbutton2.FlatStyle = FlatStyle.Flat;
            Courbutton2.Font = new Font("Century Gothic", 9F);
            Courbutton2.ForeColor = Color.White;
            Courbutton2.Image = Properties.Resources.book;
            Courbutton2.ImageAlign = ContentAlignment.MiddleLeft;
            Courbutton2.Location = new Point(154, 10);
            Courbutton2.Margin = new Padding(3, 2, 3, 2);
            Courbutton2.Name = "Courbutton2";
            Courbutton2.Size = new Size(118, 32);
            Courbutton2.TabIndex = 1;
            Courbutton2.Text = "Courses";
            Courbutton2.UseVisualStyleBackColor = false;
            // 
            // Studbutton1
            // 
            Studbutton1.BackColor = Color.FromArgb(19, 99, 212);
            Studbutton1.Cursor = Cursors.Hand;
            Studbutton1.FlatAppearance.BorderSize = 0;
            Studbutton1.FlatStyle = FlatStyle.Flat;
            Studbutton1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Studbutton1.ForeColor = Color.White;
            Studbutton1.Image = Properties.Resources.people;
            Studbutton1.ImageAlign = ContentAlignment.MiddleLeft;
            Studbutton1.Location = new Point(28, 10);
            Studbutton1.Margin = new Padding(3, 2, 3, 2);
            Studbutton1.Name = "Studbutton1";
            Studbutton1.Size = new Size(120, 32);
            Studbutton1.TabIndex = 0;
            Studbutton1.Text = "Student";
            Studbutton1.UseVisualStyleBackColor = false;
            // 
            // AddSeaModPanel
            // 
            AddSeaModPanel.BackColor = SystemColors.InactiveBorder;
            AddSeaModPanel.Controls.Add(panel6);
            AddSeaModPanel.Controls.Add(panel5);
            AddSeaModPanel.Controls.Add(Modlabel2);
            AddSeaModPanel.Controls.Add(filterText);
            AddSeaModPanel.Controls.Add(LogoutBtn);
            AddSeaModPanel.Controls.Add(userManageBtn);
            AddSeaModPanel.Controls.Add(enrollBtn);
            AddSeaModPanel.Controls.Add(courseBtn);
            AddSeaModPanel.Controls.Add(studentBtn);
            AddSeaModPanel.Controls.Add(addStudentBtn);
            AddSeaModPanel.Location = new Point(19, 46);
            AddSeaModPanel.Margin = new Padding(3, 2, 3, 2);
            AddSeaModPanel.Name = "AddSeaModPanel";
            AddSeaModPanel.Size = new Size(219, 448);
            AddSeaModPanel.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(212, 212, 212);
            panel6.Location = new Point(11, 376);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 1);
            panel6.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(212, 212, 212);
            panel5.Location = new Point(11, 125);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 1);
            panel5.TabIndex = 0;
            // 
            // Modlabel2
            // 
            Modlabel2.AutoSize = true;
            Modlabel2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Modlabel2.ForeColor = Color.FromArgb(107, 103, 103);
            Modlabel2.Location = new Point(11, 136);
            Modlabel2.Name = "Modlabel2";
            Modlabel2.Size = new Size(57, 16);
            Modlabel2.TabIndex = 8;
            Modlabel2.Text = "Modules";
            // 
            // filterText
            // 
            filterText.Cursor = Cursors.Hand;
            filterText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterText.ForeColor = Color.FromArgb(19, 99, 212);
            filterText.Location = new Point(16, 73);
            filterText.Margin = new Padding(3, 2, 3, 2);
            filterText.Multiline = true;
            filterText.Name = "filterText";
            filterText.Size = new Size(186, 34);
            filterText.TabIndex = 7;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.IndianRed;
            LogoutBtn.Cursor = Cursors.Hand;
            LogoutBtn.FlatAppearance.BorderColor = Color.Red;
            LogoutBtn.FlatAppearance.BorderSize = 0;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutBtn.ForeColor = Color.White;
            LogoutBtn.Image = Properties.Resources.logout;
            LogoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutBtn.Location = new Point(11, 382);
            LogoutBtn.Margin = new Padding(3, 2, 3, 2);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(199, 39);
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
            userManageBtn.Font = new Font("Century Gothic", 9F);
            userManageBtn.ForeColor = Color.White;
            userManageBtn.Image = Properties.Resources.people;
            userManageBtn.ImageAlign = ContentAlignment.MiddleLeft;
            userManageBtn.Location = new Point(16, 290);
            userManageBtn.Margin = new Padding(3, 2, 3, 2);
            userManageBtn.Name = "userManageBtn";
            userManageBtn.Size = new Size(186, 36);
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
            enrollBtn.Font = new Font("Century Gothic", 9F);
            enrollBtn.ForeColor = Color.White;
            enrollBtn.Image = Properties.Resources.list;
            enrollBtn.ImageAlign = ContentAlignment.MiddleLeft;
            enrollBtn.Location = new Point(16, 247);
            enrollBtn.Margin = new Padding(3, 2, 3, 2);
            enrollBtn.Name = "enrollBtn";
            enrollBtn.Size = new Size(186, 39);
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
            courseBtn.Font = new Font("Century Gothic", 9F);
            courseBtn.ForeColor = Color.White;
            courseBtn.Image = Properties.Resources.book;
            courseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            courseBtn.Location = new Point(16, 208);
            courseBtn.Margin = new Padding(3, 2, 3, 2);
            courseBtn.Name = "courseBtn";
            courseBtn.Size = new Size(186, 35);
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
            studentBtn.Font = new Font("Century Gothic", 9F);
            studentBtn.ForeColor = Color.White;
            studentBtn.Image = Properties.Resources.people;
            studentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            studentBtn.Location = new Point(16, 169);
            studentBtn.Margin = new Padding(3, 2, 3, 2);
            studentBtn.Name = "studentBtn";
            studentBtn.Size = new Size(186, 35);
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
            addStudentBtn.Location = new Point(16, 31);
            addStudentBtn.Margin = new Padding(3, 2, 3, 2);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(186, 38);
            addStudentBtn.TabIndex = 1;
            addStudentBtn.Text = "New Student";
            addStudentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addStudentBtn.UseVisualStyleBackColor = false;
            // 
            // panel3Front
            // 
            panel3Front.BackColor = SystemColors.InactiveBorder;
            panel3Front.Controls.Add(pictureBox1);
            panel3Front.Controls.Add(Home);
            panel3Front.Controls.Add(Bluepanel4);
            panel3Front.Location = new Point(253, 53);
            panel3Front.Margin = new Padding(3, 2, 3, 2);
            panel3Front.Name = "panel3Front";
            panel3Front.Size = new Size(633, 421);
            panel3Front.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(19, 99, 212);
            pictureBox1.Image = Properties.Resources.home_filled;
            pictureBox1.Location = new Point(15, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            Home.AutoSize = true;
            Home.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Home.Location = new Point(54, 11);
            Home.Name = "Home";
            Home.RightToLeft = RightToLeft.Yes;
            Home.Size = new Size(52, 18);
            Home.TabIndex = 1;
            Home.Text = "Home";
            // 
            // Bluepanel4
            // 
            Bluepanel4.BackColor = Color.RoyalBlue;
            Bluepanel4.Location = new Point(29, 62);
            Bluepanel4.Margin = new Padding(3, 2, 3, 2);
            Bluepanel4.Name = "Bluepanel4";
            Bluepanel4.Size = new Size(579, 337);
            Bluepanel4.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 222, 222);
            ClientSize = new Size(898, 480);
            Controls.Add(panel3Front);
            Controls.Add(AddSeaModPanel);
            Controls.Add(RibbonMenuPanel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            RibbonMenuPanel1.ResumeLayout(false);
            AddSeaModPanel.ResumeLayout(false);
            AddSeaModPanel.PerformLayout();
            panel3Front.ResumeLayout(false);
            panel3Front.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel RibbonMenuPanel1;
        private Panel AddSeaModPanel;
        private Panel panel5;
        private Panel panel3Front;
        private Panel Bluepanel4;
        private Button helpBtn;
        private Button usbutton4;
        private Button Enbutton3;
        private Button Courbutton2;
        private Button Studbutton1;
        private Button LogoutBtn;
        private Button userManageBtn;
        private Button enrollBtn;
        private Button courseBtn;
        private Button studentBtn;
        private Button addStudentBtn;
        private Label Modlabel2;
        private TextBox filterText;
        private Label Home;
        private PictureBox pictureBox1;
        private Panel panel6;
    }
}