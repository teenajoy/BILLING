﻿namespace BILLING.View.Search
{
    partial class FrmItemGrpSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItemGrpSearch));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gdv_ItemGrpSearch = new System.Windows.Forms.DataGridView();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextGRNAME = new System.Windows.Forms.TextBox();
            this.GroupSave = new System.Windows.Forms.GroupBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_ItemGrpSearch)).BeginInit();
            this.GroupSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gdv_ItemGrpSearch);
            this.groupBox1.Controls.Add(this.TextBox1);
            this.groupBox1.Controls.Add(this.TextGRNAME);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.groupBox1.Location = new System.Drawing.Point(10, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LIST-ITEM GROUP";
            // 
            // gdv_ItemGrpSearch
            // 
            this.gdv_ItemGrpSearch.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            this.gdv_ItemGrpSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdv_ItemGrpSearch.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gdv_ItemGrpSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_ItemGrpSearch.Location = new System.Drawing.Point(3, 50);
            this.gdv_ItemGrpSearch.Name = "gdv_ItemGrpSearch";
            this.gdv_ItemGrpSearch.RowHeadersWidth = 25;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            this.gdv_ItemGrpSearch.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gdv_ItemGrpSearch.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdv_ItemGrpSearch.RowTemplate.Height = 18;
            this.gdv_ItemGrpSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdv_ItemGrpSearch.Size = new System.Drawing.Size(711, 322);
            this.gdv_ItemGrpSearch.TabIndex = 7;
            this.gdv_ItemGrpSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gdv_ItemGrpSearch_KeyDown);
            this.gdv_ItemGrpSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gdv_ItemGrpSearch_MouseDoubleClick);
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
            // GroupSave
            // 
            this.GroupSave.BackColor = System.Drawing.SystemColors.Control;
            this.GroupSave.Controls.Add(this.ButtonExit);
            this.GroupSave.Location = new System.Drawing.Point(10, 380);
            this.GroupSave.Name = "GroupSave";
            this.GroupSave.Size = new System.Drawing.Size(718, 42);
            this.GroupSave.TabIndex = 227;
            this.GroupSave.TabStop = false;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
            this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExit.Location = new System.Drawing.Point(318, 11);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(80, 29);
            this.ButtonExit.TabIndex = 11;
            this.ButtonExit.Text = "&Exit";
            this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // FrmItemGrpSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 466);
            this.Controls.Add(this.GroupSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmItemGrpSearch";
            this.Text = "FrmItemGrpSearch";
            this.Load += new System.EventHandler(this.FrmItemGrpSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_ItemGrpSearch)).EndInit();
            this.GroupSave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.TextBox TextGRNAME;
        internal System.Windows.Forms.DataGridView gdv_ItemGrpSearch;
        internal System.Windows.Forms.GroupBox GroupSave;
        internal System.Windows.Forms.Button ButtonExit;
    }
}