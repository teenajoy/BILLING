namespace BILLING.View.Masters
{
    partial class FrmBillSeries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBillSeries));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Listcategory = new System.Windows.Forms.ListBox();
            this.Comboseries = new System.Windows.Forms.ComboBox();
            this.TextserialNo = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Textcategory = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.GroupAdd = new System.Windows.Forms.GroupBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.GroupAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Listcategory);
            this.GroupBox1.Controls.Add(this.Comboseries);
            this.GroupBox1.Controls.Add(this.TextserialNo);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Textcategory);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label20);
            this.GroupBox1.Controls.Add(this.Label19);
            this.GroupBox1.Location = new System.Drawing.Point(7, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(687, 403);
            this.GroupBox1.TabIndex = 235;
            this.GroupBox1.TabStop = false;
            // 
            // Listcategory
            // 
            this.Listcategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Listcategory.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listcategory.FormattingEnabled = true;
            this.Listcategory.ItemHeight = 14;
            this.Listcategory.Location = new System.Drawing.Point(307, 137);
            this.Listcategory.Name = "Listcategory";
            this.Listcategory.Size = new System.Drawing.Size(171, 228);
            this.Listcategory.TabIndex = 237;
            this.Listcategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Listcategory_KeyPress);
            this.Listcategory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Listcategory_MouseDoubleClick);
            // 
            // Comboseries
            // 
            this.Comboseries.BackColor = System.Drawing.Color.White;
            this.Comboseries.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comboseries.FormattingEnabled = true;
            this.Comboseries.Location = new System.Drawing.Point(307, 156);
            this.Comboseries.MaxLength = 10;
            this.Comboseries.Name = "Comboseries";
            this.Comboseries.Size = new System.Drawing.Size(171, 22);
            this.Comboseries.TabIndex = 3;
            // 
            // TextserialNo
            // 
            this.TextserialNo.BackColor = System.Drawing.Color.White;
            this.TextserialNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextserialNo.Location = new System.Drawing.Point(307, 191);
            this.TextserialNo.MaxLength = 12;
            this.TextserialNo.Name = "TextserialNo";
            this.TextserialNo.Size = new System.Drawing.Size(171, 22);
            this.TextserialNo.TabIndex = 5;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(193, 194);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(54, 14);
            this.Label5.TabIndex = 226;
            this.Label5.Text = "Serial No";
            // 
            // Textcategory
            // 
            this.Textcategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Textcategory.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textcategory.ForeColor = System.Drawing.Color.Black;
            this.Textcategory.Location = new System.Drawing.Point(307, 119);
            this.Textcategory.MaxLength = 10;
            this.Textcategory.Name = "Textcategory";
            this.Textcategory.ReadOnly = true;
            this.Textcategory.Size = new System.Drawing.Size(171, 22);
            this.Textcategory.TabIndex = 2;
            this.Textcategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Textcategory_MouseClick);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(193, 156);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(39, 14);
            this.Label2.TabIndex = 222;
            this.Label2.Text = "Series";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Label20.Location = new System.Drawing.Point(229, 16);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(249, 20);
            this.Label20.TabIndex = 218;
            this.Label20.Text = "VOUCHER CONFIGURATION";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(193, 119);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(56, 14);
            this.Label19.TabIndex = 213;
            this.Label19.Text = "Category";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCancel.Image")));
            this.ButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCancel.Location = new System.Drawing.Point(358, 9);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(80, 29);
            this.ButtonCancel.TabIndex = 181;
            this.ButtonCancel.Text = "&Cancel";
            this.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSave.Image")));
            this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSave.Location = new System.Drawing.Point(262, 9);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(80, 29);
            this.ButtonSave.TabIndex = 180;
            this.ButtonSave.Text = "&Save";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // GroupAdd
            // 
            this.GroupAdd.BackColor = System.Drawing.Color.Plum;
            this.GroupAdd.Controls.Add(this.ButtonCancel);
            this.GroupAdd.Controls.Add(this.ButtonExit);
            this.GroupAdd.Controls.Add(this.ButtonSave);
            this.GroupAdd.Controls.Add(this.ButtonDelete);
            this.GroupAdd.Controls.Add(this.ButtonAdd);
            this.GroupAdd.Controls.Add(this.ButtonEdit);
            this.GroupAdd.Controls.Add(this.ButtonSearch);
            this.GroupAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GroupAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GroupAdd.Location = new System.Drawing.Point(21, 438);
            this.GroupAdd.Name = "GroupAdd";
            this.GroupAdd.Size = new System.Drawing.Size(643, 45);
            this.GroupAdd.TabIndex = 236;
            this.GroupAdd.TabStop = false;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
            this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExit.Location = new System.Drawing.Point(453, 9);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(80, 29);
            this.ButtonExit.TabIndex = 8;
            this.ButtonExit.Text = "&Exit";
            this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.Image")));
            this.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDelete.Location = new System.Drawing.Point(358, 9);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(80, 29);
            this.ButtonDelete.TabIndex = 7;
            this.ButtonDelete.Text = "&Delete";
            this.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdd.Image")));
            this.ButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAdd.Location = new System.Drawing.Point(70, 9);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(80, 29);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "&Add";
            this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEdit.Image")));
            this.ButtonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonEdit.Location = new System.Drawing.Point(262, 9);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(80, 29);
            this.ButtonEdit.TabIndex = 5;
            this.ButtonEdit.Text = "&Edit";
            this.ButtonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSearch.Image")));
            this.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSearch.Location = new System.Drawing.Point(165, 9);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(80, 29);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "&Search";
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // FrmBillSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 531);
            this.Controls.Add(this.GroupAdd);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBillSeries";
            this.Text = "FrmBillSeries";
            this.Load += new System.EventHandler(this.FrmBillSeries_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupAdd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ListBox Listcategory;
        internal System.Windows.Forms.ComboBox Comboseries;
        internal System.Windows.Forms.TextBox TextserialNo;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox Textcategory;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Button ButtonCancel;
        internal System.Windows.Forms.Button ButtonSave;
        internal System.Windows.Forms.GroupBox GroupAdd;
        internal System.Windows.Forms.Button ButtonExit;
        internal System.Windows.Forms.Button ButtonDelete;
        internal System.Windows.Forms.Button ButtonAdd;
        internal System.Windows.Forms.Button ButtonEdit;
        internal System.Windows.Forms.Button ButtonSearch;
    }
}