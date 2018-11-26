using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StockAnalysis2._0
{
    public partial class UserManager : Form
    {
        public UserManager()
        {
            InitializeComponent();
        }


        private void UserManager_Load(object sender, EventArgs e)
        {
            //加载用户名
            Form1 f1 = new Form1();
            this.userNameL.Text = f1.userName;

            //radial menu菜单事件
            Exit.Click += Exit_Click;
            Slabel.Click += Slabel_Click;
            Smarket.Click += Smarket_Click;
            Stock.Click += Stock_Click;
            Saccount.Click += Saccount_Click1;
            Smain.Click += Smain_Click;

            //查询用户信息
            this.ID.Text = "1";
            this.Account.Text = "1234";
            this.Dept.Text = "产品";
            this.Tel.Text = "13456789223";
            this.Username.Text = "张三";
            this.Password.Text = "1234";
            this.Note.Text = "fkjdsjfkdjsfjdjfjdsfdksjfkldsjflkdsjkjfksjdfjdsjfljf";

        }
        //主界面
        private void Smain_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
       
        //账户
        private void Saccount_Click1(object sender, EventArgs e)
        {
            
        }
        //股票
        private void Stock_Click(object sender, EventArgs e)
        {
            StockManage stock = new StockManage();
            stock.Show();
            this.Close();
        }
        //市场
        private void Smarket_Click(object sender, EventArgs e)
        {
            MarketManage market = new MarketManage();
            market.Show();
            this.Close();
        }
        //标签
        private void Slabel_Click(object sender, EventArgs e)
        {
            LabelManage label = new LabelManage();
            label.Show();
            this.Close();
        }
        //退出
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //修改信息
        private void UpdateInfo_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Id1 = Convert.ToInt32( this.ID.Text);
            u.UId = Convert.ToInt32(this.Account.Text);
            u.Dept = this.Dept.Text;
            u.UserName = this.Username.Text;
            u.Pwd = this.Password.Text;
            u.Note = this.Note.Text;
            u.Tel = this.Tel.Text;

            //打开修改界面
            Register re = new Register(u, true);
            re.Show();
            this.Close();

        }
    }
}
