namespace BILLING.View.Search
{
    partial class FrmCommonSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCommonSearch));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gdv_CommonSearch = new System.Windows.Forms.DataGridView();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextGRNAME = new System.Windows.Forms.TextBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_CommonSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gdv_CommonSearch);
            this.groupBox1.Controls.Add(this.TextBox1);
            this.groupBox1.Controls.Add(this.TextGRNAME);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 377);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LIST";
            // 
            // gdv_CommonSearch
            // 
            this.gdv_CommonSearch.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Blue;
            this.gdv_CommonSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gdv_CommonSearch.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gdv_CommonSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_CommonSearch.Location = new System.Drawing.Point(3, 50);
            this.gdv_CommonSearch.Name = "gdv_CommonSearch";
            this.gdv_CommonSearch.ReadOnly = true;
            this.gdv_CommonSearch.RowHeadersWidth = 25;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue;
            this.gdv_CommonSearch.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gdv_CommonSearch.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdv_CommonSearch.RowTemplate.Height = 18;
            this.gdv_CommonSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdv_CommonSearch.Size = new System.Drawing.Size(711, 322);
            this.gdv_CommonSearch.TabIndex = 7;
            this.gdv_CommonSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gdv_CommonSearch_KeyDown);
            this.gdv_CommonSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gdv_CommonSearch_MouseDoubleClick);
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.Blue;
            this.TextBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.ForeColor = System.Drawing.Color.White;
            this.TextBox1.Location = new System.Drawing.Point(3, 30);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(207, 23);
            this.TextBox1.TabIndex = 6;
            this.TextBox1.Text = "SEARCH HERE -";
            // 
            // TextGRNAME
            // 
            this.TextGRNAME.BackColor = System.Drawing.Color.LavenderBlush;
            this.TextGRNAME.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextGRNAME.ForeColor = System.Drawing.Color.Black;
            this.TextGRNAME.Location = new System.Drawing.Point(209, 30);
            this.TextGRNAME.Name = "TextGRNAME";
            this.TextGRNAME.Size = new System.Drawing.Size(505, 23);
            this.TextGRNAME.TabIndex = 5;
            this.TextGRNAME.TextChanged += new System.EventHandler(this.TextGRNAME_TextChanged);
            this.TextGRNAME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextGRNAME_KeyDown);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
            this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExit.Location = new System.Drawing.Point(331, 414);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(80, 29);
            this.ButtonExit.TabIndex = 12;
            this.ButtonExit.Text = "&Exit";
            this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // FrmCommonSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 476);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCommonSearch";
            this.Text = "FrmCommonSearch";
            this.Load += new System.EventHandler(this.FrmCommonSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_CommonSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.DataGridView gdv_CommonSearch;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.TextBox TextGRNAME;
        internal System.Windows.Forms.Button ButtonExit;
    }
}