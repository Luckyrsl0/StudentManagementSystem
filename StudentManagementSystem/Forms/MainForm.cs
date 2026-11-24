using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }


        private void Usebutton4_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        
        }
        private void filterText_Enter(object sender, EventArgs e)
        {
            if (filterText.Text == "Search")
            {
                filterText.Text = "";
                filterText.ForeColor = Color.FromArgb(19, 99, 212);
            }
        }

        private void filterText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(filterText.Text))
            {
                filterText.Text = "Search";
                filterText.ForeColor = Color.Silver;
            }
 
        }
    }
}
