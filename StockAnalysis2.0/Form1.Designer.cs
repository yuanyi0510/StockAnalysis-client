namespace StockAnalysis2._0
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.RemberPwd = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ForgetPwd = new DevComponents.DotNetBar.LabelX();
            this.Register = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.Logo = new DevComponents.DotNetBar.LabelX();
            this.ExitLogin = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.UserName = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(63, 136);
            this.textBoxX1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(199, 21);
            this.textBoxX1.TabIndex = 4;
            // 
            // textBoxX2
            // 
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.Location = new System.Drawing.Point(63, 180);
            this.textBoxX2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.PreventEnterBeep = true;
            this.textBoxX2.Size = new System.Drawing.Size(199, 21);
            this.textBoxX2.TabIndex = 5;
            // 
            // RemberPwd
            // 
            // 
            // 
            // 
            this.RemberPwd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RemberPwd.Location = new System.Drawing.Point(27, 230);
            this.RemberPwd.Name = "RemberPwd";
            this.RemberPwd.Size = new System.Drawing.Size(100, 23);
            this.RemberPwd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RemberPwd.TabIndex = 7;
            this.RemberPwd.Text = "记住密码";
            this.RemberPwd.CheckedChanged += new System.EventHandler(this.RemberPwd_CheckedChanged);
            // 
            // ForgetPwd
            // 
            // 
            // 
            // 
            this.ForgetPwd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ForgetPwd.Location = new System.Drawing.Point(170, 230);
            this.ForgetPwd.Name = "ForgetPwd";
            this.ForgetPwd.Size = new System.Drawing.Size(56, 23);
            this.ForgetPwd.TabIndex = 8;
            this.ForgetPwd.Text = "忘记密码";
            this.ForgetPwd.Click += new System.EventHandler(this.ForgetPwd_Click);
            // 
            // Register
            // 
            // 
            // 
            // 
            this.Register.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Register.Location = new System.Drawing.Point(232, 230);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(30, 23);
            this.Register.TabIndex = 9;
            this.Register.Text = "注册";
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(27, 283);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(15);
            this.buttonX1.Size = new System.Drawing.Size(235, 34);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 10;
            this.buttonX1.Text = "登 录";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // Logo
            // 
            // 
            // 
            // 
            this.Logo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Logo.Image = global::StockAnalysis2._0.Properties.Resources.logo2;
            this.Logo.Location = new System.Drawing.Point(76, 12);
            this.Logo.Name = "Logo";
            this.Logo.SingleLineColor = System.Drawing.SystemColors.Control;
            this.Logo.Size = new System.Drawing.Size(150, 100);
            this.Logo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Logo.TabIndex = 6;
            this.Logo.Text = "labelX1";
            // 
            // ExitLogin
            // 
            // 
            // 
            // 
            this.ExitLogin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ExitLogin.Image = global::StockAnalysis2._0.Properties.Resources.login_exit;
            this.ExitLogin.Location = new System.Drawing.Point(268, 0);
            this.ExitLogin.Margin = new System.Windows.Forms.Padding(2);
            this.ExitLogin.Name = "ExitLogin";
            this.ExitLogin.Size = new System.Drawing.Size(33, 31);
            this.ExitLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ExitLogin.TabIndex = 3;
            this.ExitLogin.Click += new System.EventHandler(this.ExitLogin_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Image = global::StockAnalysis2._0.Properties.Resources.login_pwd;
            this.labelX2.Location = new System.Drawing.Point(27, 172);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(30, 30);
            this.labelX2.TabIndex = 2;
            // 
            // UserName
            // 
            // 
            // 
            // 
            this.UserName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.UserName.Image = global::StockAnalysis2._0.Properties.Resources.login_username;
            this.UserName.Location = new System.Drawing.Point(27, 127);
            this.UserName.Margin = new System.Windows.Forms.Padding(2);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(30, 30);
            this.UserName.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 340);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.ForgetPwd);
            this.Controls.Add(this.RemberPwd);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.ExitLogin);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX UserName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX ExitLogin;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.LabelX Logo;
        private DevComponents.DotNetBar.LabelX ForgetPwd;
        private DevComponents.DotNetBar.Controls.CheckBoxX RemberPwd;
        private DevComponents.DotNetBar.LabelX Register;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}

