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
           
        }



        private void textBoxX1_Leave(object sender, EventArgs e)
        {
            this.textBoxX1.Text = "失去焦点";
        }

        private void textBoxX1_Enter(object sender, EventArgs e)
        {
            this.textBoxX1.Text = "获取焦点";
        }

        private void textBoxX2_Leave(object sender, EventArgs e)
        {
            this.textBoxX2.Text = "失去焦点";

        }

        private void textBoxX2_Enter(object sender, EventArgs e)
        {
            this.textBoxX2.Text = "获取焦点";
        }

        private void textBoxX1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void textBoxX1_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
