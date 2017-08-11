namespace BILLING.View.Stock
{
    partial class FrmStockPreview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockPreview));
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.gdv_CommonSearch = new System.Windows.Forms.DataGridView();
            this.GroupAdd = new System.Windows.Forms.GroupBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_CommonSearch)).BeginInit();
            this.GroupAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Location = new System.Drawing.Point(12, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(1054, 552);
            this.GroupBox2.TabIndex = 248;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Stock Preview";
            // 
            // gdv_CommonSearch
            // 
            this.gdv_CommonSearch.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            this.gdv_CommonSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdv_CommonSearch.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gdv_CommonSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_CommonSearch.Location = new System.Drawing.Point(12, 59);
            this.gdv_CommonSearch.Name = "gdv_CommonSearch";
            this.gdv_CommonSearch.ReadOnly = true;
            this.gdv_CommonSearch.RowHeadersWidth = 25;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            this.gdv_CommonSearch.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gdv_CommonSearch.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdv_CommonSearch.RowTemplate.Height = 18;
            this.gdv_CommonSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdv_CommonSearch.Size = new System.Drawing.Size(1054, 488);
            this.gdv_CommonSearch.TabIndex = 8;
            // 
            // GroupAdd
            // 
            this.GroupAdd.BackColor = System.Drawing.Color.Plum;
            this.GroupAdd.Controls.Add(this.ButtonExit);
            this.GroupAdd.Controls.Add(this.ButtonAdd);
            this.GroupAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GroupAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GroupAdd.Location = new System.Drawing.Point(12, 564);
            this.GroupAdd.Name = "GroupAdd";
            this.GroupAdd.Size = new System.Drawing.Size(1054, 45);
            this.GroupAdd.TabIndex = 262;
            this.GroupAdd.TabStop = false;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
            this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExit.Location = new System.Drawing.Point(520, 10);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(80, 29);
            this.ButtonExit.TabIndex = 10;
            this.ButtonExit.Text = "&Exit";
            this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdd.Image")));
            this.ButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAdd.Location = new System.Drawing.Point(404, 10);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(80, 29);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "&Refresh";
            this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // FrmStockPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 621);
            this.Controls.Add(this.GroupAdd);
            this.Controls.Add(this.gdv_CommonSearch);
            this.Controls.Add(this.GroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStockPreview";
            this.Text = "FrmStockPreview";
            this.Load += new System.EventHandler(this.FrmStockPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_CommonSearch)).EndInit();
            this.GroupAdd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.DataGridView gdv_CommonSearch;
        internal System.Windows.Forms.GroupBox GroupAdd;
        internal System.Windows.Forms.Button ButtonExit;
        internal System.Windows.Forms.Button ButtonAdd;
    }
}