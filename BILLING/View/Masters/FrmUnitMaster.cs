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
    public partial class FrmUnitMaster : Form
    {
        UnitMasterDAL objUMDAL = new UnitMasterDAL();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        public FrmUnitMaster()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(10, 60);
            ClearFields();
            DisableTextBox();
            loadvisiblebutton();
            // Disablelistbox();
            btnAdd.Focus();
        }

       
        public static string umode = "";

        int unitid;

        private void FrmUnitMaster_Load(object sender, EventArgs e)
        {
            if (FrmUnitMasterSearch.umodevalue == "1")
            {
                DisableTextBox();
                GroupBox1.Enabled = true;
                groupBox2.Visible = true;
                GroupSave.Hide();
                loadvisiblebutton();
                unitid=int.Parse(FrmUnitMasterSearch.SetValueForText1);
                objUMDAL.UnitId = unitid;
                dt1.Clear();
                dt1 = objUMDAL.FetchUnitMaster();
                if (dt1.Rows.Count > 0)
                {
                    txtUnitName.Text = dt1.Rows[0]["Unit"].ToString();
                    txtSubUnit.Text = dt1.Rows[0]["SubUnit"].ToString();
                    txtConFactor.Text = dt1.Rows[0]["ConFactor"].ToString();
                }
            }
            else if (FrmUnitMasterSearch.umodevalue == "2")
            {
                EnableTextBox();
                GroupBox1.Enabled = true;
                groupBox2.Hide();
                GroupSave.Visible = true;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                unitid = int.Parse(FrmUnitMasterSearch.SetValueForText1);
                objUMDAL.UnitId = unitid;
                dt1.Clear();
                dt1 = objUMDAL.FetchUnitMaster();
                if (dt1.Rows.Count > 0)
                {
                    txtUnitName.Text = dt1.Rows[0]["Unit"].ToString();
                    txtSubUnit.Text = dt1.Rows[0]["SubUnit"].ToString();
                    txtConFactor.Text = dt1.Rows[0]["ConFactor"].ToString();
                }
            }
        }
    

        public void ClearFields()
        {
            txtUnitName.Text = "";
            txtSubUnit.Text = "";
            txtConFactor.Text = "";
        }
        public void DisableTextBox()
        {
            txtUnitName.Enabled = false;
            txtSubUnit.Enabled = false;
            txtConFactor.Enabled = false;
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
            
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnEdit.Enabled = true;
            // btnSerach.Enabled = true;
            btnDelete.Enabled = true;
            btnExit.Enabled = true;
            // userControl11.Enabled = true;
        }

        public void EnableTextBox()
        {
            txtUnitName.Enabled = true;
            txtSubUnit.Enabled = true;
            txtConFactor.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ClearFields();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EnableTextBox();
            GroupBox1.Enabled = true;
            groupBox2.Hide();
            GroupSave.Visible = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            ClearFields();
            txtUnitName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSubUnit.Text == "")
            {
                txtSubUnit.Text = txtUnitName.Text;
            }
            if (txtUnitName.Text != "" && txtSubUnit.Text != "" && txtConFactor.Text != "")
            {
                objUMDAL.Unit = txtUnitName.Text;
                objUMDAL.SubUnit = txtSubUnit.Text;
                objUMDAL.ConFactor = float.Parse(txtConFactor.Text);
                dt = objUMDAL.InsertUnit();

                MessageBox.Show("Unit Added Successfully...!!!");

                ClearFields();
                DisableTextBox();
                loadvisiblebutton();
                GroupBox1.Enabled = true;
                GroupSave.Hide();
                groupBox2.Visible = true;
                // Disablelistbox();
                btnAdd.Focus();
            }
            else
            {
                MessageBox.Show("Fill all Boxes...!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            DisableTextBox();
            loadvisiblebutton();
            // Disablelistbox();
            btnAdd.Focus();
            groupBox2.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            umode = "1";
            FrmUnitMasterSearch frmumsrch = new FrmUnitMasterSearch();
            frmumsrch.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            umode = "2";
            if (txtUnitName.Text == "")
            {
                FrmUnitMasterSearch frmumsrch = new FrmUnitMasterSearch();
                frmumsrch.Show();
                this.Hide();
            }
            else
            {
                EnableTextBox();
                GroupBox1.Enabled = true;
                groupBox2.Hide();
                GroupSave.Visible = true;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void txtUnitName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSubUnit.Focus();
            }
        }

        private void txtSubUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtConFactor.Focus();
            }
        }

        private void txtConFactor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }
    }
}
