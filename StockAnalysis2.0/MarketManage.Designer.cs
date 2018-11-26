namespace StockAnalysis2._0
{
    partial class MarketManage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "沪深",
            "234234",
            "修改",
            "删除"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "港股",
            "2342435346546"}, 0);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "美股",
            "23442"}, 0);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "4",
            "基金",
            "34324324"}, 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketManage));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.Add = new DevComponents.DotNetBar.ButtonX();
            this.listViewEx1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.del = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radialMenu1 = new DevComponents.DotNetBar.RadialMenu();
            this.Sexit = new DevComponents.DotNetBar.RadialMenuItem();
            this.Smain = new DevComponents.DotNetBar.RadialMenuItem();
            this.Slabel = new DevComponents.DotNetBar.RadialMenuItem();
            this.Smarket = new DevComponents.DotNetBar.RadialMenuItem();
            this.Stock = new DevComponents.DotNetBar.RadialMenuItem();
            this.Saccount = new DevComponents.DotNetBar.RadialMenuItem();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.usernameL = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.Add);
            this.panelEx1.Controls.Add(this.listViewEx1);
            this.panelEx1.Controls.Add(this.radialMenu1);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.usernameL);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(606, 374);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            // 
            // Add
            // 
            this.Add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Add.Location = new System.Drawing.Point(504, 332);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Add.TabIndex = 5;
            this.Add.Text = "添加";
            // 
            // listViewEx1
            // 
            // 
            // 
            // 
            this.listViewEx1.Border.Class = "ListViewBorder";
            this.listViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listViewEx1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.name,
            this.num,
            this.cal,
            this.del});
            this.listViewEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.listViewEx1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listViewEx1.Location = new System.Drawing.Point(61, 64);
            this.listViewEx1.Name = "listViewEx1";
            this.listViewEx1.Size = new System.Drawing.Size(465, 251);
            this.listViewEx1.SmallImageList = this.imageList1;
            this.listViewEx1.TabIndex = 4;
            this.listViewEx1.UseCompatibleStateImageBehavior = false;
            this.listViewEx1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 67;
            // 
            // name
            // 
            this.name.Text = "名称";
            this.name.Width = 98;
            // 
            // num
            // 
            this.num.Text = "交易数量";
            this.num.Width = 178;
            // 
            // cal
            // 
            this.cal.Text = "操作";
            this.cal.Width = 59;
            // 
            // del
            // 
            this.del.Text = "";
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
            this.radialMenu1.Location = new System.Drawing.Point(551, 8);
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
            this.Smarket.Symbol = "";
            this.Smarket.Text = "市场";
            // 
            // Stock
            // 
            this.Stock.Name = "Stock";
            this.Stock.Symbol = "";
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
            this.labelX3.Location = new System.Drawing.Point(530, 13);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(15, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "|";
            // 
            // usernameL
            // 
            // 
            // 
            // 
            this.usernameL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.usernameL.Location = new System.Drawing.Point(422, 13);
            this.usernameL.Name = "usernameL";
            this.usernameL.Size = new System.Drawing.Size(104, 23);
            this.usernameL.TabIndex = 1;
            this.usernameL.Text = "用户名";
            this.usernameL.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Image = global::StockAnalysis2._0.Properties.Resources.market;
            this.labelX1.Location = new System.Drawing.Point(3, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(129, 43);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "市场管理";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "marketlogo.png");
            // 
            // MarketManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 374);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MarketManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarketManage";
            this.Load += new System.EventHandler(this.MarketManage_Load);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.RadialMenu radialMenu1;
        private DevComponents.DotNetBar.RadialMenuItem Sexit;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX usernameL;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.RadialMenuItem Smain;
        private DevComponents.DotNetBar.RadialMenuItem Slabel;
        private DevComponents.DotNetBar.RadialMenuItem Smarket;
        private DevComponents.DotNetBar.RadialMenuItem Stock;
        private DevComponents.DotNetBar.RadialMenuItem Saccount;
        private DevComponents.DotNetBar.Controls.ListViewEx listViewEx1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader num;
        private DevComponents.DotNetBar.ButtonX Add;
        private System.Windows.Forms.ColumnHeader cal;
        private System.Windows.Forms.ColumnHeader del;
        private System.Windows.Forms.ImageList imageList1;
    }
}