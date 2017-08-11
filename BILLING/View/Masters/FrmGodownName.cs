using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BillingDAL;
using BILLING.View.Search;
namespace BILLING.View.Masters
{
    public partial class FrmGodownName : Form
    {
        GodownNameDAL objGDDAL = new GodownNameDAL();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dt5 = new DataTable();
        DataTable dt6 = new DataTable();
        DataTable dt7 = new DataTable();
        int grpmain = 0;
        int i = 0;
        public static string smode = "";
        public static int j = 0;
        int index = 0;
        int last = 0;
        string grpid = "";
        int check = 1;
        public FrmGodownName()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(10, 60);
            loadbutton();
            TextGodown.Text = "";
        }
        public void loadbutton()
        {
            ButtonAdd.Visible = true;
            ButtonAdd.Enabled = true;
            ButtonPrevious.Visible = true;
            ButtonPrevious.Enabled = false;
            ButtonNext.Visible = true;
            ButtonNext.Enabled = false;
            ButtonSearch.Visible = true;
            ButtonSearch.Enabled = true;
            ButtonDelete.Visible = true;
            ButtonDelete.Enabled = true;
            ButtonExit.Visible = true;
            ButtonExit.Enabled = true;
            ButtonSave.Visible = false;
            ButtonSave.Visible = false;
            ButtonCancel.Visible = false;
            ButtonCancel.Visible = false;

        }
        public void loadbutton1()
        {
            ButtonAdd.Visible = false;
            ButtonPrevious.Visible = false;
            ButtonNext.Visible = false;
            ButtonSearch.Visible = false;
            ButtonDelete.Visible = false;
            ButtonExit.Visible = false;
            ButtonSave.Visible = true;
            ButtonSave.Enabled = true;
            ButtonCancel.Visible = true;
            ButtonCancel.Enabled = true;

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            GroupBox1.Enabled = true;
            TextGodown.Enabled = true;
            TextGodown.Text = "";
            loadbutton1();
        }

        private void ButtonSave_Click_1(object sender, EventArgs e)
        {

            if (TextGodown.Text != "")
            {
                objGDDAL.godownname = TextGodown.Text;
                DataTable dt6 = new DataTable();
                dt6 = objGDDAL.FetchGodownnamewisesearch();
                if (dt6.Rows.Count == 0)
                {
                    objGDDAL.godownname = TextGodown.Text;
                    objGDDAL.coid = Convert.ToInt32("1");
                    objGDDAL.brid = Convert.ToInt32("1");

                    dt4 = objGDDAL.InsertItem();

                    MessageBox.Show("Items Saved Successfully..!!");
                    TextGodown.Text = "";
                }
                else
                {
                    MessageBox.Show("Already Exist..!!");
                    TextGodown.Text = "";
                }
            }
            GroupBox1.Visible = true;
            TextGodown.Enabled = false;
            loadbutton();
        }

        private void ButtonCancel_Click_1(object sender, EventArgs e)
        {
            loadbutton();
            TextGodown.Text = "";
            TextGodown.Enabled = false;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            smode = "1";
            FrmCommonSearch frmcmsrch = new FrmCommonSearch();
            frmcmsrch.Show();
            this.Hide();
        }

        private void FrmGodownName_Load(object sender, EventArgs e)
        {
            TextGodown.Text = "";
            TextGodown.Enabled = false;
            if (int.Parse(FrmCommonSearch.val) == 1)
            {
                if (FrmCommonSearch.smodevalue == "1")
                {
                    TextGodown.Enabled = false;
                    GroupBox1.Enabled = true;
                    ButtonDelete.Enabled = true;
                    loadbutton();
                    ButtonNext.Enabled = true;
                    ButtonPrevious.Enabled = true;
                    //  loadvisiblebutton();
                    grpid = FrmCommonSearch.SetValueForText1.ToString();
                    int j = 0;
                    j = FrmCommonSearch.SetValueForCount;
                    objGDDAL.godownname = grpid;
                    dt5.Clear();
                    dt5 = objGDDAL.FetchGodownMaster();
                    if (dt5.Rows.Count > 0)
                    {
                        TextGodown.Text = dt5.Rows[0]["Godown"].ToString();

                    }
                }
            }
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            dt7.Clear();
            dt7 = objGDDAL.SearchGodown();
          //  j = FrmCommonSearch.SetValueForCount;
            if (j < dt7.Rows.Count && j !=0 )
            {
                j--;
                TextGodown.Text = dt7.Rows[j]["Godown"].ToString();
            }
            else
            {
                MessageBox.Show("No Next Record..!!");
            }
              
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            dt6.Clear();
            dt6 = objGDDAL.SearchGodown();
          //  j = FrmCommonSearch.SetValueForCount;
            if (j < dt6.Rows.Count - 1)
            {
                j++;
                TextGodown.Text = dt6.Rows[j]["Godown"].ToString();
            }
            else
            {
                MessageBox.Show("No Next Record..!!");
            }
              
            }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            TextGodown.Text = "";
            smode = "0";
            this.Hide();
        }

        private void TextGodown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonSave.Focus();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            objGDDAL.godownname = TextGodown.Text;
            objGDDAL.coid = 1;
            
            DialogResult dr = MessageBox.Show("Are you sure to delete row?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                DataTable dt6 = new DataTable();
                dt6 = objGDDAL.DeleteGododown();
                MessageBox.Show("Record Deleted..!!");
                TextGodown.Text = "";
            }
            else if (dr == DialogResult.No)
            {
                TextGodown.Text = "";
            }
        }
           
        }
    }

