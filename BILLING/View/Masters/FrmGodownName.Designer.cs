namespace BILLING.View.Masters
{
    partial class FrmGodownName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGodownName));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TextGodown = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.GroupAdd = new System.Windows.Forms.GroupBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.GroupAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.TextGodown);
            this.GroupBox1.Controls.Add(this.Label20);
            this.GroupBox1.Controls.Add(this.Label19);
            this.GroupBox1.Enabled = false;
            this.GroupBox1.Location = new System.Drawing.Point(43, 28);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(879, 372);
            this.GroupBox1.TabIndex = 235;
            this.GroupBox1.TabStop = false;
            // 
            // TextGodown
            // 
            this.TextGodown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextGodown.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextGodown.Location = new System.Drawing.Point(323, 191);
            this.TextGodown.Margin = new System.Windows.Forms.Padding(4);
            this.TextGodown.MaxLength = 30;
            this.TextGodown.Name = "TextGodown";
            this.TextGodown.Size = new System.Drawing.Size(309, 26);
            this.TextGodown.TabIndex = 1;
            this.TextGodown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextGodown_KeyDown);
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Label20.Location = new System.Drawing.Point(373, 20);
            this.Label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(209, 25);
            this.Label20.TabIndex = 218;
            this.Label20.Text = "GODOWN MASTER";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(201, 194);
            this.Label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(104, 18);
            this.Label19.TabIndex = 213;
            this.Label19.Text = "Godown Name";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCancel.Image")));
            this.ButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCancel.Location = new System.Drawing.Point(437, 12);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(107, 36);
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Text = "&Cancel";
            this.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click_1);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSave.Image")));
            this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSave.Location = new System.Drawing.Point(323, 12);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(107, 36);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "&Save";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click_1);
            // 
            // GroupAdd
            // 
            this.GroupAdd.BackColor = System.Drawing.Color.Plum;
            this.GroupAdd.Controls.Add(this.ButtonCancel);
            this.GroupAdd.Controls.Add(this.ButtonExit);
            this.GroupAdd.Controls.Add(this.ButtonDelete);
            this.GroupAdd.Controls.Add(this.ButtonSave);
            this.GroupAdd.Controls.Add(this.ButtonAdd);
            this.GroupAdd.Controls.Add(this.ButtonNext);
            this.GroupAdd.Controls.Add(this.ButtonPrevious);
            this.GroupAdd.Controls.Add(this.ButtonSearch);
            this.GroupAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GroupAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GroupAdd.Location = new System.Drawing.Point(43, 382);
            this.GroupAdd.Margin = new System.Windows.Forms.Padding(4);
            this.GroupAdd.Name = "GroupAdd";
            this.GroupAdd.Padding = new System.Windows.Forms.Padding(4);
            this.GroupAdd.Size = new System.Drawing.Size(879, 55);
            this.GroupAdd.TabIndex = 236;
            this.GroupAdd.TabStop = false;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
            this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExit.Location = new System.Drawing.Point(665, 12);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(107, 36);
            this.ButtonExit.TabIndex = 10;
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
            this.ButtonDelete.Location = new System.Drawing.Point(551, 12);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(107, 36);
            this.ButtonDelete.TabIndex = 9;
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
            this.ButtonAdd.Location = new System.Drawing.Point(97, 12);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(107, 36);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "&Add";
            this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNext.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNext.Image")));
            this.ButtonNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonNext.Location = new System.Drawing.Point(323, 12);
            this.ButtonNext.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(107, 36);
            this.ButtonNext.TabIndex = 7;
            this.ButtonNext.Text = "&Next";
            this.ButtonNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonPrevious
            // 
            this.ButtonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPrevious.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPrevious.Image")));
            this.ButtonPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPrevious.Location = new System.Drawing.Point(212, 12);
            this.ButtonPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.Size = new System.Drawing.Size(107, 36);
            this.ButtonPrevious.TabIndex = 6;
            this.ButtonPrevious.Text = "&Previous";
            this.ButtonPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonPrevious.UseVisualStyleBackColor = true;
            this.ButtonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSearch.Image")));
            this.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSearch.Location = new System.Drawing.Point(436, 12);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(107, 36);
            this.ButtonSearch.TabIndex = 8;
            this.ButtonSearch.Text = "&Search";
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // FrmGodownName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 494);
            this.Controls.Add(this.GroupAdd);
            this.Controls.Add(this.GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGodownName";
            this.Text = "FrmGodownName";
            this.Load += new System.EventHandler(this.FrmGodownName_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupAdd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox TextGodown;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Button ButtonCancel;
        internal System.Windows.Forms.Button ButtonSave;
        internal System.Windows.Forms.GroupBox GroupAdd;
        internal System.Windows.Forms.Button ButtonExit;
        internal System.Windows.Forms.Button ButtonDelete;
        internal System.Windows.Forms.Button ButtonAdd;
        internal System.Windows.Forms.Button ButtonNext;
        internal System.Windows.Forms.Button ButtonPrevious;
        internal System.Windows.Forms.Button ButtonSearch;
    }
}