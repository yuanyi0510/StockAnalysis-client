using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StockAnalysis2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        //记住密码
        private void RemberPwd_CheckedChanged(object sender, EventArgs e)
        {

        }
        //忘记密码
        private void ForgetPwd_Click(object sender, EventArgs e)
        {
            ForgetPwd forget = new ForgetPwd();
            forget.Show();
            this.Hide();
        }

        //注册
        private void Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        //登录
        private void buttonX1_Click(object sender, EventArgs e)
        {
            Main ma = new Main();
            ma.Show();
            this.Hide();

        }
    }
}
