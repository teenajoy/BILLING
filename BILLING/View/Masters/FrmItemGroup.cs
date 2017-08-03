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
    public partial class FrmItemGroup : Form
    {
        ItemGroupDAL objIGDAL = new ItemGroupDAL();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();

        public static string E_mode="";

        int grpid;

        public FrmItemGroup()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(10, 60);
            ClearFields();
            DisableTextBox();
            loadvisiblebutton();
            // Disablelistbox();
            btnAdd.Focus();
            FetchItemGroup();
            FetchList();
            label1.Visible = false;
            cmbGrpUnder.Visible = false;

        }

        public void FetchList()
        {
            List<string> MyList = new List<string>();
            MyList.Add("");
            MyList.Add("Y");
            MyList.Add("N");

            ListBox1.DataSource = MyList;
        }
      
        public void DisableTextBox()
        {
            txtGrpName.Enabled = false;
            cmbGrpUnder.Enabled = false;
            ListBox1.Enabled = false;
        }

        public void EnableTextBox()
        {
            txtGrpName.Enabled = true;
            cmbGrpUnder.Enabled = true;
            ListBox1.Enabled = true;
        }

        public void ClearFields()
        {
            txtGrpName.Text = "";

        }
        public void loadvisiblebutton()
        {
            GroupSave.Visible = false;
            btnAdd.Visible = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnEdit.Visible = true;
            //btnSerach.Visible = true;
            btnDelete.Visible = true;
            btnExit.Visible = true;
            //userControl11.Visible = true;
            cmbGrpUnder.Visible = false;
            label1.Visible = false;

            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnEdit.Enabled = true;
            // btnSerach.Enabled = true;
            btnDelete.Enabled = true;
            btnExit.Enabled = true;
            // userControl11.Enabled = true;
        }


        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (txtGrpName.Text == "")
            {
                MessageBox.Show("Group Name cant be blank..!", "Alert", MessageBoxButtons.OK);
            }
            else if (FrmItemGrpSearch.E_modevalue == "2" || FrmItemGrpSearch.E_modevalue=="1")
            {
                objIGDAL.ItmGpId = grpid;
                if (ListBox1.SelectedIndex == 2)
                {
                    objIGDAL.ItmGpName = txtGrpName.Text;
                    objIGDAL.ItmMGpId = int.Parse(cmbGrpUnder.SelectedValue.ToString());
                    objIGDAL.PrimaryGroup = "N";
                    dt1 = objIGDAL.UpdateItemGroup();
                }
                else if (ListBox1.SelectedIndex == 1)
                {
                    objIGDAL.ItmGpName = txtGrpName.Text;
                    objIGDAL.ItmMGpId = 0;
                    objIGDAL.PrimaryGroup = "Y";
                    dt1 = objIGDAL.UpdateItemGroup();
                }
                
                MessageBox.Show("Item Group Updated Succesfully.!");

            }
            else
            {

                if (ListBox1.SelectedIndex == 2)
                {
                    objIGDAL.ItmGpName = txtGrpName.Text;
                    objIGDAL.ItmMGpId = int.Parse(cmbGrpUnder.SelectedValue.ToString());
                    objIGDAL.PrimaryGroup = "N";
                    dt1 = objIGDAL.InsertItemGroup();
                }
                else if (ListBox1.SelectedIndex == 1)
                {
                    objIGDAL.ItmGpName = txtGrpName.Text;
                    objIGDAL.ItmMGpId = 0;
                    objIGDAL.PrimaryGroup = "Y";
                    dt1 = objIGDAL.InsertItemGroup();
                }

               
                MessageBox.Show("Item Group Added Succesfully.!");
            }
            ClearFields();
            DisableTextBox();
            groupBox2.Visible = true;
            loadvisiblebutton();
            // Disablelistbox();
            btnAdd.Focus();
            FetchList();
            //FetchItemGroup();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            DisableTextBox();
            loadvisiblebutton();
            // Disablelistbox();
            btnAdd.Focus();
            FetchItemGroup();
            groupBox2.Visible = true;
            FetchList();
            label1.Visible = false;
            cmbGrpUnder.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ClearFields();
            this.Hide();
        }

        private void FrmItemGroup_Load(object sender, EventArgs e)
        {
            if (int.Parse(FrmItemGrpSearch.count) != 1)
            {
                if (FrmItemGrpSearch.E_modevalue == "1")
                {
                    if (FrmItemGrpSearch.SetValueForText3 == "2")
                    {
                        label1.Visible = true;
                        cmbGrpUnder.Visible = true;
                        cmbGrpUnder.Enabled = false;
                        txtGrpName.Text = FrmItemGrpSearch.SetValueForText1;
                        cmbGrpUnder.SelectedValue = FrmItemGrpSearch.SetValueForText2;
                        ListBox1.Text = "N";
                    }
                    else if (FrmItemGrpSearch.SetValueForText3 == "1")
                    {
                        label1.Visible = false;
                        cmbGrpUnder.Visible = false;
                        txtGrpName.Text = FrmItemGrpSearch.SetValueForText1;
                        //cmbGrpUnder.SelectedValue = FrmItemGrpSearch.SetValueForText2;
                        ListBox1.Text = "Y";
                    }
                    grpid = int.Parse(FrmItemGrpSearch.grpId);
                }
                else if (FrmItemGrpSearch.E_modevalue == "2")
                {
                    if (FrmItemGrpSearch.SetValueForText3 == "2")
                    {
                        label1.Visible = true;
                        cmbGrpUnder.Visible = true;
                        cmbGrpUnder.Enabled = true;
                        txtGrpName.Enabled = true;
                        groupBox1.Enabled = true;
                        groupBox2.Visible = false;
                        GroupSave.Visible = true;
                        btnSave.Visible = true;
                        btnSave.Enabled = true;
                        btnCancel.Visible = true;
                        btnCancel.Enabled = true;
                        ListBox1.Enabled = true;
                        txtGrpName.Text = FrmItemGrpSearch.SetValueForText1;
                        cmbGrpUnder.SelectedValue = FrmItemGrpSearch.SetValueForText2;
                        ListBox1.Text = "N";
                    }
                    else if (FrmItemGrpSearch.SetValueForText3 == "1")
                    {
                        label1.Visible = false;
                        cmbGrpUnder.Visible = false;
                        txtGrpName.Enabled = true;
                        groupBox1.Enabled = true;
                        groupBox2.Visible = false;
                        GroupSave.Visible = true;
                        btnSave.Visible = true;
                        btnSave.Enabled = true;
                        btnCancel.Visible = true;
                        btnCancel.Enabled = true;
                        ListBox1.Enabled = true;
                        txtGrpName.Text = FrmItemGrpSearch.SetValueForText1;
                        //cmbGrpUnder.SelectedValue = FrmItemGrpSearch.SetValueForText2;
                        ListBox1.Text = "Y";
                    }
                    grpid = int.Parse(FrmItemGrpSearch.grpId);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FetchList();
            EnableTextBox();
            groupBox1.Enabled = true;
            groupBox2.Hide();
            GroupSave.Visible = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            ClearFields();
            label1.Visible = false;
            cmbGrpUnder.Visible = false;
            txtGrpName.Focus();
        }

       
        public void FetchItemGroup()
        {
            dt.Clear();
            dt = objIGDAL.FetchItemGroup();
            cmbGrpUnder.DataSource = dt;
            cmbGrpUnder.DisplayMember = "ItmGpName";
            cmbGrpUnder.ValueMember = "ItmGpId";
          //  cmbGrpUnder.Items.Insert(0, new ListItem("Primary Group", "0"));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            E_mode = "1";
            FrmItemGrpSearch frmgpsrch = new FrmItemGrpSearch();
            frmgpsrch.Show();
            this.Hide();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            E_mode = "2";
            if (txtGrpName.Text == "")
            {
                FrmItemGrpSearch frmgpsrch = new FrmItemGrpSearch();
                frmgpsrch.Show();
                this.Hide();
            }
            else
            {
                if (ListBox1.SelectedIndex == 2)
                {
                    EnableTextBox();
                    groupBox1.Enabled = true;
                    groupBox2.Hide();
                    GroupSave.Visible = true;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    label1.Visible = true;
                    cmbGrpUnder.Visible = true;
                    cmbGrpUnder.Enabled = true;

                }
                else
                {
                    label1.Visible = false;
                    cmbGrpUnder.Visible = false;
                    cmbGrpUnder.Enabled = false;
                    EnableTextBox();
                    groupBox1.Enabled = true;
                    groupBox2.Hide();
                    GroupSave.Visible = true;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    
                }

            }
        }


        private void ListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (FrmItemGrpSearch.E_modevalue == "1" && E_mode == "1")
            {
                if (FrmItemGrpSearch.SetValueForText3 == "2")
                {
                    label1.Visible = true;
                    cmbGrpUnder.Visible = true;
                    cmbGrpUnder.Enabled = false;
                }
                else if (FrmItemGrpSearch.SetValueForText3 == "1")
                {
                    label1.Visible = false;
                    cmbGrpUnder.Visible = false;
                }
            }
            else if (FrmItemGrpSearch.E_modevalue == "2" && E_mode == "2")
            {
                if (FrmItemGrpSearch.SetValueForText3 == "2")
                {

                    label1.Visible = false;
                    cmbGrpUnder.Visible = false;
                }
                else if (FrmItemGrpSearch.SetValueForText3 == "1")
                {
                    label1.Visible = true;
                    cmbGrpUnder.Visible = true;
                    cmbGrpUnder.Enabled = true;
                  
                }
                E_mode = "3";
            }
            else
            {
                if (ListBox1.SelectedIndex == 2)
                {
                    label1.Visible = true;
                    cmbGrpUnder.Visible = true;
                    cmbGrpUnder.Enabled = true;
                    FetchItemGroup();
                }
                else if (ListBox1.SelectedIndex == 1)
                {
                    label1.Visible = false;
                    cmbGrpUnder.Visible = false;
                    cmbGrpUnder.Enabled = false;
                }
            }
        }

        
    }
}
