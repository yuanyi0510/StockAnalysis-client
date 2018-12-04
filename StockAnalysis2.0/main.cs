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
        //进入账户管理界面
        private void buttonX2_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            userManager.Show();
            this.Close();
        }
        //进入标签管理
        private void buttonX3_Click(object sender, EventArgs e)
        {
            LabelManage labelManage = new LabelManage();
            labelManage.Show();
            this.Close();
        }
        //进入市场管理
        private void buttonX4_Click(object sender, EventArgs e)
        {
            MarketManage marketManage = new MarketManage();
            marketManage.Show();
            this.Close();
        }
        //进入股票管理
        private void buttonX5_Click(object sender, EventArgs e)
        {
            StockManage stockManage = new StockManage();
            stockManage.Show();
            this.Close();
        }
    }
}
