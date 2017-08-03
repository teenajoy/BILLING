using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingDAL;
using BILLING.View.Search;

namespace BILLING.View.Utils
{
    public partial class FrmAdUser : Form
    {
        AdUserDAL objAUDAL = new AdUserDAL();
        CmpntLoginDAL objCLDAL = new CmpntLoginDAL();
        public static string FYear = "";
        public static string smode = "";
        public static string new1 = "";
        public static string new2 = "";
        public static int j = 0;
        string grpid = "";
        int check = 0;
        public FrmAdUser()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(10, 60);
        }

        private void FrmAdUser_Load(object sender, EventArgs e)
        {
            GroupSave.Hide();
            if (int.Parse(FrmCommonSearch.val) == 1)
            {
                if (FrmCommonSearch.smodevalue == "1")
                {
                    TextUserId.Enabled = false;
                    TextUserName.Enabled = false;
                    TextPwd.Enabled = false;
                    textBox1.Enabled = false;

                    grpid = FrmCommonSearch.SetValueForText1.ToString();
                    int j = 0;
                    j = FrmCommonSearch.SetValueForCount;
                    objAUDAL.userid = Convert.ToInt32(grpid);
                    DataTable dt5 = new DataTable();
                    dt5.Clear();
                    dt5 = objAUDAL.FetchUserMaster();
                    if (dt5.Rows.Count > 0)
                    {
                        TextUserName.Text = dt5.Rows[0]["UserName"].ToString();
                        TextUserId.Text = dt5.Rows[0]["UserType"].ToString();


                    }
                    else
                    {
                        MessageBox.Show("Couldnt find the selected Item..!!");
                    }
                }
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            check = 0;
            GroupAdd.Hide();
            GroupSave.Visible = true;
        }
        public void clear()
        {
            TextUserName.Text = "";
            TextUserId.Text = "";
            TextPwd.Text = "";
            textBox1.Text = "";
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (check == 0)
            {
                string pwd = "", cpwd = "";
                pwd = TextPwd.Text;
                cpwd = textBox1.Text;
                DataTable dt3 = new DataTable();
                objAUDAL.username = TextUserId.Text;
                dt3 = objAUDAL.FetchUserSearchMaster();
                if (dt3.Rows.Count == 0)
                {
                    if (pwd != cpwd)
                    {
                        MessageBox.Show("Password Not Matching");
                    }
                    else
                    {
                        objAUDAL.username = TextUserId.Text;
                        objAUDAL.Password = textBox1.Text;
                        DataTable dt = new DataTable();
                        dt = objAUDAL.InsertItem();
                        MessageBox.Show("Inserted Successfully.......");
                        clear();
                    }
                }
                else
                {
                    MessageBox.Show("Record Can't Save.Data already existing in database.......");
                }
                clear();
                GroupAdd.Visible = true;
                GroupAdd.BringToFront();
                GroupSave.Hide();
            }
        }

        private void TextUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextUserId.Focus();
            }
        }

        private void TextUserId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextPwd.Focus();
            }
        }

        private void TextPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Focus();
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            smode = "1";
            FrmCommonSearch frmcmsrch = new FrmCommonSearch();
            frmcmsrch.Show();
            this.Hide();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            DataTable dt6 = new DataTable();
            dt6.Clear();
            dt6 = objAUDAL.SearchUser();
            if (j < dt6.Rows.Count - 1)
            {
                j++;
                TextUserName.Text = dt6.Rows[j]["UserName"].ToString();
                TextUserId.Text = dt6.Rows[j]["UserType"].ToString();

            }
            else
            {
                MessageBox.Show("No Next Record..!!");
            }
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            DataTable dt7 = new DataTable();
            dt7.Clear();
            dt7 = objAUDAL.SearchUser();
            if (j < dt7.Rows.Count && j != 0)
            {
                j--;
                TextUserName.Text = dt7.Rows[j]["UserName"].ToString();
                TextUserId.Text = dt7.Rows[j]["UserType"].ToString();

            }
            else
            {
                MessageBox.Show("No Next Record..!!");
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            clear();
            this.Hide();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            clear();
            GroupSave.Hide();
            GroupAdd.Visible = true;
            GroupAdd.BringToFront();
        }
    }
}
