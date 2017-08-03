namespace BILLING.View.Utils
{
    partial class FrmAdUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdUser));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TextUserId = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextPwd = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextUserName = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.GroupAdd = new System.Windows.Forms.GroupBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.GroupSave = new System.Windows.Forms.GroupBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GroupBox1.SuspendLayout();
            this.GroupAdd.SuspendLayout();
            this.GroupSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.textBox1);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.TextUserId);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.TextPwd);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.TextUserName);
            this.GroupBox1.Controls.Add(this.Label20);
            this.GroupBox1.Controls.Add(this.Label19);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(659, 302);
            this.GroupBox1.TabIndex = 232;
            this.GroupBox1.TabStop = false;
            // 
            // TextUserId
            // 
            this.TextUserId.BackColor = System.Drawing.Color.White;
            this.TextUserId.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUserId.ForeColor = System.Drawing.Color.Black;
            this.TextUserId.Location = new System.Drawing.Point(307, 161);
            this.TextUserId.MaxLength = 20;
            this.TextUserId.Name = "TextUserId";
            this.TextUserId.Size = new System.Drawing.Size(186, 22);
            this.TextUserId.TabIndex = 2;
            this.TextUserId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextUserId_KeyDown);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(193, 164);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(47, 14);
            this.Label2.TabIndex = 222;
            this.Label2.Text = "User ID";
            // 
            // TextPwd
            // 
            this.TextPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TextPwd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPwd.ForeColor = System.Drawing.Color.Black;
            this.TextPwd.Location = new System.Drawing.Point(307, 199);
            this.TextPwd.MaxLength = 6;
            this.TextPwd.Name = "TextPwd";
            this.TextPwd.PasswordChar = '*';
            this.TextPwd.Size = new System.Drawing.Size(123, 22);
            this.TextPwd.TabIndex = 3;
            this.TextPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextPwd_KeyDown);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(193, 199);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 14);
            this.Label1.TabIndex = 220;
            this.Label1.Text = "Password";
            // 
            // TextUserName
            // 
            this.TextUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextUserName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUserName.Location = new System.Drawing.Point(307, 124);
            this.TextUserName.MaxLength = 50;
            this.TextUserName.Name = "TextUserName";
            this.TextUserName.Size = new System.Drawing.Size(186, 22);
            this.TextUserName.TabIndex = 1;
            this.TextUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextUserName_KeyDown);
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Label20.Location = new System.Drawing.Point(280, 16);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(102, 20);
            this.Label20.TabIndex = 218;
            this.Label20.Text = "ADD USER";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(193, 127);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(38, 14);
            this.Label19.TabIndex = 213;
            this.Label19.Text = "Name";
            // 
            // GroupAdd
            // 
            this.GroupAdd.BackColor = System.Drawing.Color.Plum;
            this.GroupAdd.Controls.Add(this.ButtonExit);
            this.GroupAdd.Controls.Add(this.ButtonAdd);
            this.GroupAdd.Controls.Add(this.ButtonDelete);
            this.GroupAdd.Controls.Add(this.ButtonNext);
            this.GroupAdd.Controls.Add(this.ButtonPrevious);
            this.GroupAdd.Controls.Add(this.ButtonSearch);
            this.GroupAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GroupAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GroupAdd.Location = new System.Drawing.Point(13, 348);
            this.GroupAdd.Name = "GroupAdd";
            this.GroupAdd.Size = new System.Drawing.Size(659, 45);
            this.GroupAdd.TabIndex = 233;
            this.GroupAdd.TabStop = false;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
            this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExit.Location = new System.Drawing.Point(439, 10);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(80, 29);
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
            this.ButtonDelete.Location = new System.Drawing.Point(99, 10);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(80, 29);
            this.ButtonDelete.TabIndex = 9;
            this.ButtonDelete.Text = "&Delete";
            this.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdd.Image")));
            this.ButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAdd.Location = new System.Drawing.Point(99, 10);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(80, 29);
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
            this.ButtonNext.Location = new System.Drawing.Point(267, 10);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(80, 29);
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
            this.ButtonPrevious.Location = new System.Drawing.Point(185, 10);
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.Size = new System.Drawing.Size(80, 29);
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
            this.ButtonSearch.Location = new System.Drawing.Point(353, 10);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(80, 29);
            this.ButtonSearch.TabIndex = 8;
            this.ButtonSearch.Text = "&Search";
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // GroupSave
            // 
            this.GroupSave.BackColor = System.Drawing.Color.Plum;
            this.GroupSave.Controls.Add(this.ButtonCancel);
            this.GroupSave.Controls.Add(this.ButtonSave);
            this.GroupSave.Location = new System.Drawing.Point(12, 350);
            this.GroupSave.Name = "GroupSave";
            this.GroupSave.Size = new System.Drawing.Size(658, 43);
            this.GroupSave.TabIndex = 234;
            this.GroupSave.TabStop = false;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCancel.Image")));
            this.ButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCancel.Location = new System.Drawing.Point(315, 9);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(80, 29);
            this.ButtonCancel.TabIndex = 5;
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
            this.ButtonSave.Location = new System.Drawing.Point(233, 9);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(80, 29);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "&Save";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 14);
            this.label3.TabIndex = 223;
            this.label3.Text = "ConfirmPassword";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(307, 237);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(123, 22);
            this.textBox1.TabIndex = 224;
            // 
            // FrmAdUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 421);
            this.Controls.Add(this.GroupSave);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupAdd);
            this.Name = "FrmAdUser";
            this.Text = "FrmAdUser";
            this.Load += new System.EventHandler(this.FrmAdUser_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupAdd.ResumeLayout(false);
            this.GroupSave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox TextUserId;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextPwd;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TextUserName;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.GroupBox GroupAdd;
        internal System.Windows.Forms.Button ButtonExit;
        internal System.Windows.Forms.Button ButtonDelete;
        internal System.Windows.Forms.Button ButtonAdd;
        internal System.Windows.Forms.Button ButtonNext;
        internal System.Windows.Forms.Button ButtonPrevious;
        internal System.Windows.Forms.Button ButtonSearch;
        internal System.Windows.Forms.GroupBox GroupSave;
        internal System.Windows.Forms.Button ButtonCancel;
        internal System.Windows.Forms.Button ButtonSave;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label label3;
    }
}