using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StockAnalysis2._0
{
    public partial class ForgetPwd : Form
    {
        public ForgetPwd()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

        }

        private void ConfirmPwd_Leave(object sender, EventArgs e)
        {
            string pwd = this.NewPwd.Text;
            string conpwd = this.ConfirmPwd.Text;
            if (conpwd == "")
            {
                this.updateTip.Text = "确认密码不能为空";
                this.updateTip.Visible = true;

            }
            else
            {
                if (!conpwd.Equals(pwd))
                {
                    this.updateTip.Text = "两次密码不一致";
                    this.updateTip.Visible = true;
                }
            }
           
        }


        private void NewPwd_Leave(object sender, EventArgs e)
        {
            if (this.NewPwd.Text=="")
            {
                this.newTip.Visible = true;
            }
        }

        private void OldPwd_Leave(object sender, EventArgs e)
        {
            if (this.OldPwd.Text=="")
            {
                this.oldTip.Visible = true;
            }
        }

        private void Account_Leave(object sender, EventArgs e)
        {
            if (this.Account.Text=="")
            {
                this.accountTip.Visible = true;
            }
           
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            bool isSuccess = true;
            if (isSuccess)
            {
                //注册成功，跳转登陆界面
                MessageBox.Show("修改成功");
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
            else
            {
                //注册失败，清空文本框
                MessageBox.Show("修改失败");
                this.Account.Clear();
                this.OldPwd.Clear();
                this.NewPwd.Clear();
                this.ConfirmPwd.Clear();
            }
        }
    }
}
