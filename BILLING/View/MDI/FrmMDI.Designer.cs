namespace BILLING.View.MDI
{
    partial class FrmMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createGodownNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeItemNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewAccountHeadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewAccountGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewTaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billSeriesNOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATABACKUPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mastersToolStripMenuItem,
            this.companyToolStripMenuItem,
            this.extrasToolStripMenuItem,
            this.utilsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mastersToolStripMenuItem
            // 
            this.mastersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventToolStripMenuItem,
            this.accountMasterToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
            this.mastersToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.mastersToolStripMenuItem.Text = "Masters";
            // 
            // inventToolStripMenuItem
            // 
            this.inventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMasterToolStripMenuItem,
            this.itemGroupToolStripMenuItem,
            this.unitMasterToolStripMenuItem,
            this.createGodownNameToolStripMenuItem,
            this.changeItemNameToolStripMenuItem});
            this.inventToolStripMenuItem.Name = "inventToolStripMenuItem";
            this.inventToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.inventToolStripMenuItem.Text = "Inventory Master";
            // 
            // itemMasterToolStripMenuItem
            // 
            this.itemMasterToolStripMenuItem.Name = "itemMasterToolStripMenuItem";
            this.itemMasterToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.itemMasterToolStripMenuItem.Text = "Item Master";
            this.itemMasterToolStripMenuItem.Click += new System.EventHandler(this.itemMasterToolStripMenuItem_Click);
            // 
            // itemGroupToolStripMenuItem
            // 
            this.itemGroupToolStripMenuItem.Name = "itemGroupToolStripMenuItem";
            this.itemGroupToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.itemGroupToolStripMenuItem.Text = "Item Group";
            this.itemGroupToolStripMenuItem.Click += new System.EventHandler(this.itemGroupToolStripMenuItem_Click);
            // 
            // unitMasterToolStripMenuItem
            // 
            this.unitMasterToolStripMenuItem.Name = "unitMasterToolStripMenuItem";
            this.unitMasterToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.unitMasterToolStripMenuItem.Text = "Unit Master";
            this.unitMasterToolStripMenuItem.Click += new System.EventHandler(this.unitMasterToolStripMenuItem_Click);
            // 
            // createGodownNameToolStripMenuItem
            // 
            this.createGodownNameToolStripMenuItem.Name = "createGodownNameToolStripMenuItem";
            this.createGodownNameToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.createGodownNameToolStripMenuItem.Text = "Create Godown Name";
            this.createGodownNameToolStripMenuItem.Click += new System.EventHandler(this.createGodownNameToolStripMenuItem_Click);
            // 
            // changeItemNameToolStripMenuItem
            // 
            this.changeItemNameToolStripMenuItem.Name = "changeItemNameToolStripMenuItem";
            this.changeItemNameToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.changeItemNameToolStripMenuItem.Text = "Change Item Name";
            this.changeItemNameToolStripMenuItem.Click += new System.EventHandler(this.changeItemNameToolStripMenuItem_Click);
            // 
            // accountMasterToolStripMenuItem
            // 
            this.accountMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.createNewAccountHeadToolStripMenuItem,
            this.createNewAccountGroupToolStripMenuItem,
            this.createNewTaxToolStripMenuItem});
            this.accountMasterToolStripMenuItem.Name = "accountMasterToolStripMenuItem";
            this.accountMasterToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.accountMasterToolStripMenuItem.Text = "Account Master";
            // 
            // createNewAccountHeadToolStripMenuItem
            // 
            this.createNewAccountHeadToolStripMenuItem.Name = "createNewAccountHeadToolStripMenuItem";
            this.createNewAccountHeadToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.createNewAccountHeadToolStripMenuItem.Text = "Create New Account Head";
            this.createNewAccountHeadToolStripMenuItem.Click += new System.EventHandler(this.createNewAccountHeadToolStripMenuItem_Click);
            // 
            // createNewAccountGroupToolStripMenuItem
            // 
            this.createNewAccountGroupToolStripMenuItem.Name = "createNewAccountGroupToolStripMenuItem";
            this.createNewAccountGroupToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.createNewAccountGroupToolStripMenuItem.Text = "Create New Account Group";
            this.createNewAccountGroupToolStripMenuItem.Click += new System.EventHandler(this.createNewAccountGroupToolStripMenuItem_Click);
            // 
            // createNewTaxToolStripMenuItem
            // 
            this.createNewTaxToolStripMenuItem.Name = "createNewTaxToolStripMenuItem";
            this.createNewTaxToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.createNewTaxToolStripMenuItem.Text = "Create New Tax";
            this.createNewTaxToolStripMenuItem.Click += new System.EventHandler(this.createNewTaxToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.employeeToolStripMenuItem.Text = "Employee Information";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billSeriesNOSToolStripMenuItem,
            this.dATABACKUPToolStripMenuItem});
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.companyToolStripMenuItem.Text = "Company";
            // 
            // billSeriesNOSToolStripMenuItem
            // 
            this.billSeriesNOSToolStripMenuItem.Name = "billSeriesNOSToolStripMenuItem";
            this.billSeriesNOSToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.billSeriesNOSToolStripMenuItem.Text = "Bill Series & NOS";
            this.billSeriesNOSToolStripMenuItem.Click += new System.EventHandler(this.billSeriesNOSToolStripMenuItem_Click);
            // 
            // dATABACKUPToolStripMenuItem
            // 
            this.dATABACKUPToolStripMenuItem.Name = "dATABACKUPToolStripMenuItem";
            this.dATABACKUPToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.dATABACKUPToolStripMenuItem.Text = "DATA BACKUP";
            this.dATABACKUPToolStripMenuItem.Click += new System.EventHandler(this.dATABACKUPToolStripMenuItem_Click);
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockEntryToolStripMenuItem});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.extrasToolStripMenuItem.Text = "Extras";
            // 
            // stockEntryToolStripMenuItem
            // 
            this.stockEntryToolStripMenuItem.Name = "stockEntryToolStripMenuItem";
            this.stockEntryToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.stockEntryToolStripMenuItem.Text = "Stock Entry";
            this.stockEntryToolStripMenuItem.Click += new System.EventHandler(this.stockEntryToolStripMenuItem_Click);
            // 
            // utilsToolStripMenuItem
            // 
            this.utilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.securityToolStripMenuItem});
            this.utilsToolStripMenuItem.Name = "utilsToolStripMenuItem";
            this.utilsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.utilsToolStripMenuItem.Text = "Utils";
            // 
            // securityToolStripMenuItem
            // 
            this.securityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem});
            this.securityToolStripMenuItem.Name = "securityToolStripMenuItem";
            this.securityToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.securityToolStripMenuItem.Text = "Security";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.toolStripMenuItem1.Text = "Account Heads-List";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BILLING.Properties.Resources.Flower_Mdi_Frm_Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 690);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMDI";
            this.Text = "Flower";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewAccountHeadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewAccountGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createGodownNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billSeriesNOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeItemNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATABACKUPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewTaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}