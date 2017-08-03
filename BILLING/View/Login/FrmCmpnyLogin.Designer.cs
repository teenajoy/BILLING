namespace BILLING.View.Login
{
    partial class FrmCmpnyLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCmpnyLogin));
            this.grpCompany = new System.Windows.Forms.GroupBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cmbFinancialYear = new System.Windows.Forms.ComboBox();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCompany
            // 
            this.grpCompany.BackColor = System.Drawing.Color.Transparent;
            this.grpCompany.Controls.Add(this.ButtonExit);
            this.grpCompany.Controls.Add(this.btnOk);
            this.grpCompany.Controls.Add(this.cmbFinancialYear);
            this.grpCompany.Controls.Add(this.cmbCompany);
            this.grpCompany.Controls.Add(this.label3);
            this.grpCompany.Controls.Add(this.label1);
            this.grpCompany.Location = new System.Drawing.Point(337, 153);
            this.grpCompany.Name = "grpCompany";
            this.grpCompany.Size = new System.Drawing.Size(477, 248);
            this.grpCompany.TabIndex = 2;
            this.grpCompany.TabStop = false;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
            this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExit.Location = new System.Drawing.Point(318, 134);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(80, 29);
            this.ButtonExit.TabIndex = 324;
            this.ButtonExit.Text = "&Exit";
            this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(199, 134);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 32);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cmbFinancialYear
            // 
            this.cmbFinancialYear.FormattingEnabled = true;
            this.cmbFinancialYear.Location = new System.Drawing.Point(244, 74);
            this.cmbFinancialYear.Name = "cmbFinancialYear";
            this.cmbFinancialYear.Size = new System.Drawing.Size(171, 22);
            this.cmbFinancialYear.TabIndex = 2;
            this.cmbFinancialYear.DropDown += new System.EventHandler(this.cmbFinancialYear_DropDown);
            this.cmbFinancialYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFinancialYear_KeyDown);
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(152, 39);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(263, 22);
            this.cmbCompany.TabIndex = 0;
            this.cmbCompany.DropDown += new System.EventHandler(this.cmbCompany_DropDown);
            this.cmbCompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCompany_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Financial Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Company";
            // 
            // FrmCmpnyLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = global::BILLING.Properties.Resources._0012;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 510);
            this.Controls.Add(this.grpCompany);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Name = "FrmCmpnyLogin";
            this.Text = "CompanyLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpCompany.ResumeLayout(false);
            this.grpCompany.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCompany;
        internal System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cmbFinancialYear;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}