namespace StockAnalysis2._0
{
    partial class ForgetPwd
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.Account = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.NewPwdLogo = new DevComponents.DotNetBar.LabelX();
            this.OldPwdLogo = new DevComponents.DotNetBar.LabelX();
            this.AccountLogo = new DevComponents.DotNetBar.LabelX();
            this.exit = new DevComponents.DotNetBar.LabelX();
            this.OldPwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.NewPwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ConfirmPwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.updateTip = new DevComponents.DotNetBar.LabelX();
            this.newTip = new DevComponents.DotNetBar.LabelX();
            this.oldTip = new DevComponents.DotNetBar.LabelX();
            this.accountTip = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Image = global::StockAnalysis2._0.Properties.Resources.newpwd;
            this.labelX1.Location = new System.Drawing.Point(25, 200);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(91, 26);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "确认密码";
            // 
            // Account
            // 
            // 
            // 
            // 
            this.Account.Border.Class = "TextBoxBorder";
            this.Account.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Account.Location = new System.Drawing.Point(110, 62);
            this.Account.Name = "Account";
            this.Account.PreventEnterBeep = true;
            this.Account.Size = new System.Drawing.Size(166, 21);
            this.Account.TabIndex = 6;
            this.Account.Leave += new System.EventHandler(this.Account_Leave);
            // 
            // NewPwdLogo
            // 
            // 
            // 
            // 
            this.NewPwdLogo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NewPwdLogo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewPwdLogo.Image = global::StockAnalysis2._0.Properties.Resources.newpwd;
            this.NewPwdLogo.Location = new System.Drawing.Point(25, 152);
            this.NewPwdLogo.Name = "NewPwdLogo";
            this.NewPwdLogo.Size = new System.Drawing.Size(75, 26);
            this.NewPwdLogo.TabIndex = 3;
            this.NewPwdLogo.Text = "新密码";
            // 
            // OldPwdLogo
            // 
            // 
            // 
            // 
            this.OldPwdLogo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.OldPwdLogo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OldPwdLogo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OldPwdLogo.Image = global::StockAnalysis2._0.Properties.Resources.pwd1;
            this.OldPwdLogo.Location = new System.Drawing.Point(25, 102);
            this.OldPwdLogo.Name = "OldPwdLogo";
            this.OldPwdLogo.Size = new System.Drawing.Size(91, 26);
            this.OldPwdLogo.TabIndex = 2;
            this.OldPwdLogo.Text = "旧密码";
            // 
            // AccountLogo
            // 
            // 
            // 
            // 
            this.AccountLogo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.AccountLogo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AccountLogo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AccountLogo.Image = global::StockAnalysis2._0.Properties.Resources.account1;
            this.AccountLogo.Location = new System.Drawing.Point(25, 57);
            this.AccountLogo.Name = "AccountLogo";
            this.AccountLogo.Size = new System.Drawing.Size(91, 26);
            this.AccountLogo.TabIndex = 1;
            this.AccountLogo.Text = "工号";
            // 
            // exit
            // 
            // 
            // 
            // 
            this.exit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.exit.Image = global::StockAnalysis2._0.Properties.Resources.login_exit;
            this.exit.Location = new System.Drawing.Point(275, 0);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(40, 28);
            this.exit.TabIndex = 0;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // OldPwd
            // 
            // 
            // 
            // 
            this.OldPwd.Border.Class = "TextBoxBorder";
            this.OldPwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.OldPwd.Location = new System.Drawing.Point(110, 107);
            this.OldPwd.Name = "OldPwd";
            this.OldPwd.PreventEnterBeep = true;
            this.OldPwd.Size = new System.Drawing.Size(166, 21);
            this.OldPwd.TabIndex = 7;
            this.OldPwd.Leave += new System.EventHandler(this.OldPwd_Leave);
            // 
            // NewPwd
            // 
            // 
            // 
            // 
            this.NewPwd.Border.Class = "TextBoxBorder";
            this.NewPwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NewPwd.Location = new System.Drawing.Point(110, 157);
            this.NewPwd.Name = "NewPwd";
            this.NewPwd.PreventEnterBeep = true;
            this.NewPwd.Size = new System.Drawing.Size(166, 21);
            this.NewPwd.TabIndex = 8;
            this.NewPwd.Leave += new System.EventHandler(this.NewPwd_Leave);
            // 
            // ConfirmPwd
            // 
            // 
            // 
            // 
            this.ConfirmPwd.Border.Class = "TextBoxBorder";
            this.ConfirmPwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ConfirmPwd.Location = new System.Drawing.Point(110, 205);
            this.ConfirmPwd.Name = "ConfirmPwd";
            this.ConfirmPwd.PreventEnterBeep = true;
            this.ConfirmPwd.Size = new System.Drawing.Size(166, 21);
            this.ConfirmPwd.TabIndex = 9;
            this.ConfirmPwd.Leave += new System.EventHandler(this.ConfirmPwd_Leave);
            // 
            // updateTip
            // 
            // 
            // 
            // 
            this.updateTip.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.updateTip.Location = new System.Drawing.Point(110, 232);
            this.updateTip.Name = "updateTip";
            this.updateTip.Size = new System.Drawing.Size(166, 15);
            this.updateTip.TabIndex = 10;
            this.updateTip.Text = "两次密码不一致";
            this.updateTip.Visible = false;
            // 
            // newTip
            // 
            // 
            // 
            // 
            this.newTip.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.newTip.Location = new System.Drawing.Point(110, 184);
            this.newTip.Name = "newTip";
            this.newTip.Size = new System.Drawing.Size(166, 15);
            this.newTip.TabIndex = 11;
            this.newTip.Text = "新密码不能为空";
            this.newTip.Visible = false;
            // 
            // oldTip
            // 
            // 
            // 
            // 
            this.oldTip.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.oldTip.Location = new System.Drawing.Point(110, 136);
            this.oldTip.Name = "oldTip";
            this.oldTip.Size = new System.Drawing.Size(166, 15);
            this.oldTip.TabIndex = 12;
            this.oldTip.Text = "旧密码不能为空";
            this.oldTip.Visible = false;
            // 
            // accountTip
            // 
            // 
            // 
            // 
            this.accountTip.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.accountTip.Location = new System.Drawing.Point(110, 86);
            this.accountTip.Name = "accountTip";
            this.accountTip.Size = new System.Drawing.Size(166, 15);
            this.accountTip.TabIndex = 13;
            this.accountTip.Text = "工号不能为空";
            this.accountTip.Visible = false;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(73, 253);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(15);
            this.buttonX1.Size = new System.Drawing.Size(165, 35);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 14;
            this.buttonX1.Text = "确认修改";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click_1);
            // 
            // ForgetPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 300);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.accountTip);
            this.Controls.Add(this.oldTip);
            this.Controls.Add(this.newTip);
            this.Controls.Add(this.updateTip);
            this.Controls.Add(this.ConfirmPwd);
            this.Controls.Add(this.NewPwd);
            this.Controls.Add(this.OldPwd);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.NewPwdLogo);
            this.Controls.Add(this.OldPwdLogo);
            this.Controls.Add(this.AccountLogo);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ForgetPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPwd";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX exit;
        private DevComponents.DotNetBar.LabelX AccountLogo;
        private DevComponents.DotNetBar.LabelX OldPwdLogo;
        private DevComponents.DotNetBar.LabelX NewPwdLogo;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX Account;
        private DevComponents.DotNetBar.Controls.TextBoxX OldPwd;
        private DevComponents.DotNetBar.Controls.TextBoxX NewPwd;
        private DevComponents.DotNetBar.Controls.TextBoxX ConfirmPwd;
        private DevComponents.DotNetBar.LabelX updateTip;
        private DevComponents.DotNetBar.LabelX newTip;
        private DevComponents.DotNetBar.LabelX oldTip;
        private DevComponents.DotNetBar.LabelX accountTip;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}