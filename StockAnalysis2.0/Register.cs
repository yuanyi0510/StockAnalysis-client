using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StockAnalysis2._0
{
    public partial class Register : Form
    {

        private User u;//修改用户信息
        private bool flag;//是否为修改
        public Register()
        {
            InitializeComponent();
         
        }
        public Register(User user,bool flag)
        {
            InitializeComponent();
            this.u = user;
            this.flag = flag;

        }

        private void labelX1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        
            
        //注册
        private void RegisterUser_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                //修改用户信息
                bool isSuccess1 = true;
                if (isSuccess1)
                {
                    MessageBox.Show("修改成功！");
                    UserManager user = new UserManager();
                    user.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }

            }
            else
            {
                //注册用户
                bool isSuccess = true;
                if (isSuccess)
                {
                    MessageBox.Show("注册成功！");
                    Form1 login = new Form1();
                    login.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("注册失败！");
                }
            }

            
        }

        private void Department_Enter(object sender, EventArgs e)
        {
            bool firstLoad = false;
            if (this.Department.Text.Equals("工号"))
            {
                if (firstLoad)
                {
                    this.Department.Clear();          
                    firstLoad = true;
                }
                this.Department.ForeColor = Color.Black;

            }
        }

        private void Department_Leave(object sender, EventArgs e)
        {
            string department = this.Department.Text;
            if (department.Equals(""))
            {
                this.Department.Text = "工号";
                this.Department.ForeColor = Color.LightGray;
            }
        }

        private void UserName_Enter(object sender, EventArgs e)
        {
            string username = this.UserName.Text;
            if (username.Equals("用户名"))
            {
                this.UserName.Clear();
                this.UserName.ForeColor = Color.Black;
            }
        }

        private void UserName_Leave(object sender, EventArgs e)
        {
            
            if (this.UserName.Text.Equals(""))
            {
                this.UserName.Text = "用户名";
                this.UserName.ForeColor = Color.LightGray;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {        
            if (this.Password.Text.Equals("密码"))
            {
                this.Password.Clear();
                this.Password.ForeColor = Color.Black;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            string pwd = this.Password.Text;
            if (pwd == "")
            {
                this.Password.Text = "密码";
                this.Password.ForeColor = Color.LightGray;
            }
        }

        private void ConfirmPwd_Enter(object sender, EventArgs e)
        {
            string confirmpwd = this.ConfirmPwd.Text;
            if (confirmpwd.Equals("确认密码"))
            {
                this.ConfirmPwd.Clear();
                this.ConfirmPwd.ForeColor = Color.Black;
            }
        }

        private void ConfirmPwd_Leave(object sender, EventArgs e)
        {
            string conPwd = this.ConfirmPwd.Text;
            bool isPwd = conPwd.Equals(this.Password.Text);
            if (conPwd == "")
            {
                this.ConfirmPwd.Text = "确认密码";
                this.ConfirmPwd.ForeColor = Color.LightGray;
            }
            if (!this.ConfirmPwd.Text.Equals("确认密码"))
            {
                if (!isPwd)
                {
                    this.PwdTip.Visible = true;
                }
                else
                {
                    this.PwdTip.Visible = false;
                }
            }
        }

        private void Tel_Enter(object sender, EventArgs e)
        {
            string tel = this.Tel.Text;
            if (tel.Equals("电话"))
            {
                this.Tel.Clear();
                this.Tel.ForeColor = Color.Black;
            }
        }

        private void Tel_Leave(object sender, EventArgs e)
        {
            string tel = this.Tel.Text;
            bool isTel = System.Text.RegularExpressions.Regex.IsMatch(tel, @"^[1]+[3,4,7,5,8]+\d{9}");
            if (tel == "")
            {
                this.Tel.Text = "电话";
                this.Tel.ForeColor = Color.LightGray;
            }
            if (!this.Tel.Text.Equals("电话"))
            {
                if (isTel)
                {
                    this.TelTip.Visible = false;
                }
                else
                {
                    this.TelTip.Visible = true;
                }
            }
        }

        private void Dept_Enter(object sender, EventArgs e)
        {
            string dept = this.Dept.Text;
            if (dept.Equals("部门"))
            {
                this.Dept.Clear();
                this.Dept.ForeColor = Color.Black;
            }

        }

        private void Dept_Leave(object sender, EventArgs e)
        {
            string dept = this.Dept.Text;
            if (dept == "")
            {
                this.Dept.Text = "部门";
                this.Dept.ForeColor = Color.LightGray;
            }
        }


        private void Register_Activated(object sender, EventArgs e)
        {

            this.RegisterDepartment.Focus();
            if (flag && u!=null)
            {
                this.RegisterUser.Text = "修改信息";
                this.Department.Text = u.UId.ToString();
                this.Department.ForeColor= Color.Black;
                this.Dept.Text = u.Dept;
                this.Dept.ForeColor = Color.Black;
                this.UserName.Text = u.UserName;
                this.UserName.ForeColor = Color.Black;
                this.Password.Text = u.Pwd;
                this.Password.ForeColor = Color.Black;
                this.Tel.Text = u.Tel;
                this.Tel.ForeColor = Color.Black;
                this.ConfirmPwd.Text = u.Pwd;
                this.ConfirmPwd.ForeColor = Color.Black;
            }
        }
    }
}
