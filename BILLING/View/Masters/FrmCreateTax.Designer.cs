namespace BILLING.View.Masters
{
    partial class FrmCreateTax
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateTax));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ListUndergroup = new System.Windows.Forms.ListBox();
            this.Combocurrt = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Listcategory = new System.Windows.Forms.ListBox();
            this.RadioT = new System.Windows.Forms.RadioButton();
            this.RadioTC = new System.Windows.Forms.RadioButton();
            this.RadioNT = new System.Windows.Forms.RadioButton();
            this.Textundergroup = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Combotype = new System.Windows.Forms.TextBox();
            this.ComboTaxPer = new System.Windows.Forms.TextBox();
            this.Textcode = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Textcategory = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextAccountHead1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.GroupSave = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.GroupSave.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ListUndergroup);
            this.GroupBox1.Controls.Add(this.Combocurrt);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Listcategory);
            this.GroupBox1.Controls.Add(this.RadioT);
            this.GroupBox1.Controls.Add(this.RadioTC);
            this.GroupBox1.Controls.Add(this.RadioNT);
            this.GroupBox1.Controls.Add(this.Textundergroup);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Combotype);
            this.GroupBox1.Controls.Add(this.ComboTaxPer);
            this.GroupBox1.Controls.Add(this.Textcode);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Textcategory);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.TextAccountHead1);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label20);
            this.GroupBox1.Controls.Add(this.Label19);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(659, 463);
            this.GroupBox1.TabIndex = 235;
            this.GroupBox1.TabStop = false;
            // 
            // ListUndergroup
            // 
            this.ListUndergroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ListUndergroup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListUndergroup.FormattingEnabled = true;
            this.ListUndergroup.ItemHeight = 14;
            this.ListUndergroup.Items.AddRange(new object[] {
            "Purchase",
            "Purchase Return",
            "Sales",
            "Sales Return",
            "Stock Transfer"});
            this.ListUndergroup.Location = new System.Drawing.Point(256, 271);
            this.ListUndergroup.Name = "ListUndergroup";
            this.ListUndergroup.Size = new System.Drawing.Size(286, 172);
            this.ListUndergroup.TabIndex = 10;
            this.ListUndergroup.Visible = false;
            this.ListUndergroup.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListUndergroup_MouseDoubleClick);
            // 
            // Combocurrt
            // 
            this.Combocurrt.BackColor = System.Drawing.Color.White;
            this.Combocurrt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combocurrt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combocurrt.FormattingEnabled = true;
            this.Combocurrt.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.Combocurrt.Location = new System.Drawing.Point(256, 284);
            this.Combocurrt.Name = "Combocurrt";
            this.Combocurrt.Size = new System.Drawing.Size(94, 22);
            this.Combocurrt.TabIndex = 257;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(129, 284);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(124, 14);
            this.Label5.TabIndex = 256;
            this.Label5.Text = "Currently Using (Y/N)";
            // 
            // Listcategory
            // 
            this.Listcategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Listcategory.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listcategory.FormattingEnabled = true;
            this.Listcategory.ItemHeight = 14;
            this.Listcategory.Items.AddRange(new object[] {
            "Purchase",
            "Sales"});
            this.Listcategory.Location = new System.Drawing.Point(257, 117);
            this.Listcategory.Name = "Listcategory";
            this.Listcategory.Size = new System.Drawing.Size(287, 130);
            this.Listcategory.TabIndex = 2;
            this.Listcategory.Visible = false;
            this.Listcategory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Listcategory_MouseDoubleClick);
            // 
            // RadioT
            // 
            this.RadioT.AutoSize = true;
            this.RadioT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RadioT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioT.Location = new System.Drawing.Point(359, 132);
            this.RadioT.Name = "RadioT";
            this.RadioT.Size = new System.Drawing.Size(71, 18);
            this.RadioT.TabIndex = 4;
            this.RadioT.TabStop = true;
            this.RadioT.Text = "Taxable";
            this.RadioT.UseVisualStyleBackColor = false;
            this.RadioT.Click += new System.EventHandler(this.RadioT_Click);
            // 
            // RadioTC
            // 
            this.RadioTC.AutoSize = true;
            this.RadioTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RadioTC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioTC.Location = new System.Drawing.Point(433, 132);
            this.RadioTC.Name = "RadioTC";
            this.RadioTC.Size = new System.Drawing.Size(110, 18);
            this.RadioTC.TabIndex = 5;
            this.RadioTC.TabStop = true;
            this.RadioTC.Text = "Tax Collected ";
            this.RadioTC.UseVisualStyleBackColor = false;
            // 
            // RadioNT
            // 
            this.RadioNT.AutoSize = true;
            this.RadioNT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RadioNT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioNT.Location = new System.Drawing.Point(257, 132);
            this.RadioNT.Name = "RadioNT";
            this.RadioNT.Size = new System.Drawing.Size(99, 18);
            this.RadioNT.TabIndex = 3;
            this.RadioNT.TabStop = true;
            this.RadioNT.Text = "Non Taxable";
            this.RadioNT.UseVisualStyleBackColor = false;
            this.RadioNT.Click += new System.EventHandler(this.RadioNT_Click);
            // 
            // Textundergroup
            // 
            this.Textundergroup.BackColor = System.Drawing.Color.AliceBlue;
            this.Textundergroup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textundergroup.ForeColor = System.Drawing.Color.Black;
            this.Textundergroup.Location = new System.Drawing.Point(257, 247);
            this.Textundergroup.MaxLength = 15;
            this.Textundergroup.Name = "Textundergroup";
            this.Textundergroup.ReadOnly = true;
            this.Textundergroup.Size = new System.Drawing.Size(286, 22);
            this.Textundergroup.TabIndex = 9;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(129, 247);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(77, 14);
            this.Label8.TabIndex = 255;
            this.Label8.Text = "Group Under";
            // 
            // Combotype
            // 
            this.Combotype.BackColor = System.Drawing.Color.White;
            this.Combotype.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combotype.ForeColor = System.Drawing.Color.Black;
            this.Combotype.Location = new System.Drawing.Point(257, 159);
            this.Combotype.MaxLength = 10;
            this.Combotype.Name = "Combotype";
            this.Combotype.Size = new System.Drawing.Size(171, 22);
            this.Combotype.TabIndex = 6;
            this.Combotype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Combotype_KeyDown);
            // 
            // ComboTaxPer
            // 
            this.ComboTaxPer.BackColor = System.Drawing.Color.White;
            this.ComboTaxPer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTaxPer.ForeColor = System.Drawing.Color.Black;
            this.ComboTaxPer.Location = new System.Drawing.Point(257, 187);
            this.ComboTaxPer.MaxLength = 7;
            this.ComboTaxPer.Name = "ComboTaxPer";
            this.ComboTaxPer.Size = new System.Drawing.Size(80, 22);
            this.ComboTaxPer.TabIndex = 7;
            this.ComboTaxPer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboTaxPer_KeyDown);
            // 
            // Textcode
            // 
            this.Textcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Textcode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textcode.ForeColor = System.Drawing.Color.Black;
            this.Textcode.Location = new System.Drawing.Point(314, 76);
            this.Textcode.MaxLength = 10;
            this.Textcode.Name = "Textcode";
            this.Textcode.ReadOnly = true;
            this.Textcode.Size = new System.Drawing.Size(114, 22);
            this.Textcode.TabIndex = 0;
            this.Textcode.Visible = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(273, 76);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(35, 14);
            this.Label4.TabIndex = 246;
            this.Label4.Text = "Code";
            this.Label4.Visible = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(129, 158);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(35, 14);
            this.Label3.TabIndex = 242;
            this.Label3.Text = "Type";
            // 
            // Textcategory
            // 
            this.Textcategory.BackColor = System.Drawing.Color.AliceBlue;
            this.Textcategory.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textcategory.ForeColor = System.Drawing.Color.Black;
            this.Textcategory.Location = new System.Drawing.Point(257, 99);
            this.Textcategory.MaxLength = 15;
            this.Textcategory.Name = "Textcategory";
            this.Textcategory.ReadOnly = true;
            this.Textcategory.Size = new System.Drawing.Size(171, 22);
            this.Textcategory.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(129, 190);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(43, 14);
            this.Label2.TabIndex = 222;
            this.Label2.Text = "Tax %";
            // 
            // TextAccountHead1
            // 
            this.TextAccountHead1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TextAccountHead1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAccountHead1.ForeColor = System.Drawing.Color.Black;
            this.TextAccountHead1.Location = new System.Drawing.Point(257, 216);
            this.TextAccountHead1.MaxLength = 50;
            this.TextAccountHead1.Name = "TextAccountHead1";
            this.TextAccountHead1.ReadOnly = true;
            this.TextAccountHead1.Size = new System.Drawing.Size(286, 22);
            this.TextAccountHead1.TabIndex = 8;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(129, 216);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(85, 14);
            this.Label1.TabIndex = 220;
            this.Label1.Text = "Account Head";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Label20.Location = new System.Drawing.Point(253, 16);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(136, 20);
            this.Label20.TabIndex = 218;
            this.Label20.Text = "ADD  NEW TAX";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(129, 99);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(56, 14);
            this.Label19.TabIndex = 213;
            this.Label19.Text = "Category";
            // 
            // GroupSave
            // 
            this.GroupSave.BackColor = System.Drawing.Color.Plum;
            this.GroupSave.Controls.Add(this.button1);
            this.GroupSave.Controls.Add(this.button2);
            this.GroupSave.Location = new System.Drawing.Point(12, 481);
            this.GroupSave.Name = "GroupSave";
            this.GroupSave.Size = new System.Drawing.Size(658, 43);
            this.GroupSave.TabIndex = 258;
            this.GroupSave.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(315, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Cancel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(233, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "&Save";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Plum;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(18, 481);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 45);
            this.groupBox2.TabIndex = 259;
            this.groupBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(410, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 29);
            this.button3.TabIndex = 11;
            this.button3.Text = "&Edit";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(493, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 29);
            this.button4.TabIndex = 10;
            this.button4.Text = "&Exit";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(75, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 29);
            this.button5.TabIndex = 0;
            this.button5.Text = "&Add";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(243, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 29);
            this.button6.TabIndex = 7;
            this.button6.Text = "&Next";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(161, 10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 29);
            this.button7.TabIndex = 6;
            this.button7.Text = "&Previous";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(326, 10);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 29);
            this.button8.TabIndex = 8;
            this.button8.Text = "&Search";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // FrmCreateTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 549);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupSave);
            this.Name = "FrmCreateTax";
            this.Text = "FrmCreateTax";
            this.Load += new System.EventHandler(this.FrmCreateTax_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupSave.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ListBox ListUndergroup;
        internal System.Windows.Forms.ComboBox Combocurrt;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ListBox Listcategory;
        internal System.Windows.Forms.RadioButton RadioT;
        internal System.Windows.Forms.RadioButton RadioTC;
        internal System.Windows.Forms.RadioButton RadioNT;
        internal System.Windows.Forms.TextBox Textundergroup;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox Combotype;
        internal System.Windows.Forms.TextBox ComboTaxPer;
        internal System.Windows.Forms.TextBox Textcode;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox Textcategory;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextAccountHead1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.GroupBox GroupSave;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button button4;
        internal System.Windows.Forms.Button button5;
        internal System.Windows.Forms.Button button6;
        internal System.Windows.Forms.Button button7;
        internal System.Windows.Forms.Button button8;
    }
}