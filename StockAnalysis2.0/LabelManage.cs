using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StockAnalysis2._0
{
    public partial class LabelManage : Form
    {
        public LabelManage()
        {
            InitializeComponent();
        }

        private void LabelManage_Load(object sender, EventArgs e)
        {
            //加载用户名
            Form1 f1 = new Form1();
            this.userNameL.Text = f1.userName;
            //注册事件
            this.Saccount.Click += Saccount_Click;
            this.Smain.Click += Smain_Click;
            this.Slabel.Click += Slabel_Click;
            this.Sexit.Click += Sexit_Click;
            this.Stock.Click += Stock_Click;
            this.Smarket.Click += Smarket_Click;
        }

        private void Smarket_Click(object sender, EventArgs e)
        {
            MarketManage market = new MarketManage();
            market.Show();
            this.Close();
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            StockManage stock = new StockManage();
            stock.Show();
            this.Close();
        }

        private void Sexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Slabel_Click(object sender, EventArgs e)
        {
            LabelManage label = new LabelManage();
            label.Show();
            this.Close();
        }

        private void Smain_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void Saccount_Click(object sender, EventArgs e)
        {
            UserManager user = new UserManager();
            user.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
