using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StockAnalysis2._0
{
    public partial class StockManage : Form
    {
        public StockManage()
        {
            InitializeComponent();
        }

        private void StockManage_Load(object sender, EventArgs e)
        {
            //加载用户名
            Form1 f1 = new Form1();
            this.userNameL.Text = f1.userName;
            //注册事件
            this.Sexit.Click += Sexit_Click;
            this.Smain.Click += Smain_Click;
            this.Slabel.Click += Slabel_Click;
            this.Smarket.Click += Smarket_Click;
            this.Saccount.Click += Saccount_Click;

            //test
            List<Stock> students = new List<Stock>();
            Stock hat = new Stock(1, "12", "Male");
            Stock peter = new Stock(2, "14", "Male");
            Stock dell = new Stock(3, "16", "Male");
            Stock anne = new Stock(3, "19", "Female");
            students.Add(hat);
            students.Add(peter);
            students.Add(dell);
            students.Add(anne);
            this.dataGridViewX1.DataSource = students;
        }

        private void Saccount_Click(object sender, EventArgs e)
        {
            UserManager user = new UserManager();
            user.Show();
            this.Close();
        }

        private void Smarket_Click(object sender, EventArgs e)
        {
            MarketManage market = new MarketManage();
            market.Show();
            this.Close();
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

        private void Sexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewX1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("您点击了");
        }
    }

    public class Stock
    {
        private int code;
        private string name;
        private string market;

        public Stock(int code, string name, string market)
        {
            this.code = code;
            this.name = name;
            this.market = market;
        }

        public int Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Market { get => market; set => market = value; }

    }
}
