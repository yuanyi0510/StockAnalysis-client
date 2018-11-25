namespace StockAnalysis2._0
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Department = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.UserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Dept = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Tel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ConfirmPwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.RegisterUser = new DevComponents.DotNetBar.ButtonX();
            this.PwdTip = new DevComponents.DotNetBar.LabelX();
            this.TelTip = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.RegisterName = new DevComponents.DotNetBar.LabelX();
            this.RegisterDepartment = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Department
            // 
            // 
            // 
            // 
            this.Department.Border.Class = "TextBoxBorder";
            this.Department.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Department.ForeColor = System.Drawing.Color.LightGray;
            this.Department.Location = new System.Drawing.Point(146, 84);
            this.Department.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Department.Name = "Department";
            this.Department.PreventEnterBeep = true;
            this.Department.Size = new System.Drawing.Size(256, 28);
            this.Department.TabIndex = 6;
            this.Department.Text = "工号";
            this.Department.Enter += new System.EventHandler(this.Department_Enter);
            this.Department.Leave += new System.EventHandler(this.Department_Leave);
            // 
            // UserName
            // 
            // 
            // 
            // 
            this.UserName.Border.Class = "TextBoxBorder";
            this.UserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.UserName.ForeColor = System.Drawing.Color.LightGray;
            this.UserName.Location = new System.Drawing.Point(146, 150);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserName.Name = "UserName";
            this.UserName.PreventEnterBeep = true;
            this.UserName.Size = new System.Drawing.Size(256, 28);
            this.UserName.TabIndex = 8;
            this.UserName.Text = "用户名";
            this.UserName.Enter += new System.EventHandler(this.UserName_Enter);
            this.UserName.Leave += new System.EventHandler(this.UserName_Leave);
            // 
            // Dept
            // 
            // 
            // 
            // 
            this.Dept.Border.Class = "TextBoxBorder";
            this.Dept.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Dept.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Dept.Location = new System.Drawing.Point(146, 406);
            this.Dept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dept.Name = "Dept";
            this.Dept.PreventEnterBeep = true;
            this.Dept.Size = new System.Drawing.Size(256, 28);
            this.Dept.TabIndex = 9;
            this.Dept.Text = "部门";
            this.Dept.Enter += new System.EventHandler(this.Dept_Enter);
            this.Dept.Leave += new System.EventHandler(this.Dept_Leave);
            // 
            // Tel
            // 
            // 
            // 
            // 
            this.Tel.Border.Class = "TextBoxBorder";
            this.Tel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Tel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Tel.Location = new System.Drawing.Point(146, 344);
            this.Tel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tel.Name = "Tel";
            this.Tel.PreventEnterBeep = true;
            this.Tel.Size = new System.Drawing.Size(256, 28);
            this.Tel.TabIndex = 10;
            this.Tel.Text = "电话";
            this.Tel.Enter += new System.EventHandler(this.Tel_Enter);
            this.Tel.Leave += new System.EventHandler(this.Tel_Leave);
            // 
            // Password
            // 
            // 
            // 
            // 
            this.Password.Border.Class = "TextBoxBorder";
            this.Password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Password.ForeColor = System.Drawing.Color.LightGray;
            this.Password.Location = new System.Drawing.Point(146, 213);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password.Name = "Password";
            this.Password.PreventEnterBeep = true;
            this.Password.Size = new System.Drawing.Size(256, 28);
            this.Password.TabIndex = 11;
            this.Password.Text = "密码";
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // ConfirmPwd
            // 
            // 
            // 
            // 
            this.ConfirmPwd.Border.Class = "TextBoxBorder";
            this.ConfirmPwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ConfirmPwd.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ConfirmPwd.Location = new System.Drawing.Point(146, 279);
            this.ConfirmPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfirmPwd.Name = "ConfirmPwd";
            this.ConfirmPwd.PreventEnterBeep = true;
            this.ConfirmPwd.Size = new System.Drawing.Size(256, 28);
            this.ConfirmPwd.TabIndex = 12;
            this.ConfirmPwd.Text = "确认密码";
            this.ConfirmPwd.Enter += new System.EventHandler(this.ConfirmPwd_Enter);
            this.ConfirmPwd.Leave += new System.EventHandler(this.ConfirmPwd_Leave);
            // 
            // RegisterUser
            // 
            this.RegisterUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.RegisterUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.RegisterUser.Location = new System.Drawing.Point(146, 477);
            this.RegisterUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegisterUser.Name = "RegisterUser";
            this.RegisterUser.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(15);
            this.RegisterUser.Size = new System.Drawing.Size(256, 52);
            this.RegisterUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RegisterUser.TabIndex = 17;
            this.RegisterUser.Text = "注 册";
            this.RegisterUser.Click += new System.EventHandler(this.RegisterUser_Click);
            // 
            // PwdTip
            // 
            // 
            // 
            // 
            this.PwdTip.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PwdTip.Location = new System.Drawing.Point(442, 279);
            this.PwdTip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PwdTip.Name = "PwdTip";
            this.PwdTip.Size = new System.Drawing.Size(150, 34);
            this.PwdTip.TabIndex = 18;
            this.PwdTip.Text = "两次密码不一致";
            this.PwdTip.Visible = false;
            // 
            // TelTip
            // 
            // 
            // 
            // 
            this.TelTip.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TelTip.Location = new System.Drawing.Point(442, 344);
            this.TelTip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TelTip.Name = "TelTip";
            this.TelTip.Size = new System.Drawing.Size(150, 34);
            this.TelTip.TabIndex = 19;
            this.TelTip.Text = "格式不正确";
            this.TelTip.Visible = false;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Image = global::StockAnalysis2._0.Properties.Resources.department1;
            this.labelX5.Location = new System.Drawing.Point(62, 394);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(45, 45);
            this.labelX5.TabIndex = 16;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Image = global::StockAnalysis2._0.Properties.Resources.tel;
            this.labelX4.Location = new System.Drawing.Point(62, 332);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(45, 45);
            this.labelX4.TabIndex = 15;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Image = global::StockAnalysis2._0.Properties.Resources.login_pwd;
            this.labelX3.Location = new System.Drawing.Point(62, 267);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(45, 45);
            this.labelX3.TabIndex = 14;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Image = global::StockAnalysis2._0.Properties.Resources.login_pwd;
            this.labelX2.Location = new System.Drawing.Point(62, 201);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(45, 45);
            this.labelX2.TabIndex = 13;
            // 
            // RegisterName
            // 
            // 
            // 
            // 
            this.RegisterName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RegisterName.Image = global::StockAnalysis2._0.Properties.Resources.login_username;
            this.RegisterName.Location = new System.Drawing.Point(62, 138);
            this.RegisterName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegisterName.Name = "RegisterName";
            this.RegisterName.Size = new System.Drawing.Size(45, 45);
            this.RegisterName.TabIndex = 7;
            // 
            // RegisterDepartment
            // 
            // 
            // 
            // 
            this.RegisterDepartment.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RegisterDepartment.Image = global::StockAnalysis2._0.Properties.Resources.account;
            this.RegisterDepartment.Location = new System.Drawing.Point(62, 72);
            this.RegisterDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegisterDepartment.Name = "RegisterDepartment";
            this.RegisterDepartment.SingleLineColor = System.Drawing.SystemColors.Control;
            this.RegisterDepartment.Size = new System.Drawing.Size(45, 45);
            this.RegisterDepartment.TabIndex = 1;
            this.RegisterDepartment.Text = "工号";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Image = global::StockAnalysis2._0.Properties.Resources.login_exit;
            this.labelX1.Location = new System.Drawing.Point(621, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(57, 50);
            this.labelX1.TabIndex = 0;
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(513, 141);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 21);
            this.textBox1.TabIndex = 20;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 544);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TelTip);
            this.Controls.Add(this.PwdTip);
            this.Controls.Add(this.RegisterUser);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.ConfirmPwd);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.Dept);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.RegisterName);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.RegisterDepartment);
            this.Controls.Add(this.labelX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Activated += new System.EventHandler(this.Register_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX RegisterDepartment;
        private DevComponents.DotNetBar.Controls.TextBoxX Department;
        private DevComponents.DotNetBar.LabelX RegisterName;
        private DevComponents.DotNetBar.Controls.TextBoxX UserName;
        private DevComponents.DotNetBar.Controls.TextBoxX Dept;
        private DevComponents.DotNetBar.Controls.TextBoxX Tel;
        private DevComponents.DotNetBar.Controls.TextBoxX Password;
        private DevComponents.DotNetBar.Controls.TextBoxX ConfirmPwd;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX RegisterUser;
        private DevComponents.DotNetBar.LabelX PwdTip;
        private DevComponents.DotNetBar.LabelX TelTip;
        private System.Windows.Forms.TextBox textBox1;
    }
}