using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StockAnalysis2._0
{


        public partial class StockDetail : Form
    {
        public StockDetail()
        {
            InitializeComponent();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {
            StockManage stockManage = new StockManage();
            stockManage.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(button1.DataBindings.ToString());

        }
    }


    public class Student2
    {
        public int Id { set; get; }
        public string Name { set; get; }
    }
}
