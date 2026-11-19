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
            menuStrip1 = new MenuStrip();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            coursesToolStripMenuItem = new ToolStripMenuItem();
            inrollmentsToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            healthToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            newStudentStripLabel = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            stripSearchLabel = new ToolStripLabel();
            panel1 = new Panel();
            logoutBtn = new Button();
            UserAdminBtn = new Button();
            enrollmentsBtn = new Button();
            courseBtn = new Button();
            studentBtn = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            homeLabel = new Label();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.MenuHighlight;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentsToolStripMenuItem, coursesToolStripMenuItem, inrollmentsToolStripMenuItem, usersToolStripMenuItem, healthToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(898, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(65, 20);
            studentsToolStripMenuItem.Text = "Students";
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(61, 20);
            coursesToolStripMenuItem.Text = "Courses";
            // 
            // inrollmentsToolStripMenuItem
            // 
            inrollmentsToolStripMenuItem.Name = "inrollmentsToolStripMenuItem";
            inrollmentsToolStripMenuItem.Size = new Size(82, 20);
            inrollmentsToolStripMenuItem.Text = "Enrollments";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(47, 20);
            usersToolStripMenuItem.Text = "Users";
            // 
            // healthToolStripMenuItem
            // 
            healthToolStripMenuItem.Name = "healthToolStripMenuItem";
            healthToolStripMenuItem.Size = new Size(44, 20);
            healthToolStripMenuItem.Text = "Help";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ControlLightLight;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { newStudentStripLabel, toolStripSeparator1, stripSearchLabel });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(898, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // newStudentStripLabel
            // 
            newStudentStripLabel.BackColor = SystemColors.Highlight;
            newStudentStripLabel.Name = "newStudentStripLabel";
            newStudentStripLabel.Size = new Size(75, 22);
            newStudentStripLabel.Text = "New Student";
            newStudentStripLabel.Click += toolStripLabel2_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // stripSearchLabel
            // 
            stripSearchLabel.BackColor = SystemColors.GradientActiveCaption;
            stripSearchLabel.Name = "stripSearchLabel";
            stripSearchLabel.Size = new Size(42, 22);
            stripSearchLabel.Text = "Search";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(UserAdminBtn);
            panel1.Controls.Add(enrollmentsBtn);
            panel1.Controls.Add(courseBtn);
            panel1.Controls.Add(studentBtn);
            panel1.Location = new Point(0, 51);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 433);
            panel1.TabIndex = 2;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = SystemColors.Control;
            logoutBtn.ForeColor = SystemColors.ActiveCaptionText;
            logoutBtn.Location = new Point(12, 375);
            logoutBtn.Margin = new Padding(3, 2, 3, 2);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(195, 43);
            logoutBtn.TabIndex = 4;
            logoutBtn.Text = "Log out";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += button5_Click;
            // 
            // UserAdminBtn
            // 
            UserAdminBtn.BackColor = SystemColors.ControlLightLight;
            UserAdminBtn.Location = new Point(3, 213);
            UserAdminBtn.Margin = new Padding(3, 2, 3, 2);
            UserAdminBtn.Name = "UserAdminBtn";
            UserAdminBtn.Size = new Size(214, 73);
            UserAdminBtn.TabIndex = 3;
            UserAdminBtn.Text = "User Management";
            UserAdminBtn.UseVisualStyleBackColor = false;
            UserAdminBtn.Click += button4_Click;
            // 
            // enrollmentsBtn
            // 
            enrollmentsBtn.BackColor = SystemColors.ControlLightLight;
            enrollmentsBtn.Location = new Point(3, 136);
            enrollmentsBtn.Margin = new Padding(3, 2, 3, 2);
            enrollmentsBtn.Name = "enrollmentsBtn";
            enrollmentsBtn.Size = new Size(214, 72);
            enrollmentsBtn.TabIndex = 2;
            enrollmentsBtn.Text = "Enrollments";
            enrollmentsBtn.UseVisualStyleBackColor = false;
            // 
            // courseBtn
            // 
            courseBtn.BackColor = SystemColors.ControlLightLight;
            courseBtn.Location = new Point(3, 69);
            courseBtn.Margin = new Padding(3, 2, 3, 2);
            courseBtn.Name = "courseBtn";
            courseBtn.Size = new Size(214, 63);
            courseBtn.TabIndex = 1;
            courseBtn.Text = "Courses";
            courseBtn.UseVisualStyleBackColor = false;
            // 
            // studentBtn
            // 
            studentBtn.BackColor = SystemColors.ControlLightLight;
            studentBtn.ForeColor = SystemColors.ActiveCaptionText;
            studentBtn.Location = new Point(3, 2);
            studentBtn.Margin = new Padding(3, 2, 3, 2);
            studentBtn.Name = "studentBtn";
            studentBtn.Size = new Size(214, 62);
            studentBtn.TabIndex = 0;
            studentBtn.Text = "Students";
            studentBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(homeLabel);
            panel2.Location = new Point(223, 51);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(675, 433);
            panel2.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.InactiveCaption;
            panel4.Location = new Point(15, 67);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(648, 341);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Location = new Point(15, 48);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(648, 10);
            panel3.TabIndex = 1;
            // 
            // homeLabel
            // 
            homeLabel.AutoSize = true;
            homeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeLabel.ForeColor = SystemColors.Highlight;
            homeLabel.Location = new Point(15, 24);
            homeLabel.Name = "homeLabel";
            homeLabel.Size = new Size(41, 15);
            homeLabel.TabIndex = 0;
            homeLabel.Text = "Home";
            homeLabel.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(898, 480);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem inrollmentsToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem healthToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripLabel newStudentStripLabel;
        private ToolStripLabel stripSearchLabel;
        private Panel panel1;
        private Panel panel2;
        private Button courseBtn;
        private Button studentBtn;
        private Button UserAdminBtn;
        private Button enrollmentsBtn;
        private Button logoutBtn;
        private Label homeLabel;
        private Panel panel3;
        private Panel panel4;
        private ToolStripSeparator toolStripSeparator1;
    }
}