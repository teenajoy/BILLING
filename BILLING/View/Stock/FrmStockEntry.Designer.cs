namespace BILLING.View.Stock
{
    partial class FrmStockEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockEntry));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextGRNAME = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.dgdItemEdit = new System.Windows.Forms.DataGridView();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdItemEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.TextGRNAME);
            this.GroupBox1.Controls.Add(this.TextBox1);
            this.GroupBox1.Controls.Add(this.lblRecordCount);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(1038, 88);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 10;
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Label1.Location = new System.Drawing.Point(3, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(112, 31);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Stock Entry";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextGRNAME
            // 
            this.TextGRNAME.BackColor = System.Drawing.Color.LavenderBlush;
            this.TextGRNAME.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextGRNAME.ForeColor = System.Drawing.Color.Black;
            this.TextGRNAME.Location = new System.Drawing.Point(204, 65);
            this.TextGRNAME.Name = "TextGRNAME";
            this.TextGRNAME.Size = new System.Drawing.Size(834, 23);
            this.TextGRNAME.TabIndex = 8;
            this.TextGRNAME.TextChanged += new System.EventHandler(this.TextGRNAME_TextChanged);
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.Blue;
            this.TextBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.ForeColor = System.Drawing.Color.White;
            this.TextBox1.Location = new System.Drawing.Point(0, 65);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(207, 23);
            this.TextBox1.TabIndex = 7;
            this.TextBox1.Text = "ITEM NAME";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(3, 18);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(0, 22);
            this.lblRecordCount.TabIndex = 1;
            this.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.groupBox2);
            this.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBox3.Location = new System.Drawing.Point(0, 560);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(1038, 55);
            this.GroupBox3.TabIndex = 2;
            this.GroupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Plum;
            this.groupBox2.Controls.Add(this.ButtonExit);
            this.groupBox2.Controls.Add(this.ButtonSave);
            this.groupBox2.Location = new System.Drawing.Point(0, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1038, 37);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
            this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExit.Location = new System.Drawing.Point(649, 2);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(80, 29);
            this.ButtonExit.TabIndex = 182;
            this.ButtonExit.Text = "&Exit";
            this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSave.Image")));
            this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSave.Location = new System.Drawing.Point(549, 2);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(80, 29);
            this.ButtonSave.TabIndex = 181;
            this.ButtonSave.Text = "&Save";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // dgdItemEdit
            // 
            this.dgdItemEdit.AllowUserToAddRows = false;
            this.dgdItemEdit.AllowUserToDeleteRows = false;
            this.dgdItemEdit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdItemEdit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgdItemEdit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgdItemEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdItemEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgdItemEdit.Location = new System.Drawing.Point(0, 88);
            this.dgdItemEdit.Name = "dgdItemEdit";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Blue;
            this.dgdItemEdit.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgdItemEdit.Size = new System.Drawing.Size(1038, 472);
            this.dgdItemEdit.TabIndex = 3;
            // 
            // FrmStockEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 615);
            this.Controls.Add(this.dgdItemEdit);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Name = "FrmStockEntry";
            this.Text = "FrmStockEntry";
            this.Load += new System.EventHandler(this.FrmStockEntry_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdItemEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblRecordCount;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button ButtonExit;
        internal System.Windows.Forms.Button ButtonSave;
        internal System.Windows.Forms.DataGridView dgdItemEdit;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.TextBox TextGRNAME;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label2;
    }
}