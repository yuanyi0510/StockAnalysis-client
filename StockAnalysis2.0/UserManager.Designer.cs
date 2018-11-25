namespace StockAnalysis2._0
{
    partial class UserManager
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
            this.listBoxAdv1 = new DevComponents.DotNetBar.ListBoxAdv();
            this.listBoxItem1 = new DevComponents.DotNetBar.ListBoxItem();
            this.SuspendLayout();
            // 
            // listBoxAdv1
            // 
            this.listBoxAdv1.AutoScroll = true;
            // 
            // 
            // 
            this.listBoxAdv1.BackgroundStyle.Class = "ListBoxAdv";
            this.listBoxAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listBoxAdv1.CheckStateMember = null;
            this.listBoxAdv1.ContainerControlProcessDialogKey = true;
            this.listBoxAdv1.DragDropSupport = true;
            this.listBoxAdv1.Items.Add(this.listBoxItem1);
            this.listBoxAdv1.Location = new System.Drawing.Point(84, 28);
            this.listBoxAdv1.Name = "listBoxAdv1";
            this.listBoxAdv1.Size = new System.Drawing.Size(200, 200);
            this.listBoxAdv1.TabIndex = 0;
            this.listBoxAdv1.Text = "listBoxAdv1";
            // 
            // listBoxItem1
            // 
            this.listBoxItem1.IsSelected = true;
            this.listBoxItem1.Name = "listBoxItem1";
            this.listBoxItem1.Text = "Item 1";
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxAdv1);
            this.Name = "UserManager";
            this.Text = "UserManager";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ListBoxAdv listBoxAdv1;
        private DevComponents.DotNetBar.ListBoxItem listBoxItem1;
    }
}