using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StockAnalysis2._0
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.exit.Text = f1.userName;
        }




        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            userManager.Show();
            this.Close();
        }
    }
}
