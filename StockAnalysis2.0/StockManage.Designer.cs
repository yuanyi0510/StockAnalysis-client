namespace StockAnalysis2._0
{
    partial class StockManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.market = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epshare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napshare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yyg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npyyg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Search = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.SecondLabel = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.FirstLabel = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.radialMenu1 = new DevComponents.DotNetBar.RadialMenu();
            this.Sexit = new DevComponents.DotNetBar.RadialMenuItem();
            this.Smain = new DevComponents.DotNetBar.RadialMenuItem();
            this.Slabel = new DevComponents.DotNetBar.RadialMenuItem();
            this.Smarket = new DevComponents.DotNetBar.RadialMenuItem();
            this.Stock = new DevComponents.DotNetBar.RadialMenuItem();
            this.Saccount = new DevComponents.DotNetBar.RadialMenuItem();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.userNameL = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dataGridViewX1);
            this.panelEx1.Controls.Add(this.panel1);
            this.panelEx1.Controls.Add(this.radialMenu1);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.userNameL);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(888, 445);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 12;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToResizeColumns = false;
            this.dataGridViewX1.AllowUserToResizeRows = false;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.name,
            this.market,
            this.Sdate,
            this.price,
            this.pe,
            this.PB,
            this.epshare,
            this.napshare,
            this.income,
            this.yyg,
            this.profit,
            this.npyyg,
            this.remarks});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 86);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowTemplate.Height = 23;
            this.dataGridViewX1.Size = new System.Drawing.Size(888, 359);
            this.dataGridViewX1.TabIndex = 9;
            this.dataGridViewX1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewX1_RowHeaderMouseDoubleClick);
            // 
            // code
            // 
            this.code.HeaderText = "代码";
            this.code.Name = "code";
            // 
            // name
            // 
            this.name.HeaderText = "名称";
            this.name.Name = "name";
            // 
            // market
            // 
            this.market.HeaderText = "市场";
            this.market.Name = "market";
            // 
            // Sdate
            // 
            this.Sdate.HeaderText = "上市日期";
            this.Sdate.Name = "Sdate";
            // 
            // price
            // 
            this.price.HeaderText = "上市价格";
            this.price.Name = "price";
            // 
            // pe
            // 
            this.pe.HeaderText = "市盈率";
            this.pe.Name = "pe";
            // 
            // PB
            // 
            this.PB.HeaderText = "市净率";
            this.PB.Name = "PB";
            // 
            // epshare
            // 
            this.epshare.HeaderText = "每股收益";
            this.epshare.Name = "epshare";
            // 
            // napshare
            // 
            this.napshare.HeaderText = "每股净资产";
            this.napshare.Name = "napshare";
            // 
            // income
            // 
            this.income.HeaderText = "营业收入";
            this.income.Name = "income";
            // 
            // yyg
            // 
            this.yyg.HeaderText = "同比增长";
            this.yyg.Name = "yyg";
            // 
            // profit
            // 
            this.profit.HeaderText = "净利润";
            this.profit.Name = "profit";
            // 
            // npyyg
            // 
            this.npyyg.HeaderText = "利润同比增长";
            this.npyyg.Name = "npyyg";
            // 
            // remarks
            // 
            this.remarks.HeaderText = "备注";
            this.remarks.Name = "remarks";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.labelX6);
            this.panel1.Controls.Add(this.labelX5);
            this.panel1.Controls.Add(this.labelX4);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.textBoxX1);
            this.panel1.Controls.Add(this.comboBoxEx1);
            this.panel1.Controls.Add(this.SecondLabel);
            this.panel1.Controls.Add(this.FirstLabel);
            this.panel1.Location = new System.Drawing.Point(3, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 38);
            this.panel1.TabIndex = 8;
            // 
            // Search
            // 
            // 
            // 
            // 
            this.Search.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Search.Image = global::StockAnalysis2._0.Properties.Resources.serarch;
            this.Search.Location = new System.Drawing.Point(818, 7);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(39, 23);
            this.Search.TabIndex = 8;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(628, 7);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(43, 23);
            this.labelX6.TabIndex = 7;
            this.labelX6.Text = "股票：";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(407, 7);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(68, 23);
            this.labelX5.TabIndex = 6;
            this.labelX5.Text = "二级标签：";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(193, 7);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(68, 23);
            this.labelX4.TabIndex = 5;
            this.labelX4.Text = "一级标签：";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(3, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(43, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "市场：";
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(677, 7);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(100, 21);
            this.textBoxX1.TabIndex = 3;
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 15;
            this.comboBoxEx1.Location = new System.Drawing.Point(52, 7);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(119, 21);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 2;
            // 
            // SecondLabel
            // 
            this.SecondLabel.DisplayMember = "Text";
            this.SecondLabel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SecondLabel.FormattingEnabled = true;
            this.SecondLabel.ItemHeight = 15;
            this.SecondLabel.Location = new System.Drawing.Point(481, 7);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(119, 21);
            this.SecondLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SecondLabel.TabIndex = 1;
            // 
            // FirstLabel
            // 
            this.FirstLabel.DisplayMember = "Text";
            this.FirstLabel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FirstLabel.FormattingEnabled = true;
            this.FirstLabel.ItemHeight = 15;
            this.FirstLabel.Location = new System.Drawing.Point(267, 7);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Size = new System.Drawing.Size(119, 21);
            this.FirstLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.FirstLabel.TabIndex = 0;
            // 
            // radialMenu1
            // 
            // 
            // 
            // 
            this.radialMenu1.Colors.RadialMenuItemDisabledForeground = System.Drawing.Color.Empty;
            this.radialMenu1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.Sexit,
            this.Smain,
            this.Slabel,
            this.Smarket,
            this.Stock,
            this.Saccount});
            this.radialMenu1.Location = new System.Drawing.Point(832, 8);
            this.radialMenu1.Name = "radialMenu1";
            this.radialMenu1.Size = new System.Drawing.Size(28, 28);
            this.radialMenu1.Symbol = "";
            this.radialMenu1.SymbolSize = 13F;
            this.radialMenu1.TabIndex = 3;
            this.radialMenu1.Text = "radialMenu1";
            // 
            // Sexit
            // 
            this.Sexit.Name = "Sexit";
            this.Sexit.Symbol = "";
            this.Sexit.Text = "退出";
            // 
            // Smain
            // 
            this.Smain.Name = "Smain";
            this.Smain.Symbol = "";
            this.Smain.Text = "主页";
            // 
            // Slabel
            // 
            this.Slabel.Name = "Slabel";
            this.Slabel.Symbol = "";
            this.Slabel.Text = "标签";
            // 
            // Smarket
            // 
            this.Smarket.Name = "Smarket";
            this.Smarket.Symbol = "";
            this.Smarket.Text = "市场";
            // 
            // Stock
            // 
            this.Stock.Name = "Stock";
            this.Stock.Symbol = "";
            this.Stock.Text = "股票";
            // 
            // Saccount
            // 
            this.Saccount.Name = "Saccount";
            this.Saccount.Symbol = "";
            this.Saccount.Text = "账户";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.FontBold = true;
            this.labelX3.Location = new System.Drawing.Point(811, 13);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(15, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "|";
            // 
            // userNameL
            // 
            // 
            // 
            // 
            this.userNameL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.userNameL.Location = new System.Drawing.Point(703, 13);
            this.userNameL.Name = "userNameL";
            this.userNameL.Size = new System.Drawing.Size(104, 23);
            this.userNameL.TabIndex = 1;
            this.userNameL.Text = "用户名";
            this.userNameL.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Image = global::StockAnalysis2._0.Properties.Resources.stock_logo1;
            this.labelX1.Location = new System.Drawing.Point(3, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(129, 43);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "股票管理";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // StockManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 445);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockManage";
            this.Load += new System.EventHandler(this.StockManage_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.RadialMenu radialMenu1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX userNameL;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.RadialMenuItem Sexit;
        private DevComponents.DotNetBar.RadialMenuItem Smain;
        private DevComponents.DotNetBar.RadialMenuItem Slabel;
        private DevComponents.DotNetBar.RadialMenuItem Smarket;
        private DevComponents.DotNetBar.RadialMenuItem Stock;
        private DevComponents.DotNetBar.RadialMenuItem Saccount;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX Search;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx SecondLabel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx FirstLabel;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn market;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn pe;
        private System.Windows.Forms.DataGridViewTextBoxColumn PB;
        private System.Windows.Forms.DataGridViewTextBoxColumn epshare;
        private System.Windows.Forms.DataGridViewTextBoxColumn napshare;
        private System.Windows.Forms.DataGridViewTextBoxColumn income;
        private System.Windows.Forms.DataGridViewTextBoxColumn yyg;
        private System.Windows.Forms.DataGridViewTextBoxColumn profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn npyyg;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
    }
}