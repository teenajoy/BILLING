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
    public partial class FrmAccountMaster : Form
    {
        AccountMasterDAL objAMDAL = new AccountMasterDAL();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();

        public static string smode = "";
        int check = 1;
        int AmId;

        public FrmAccountMaster()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(10, 60);

            ClearFields();
            DisableTextBox();
            loadvisiblebutton();
            Disablelistbox();
            btnAdd.Focus();
        }

   
        private void FrmAccountMaster_Load(object sender, EventArgs e)
        {
            if (int.Parse(FrmCommonSearch.val) != 1)
            {
                if (FrmCommonSearch.smodeValue == "1")
                {
                    ClearFields();
                    DisableTextBox();

                    GroupBox1.Enabled = true;
                    GroupSave.Hide();
                    GroupAdd.Visible = true;

                    loadvisiblebutton();
                    AmId = int.Parse(FrmCommonSearch.SetValueForText1);
                    objAMDAL.AmId = AmId;
                    dt3 = objAMDAL.FetchAccountDetails();
                    if (dt3.Rows.Count > 0)
                    {
                        txtHEAD.Text = dt3.Rows[0]["Head"].ToString();
                        txtGroup.Text = dt3.Rows[0]["AgName"].ToString();
                        txtADDRS.Text = dt3.Rows[0]["Address1"].ToString();
                        txtADDRS1.Text = dt3.Rows[0]["Address2"].ToString();
                        txtADDRS2.Text = dt3.Rows[0]["Address3"].ToString();
                        txtAREACODE.Text = dt3.Rows[0]["District"].ToString();
                        txtCategory.Text = dt3.Rows[0]["Category"].ToString();
                        txtEMAIL.Text = dt3.Rows[0]["Email"].ToString();
                        txtPHNO.Text = dt3.Rows[0]["TelNo"].ToString();
                        txtMOBILE.Text = dt3.Rows[0]["Mobile"].ToString();
                        txtFAX.Text = dt3.Rows[0]["Fax"].ToString();
                        txtGSTIN.Text = dt3.Rows[0]["GSTinNo"].ToString();
                        txtStateCode.Text = dt3.Rows[0]["StateCode"].ToString();
                        txtserTaxno.Text = dt3.Rows[0]["ServiceTaxNo"].ToString();
                        txtPAN.Text = dt3.Rows[0]["PanNo"].ToString();
                        txtCRLIMIT.Text = dt3.Rows[0]["CreditLimit"].ToString();
                        txtCRDAYS.Text = dt3.Rows[0]["CreditDays"].ToString();
                        txtpriceGroup.Text = dt3.Rows[0]["PriceGroup"].ToString();
                        txtAGENTCODE.Text = dt3.Rows[0]["Agent"].ToString();
                        txtREMARKS.Text = dt3.Rows[0]["Remarks"].ToString();
                        foreach (DataColumn dc in dt3.Columns)
                        {
                            if (dc.ColumnName == "OPDRBal")
                            {
                                decimal OpCrBal = decimal.Parse(dt3.Rows[0]["OPCRBal"].ToString());
                                decimal OpDrBal = decimal.Parse(dt3.Rows[0]["OPDRBal"].ToString());
                                decimal CurCrBal = decimal.Parse(dt3.Rows[0]["CurCRBal"].ToString());
                                decimal CurDrBal = decimal.Parse(dt3.Rows[0]["CurDRBal"].ToString());
                                decimal CurBal = (OpCrBal + CurCrBal) - (OpDrBal + CurDrBal);
                                if (OpCrBal > 0)
                                {
                                    txtOPBAL.Text = OpCrBal.ToString();
                                    txtdrcr.Text = "CREDIT";
                                }
                                else if (OpDrBal > 0)
                                {
                                    txtOPBAL.Text = OpDrBal.ToString();
                                    txtdrcr.Text = "DEBIT";
                                }
                                if (CurBal > 0)
                                    txtCURBAL.Text = Math.Abs(CurBal).ToString() + " Cr";
                                else if (CurBal < 0)
                                    txtCURBAL.Text = Math.Abs(CurBal).ToString() + " Dr";
                            }
                        }
                    }
                }
                else if (FrmCommonSearch.smodeValue == "2")
                {
                    EnableTextBox();
                    GroupBox1.Enabled = true;
                    GroupAdd.Hide();
                    GroupSave.Visible = true;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;

                    AmId = int.Parse(FrmCommonSearch.SetValueForText1);
                    objAMDAL.AmId = AmId;
                    dt3 = objAMDAL.FetchAccountDetails();
                    if (dt3.Rows.Count > 0)
                    {
                        txtHEAD.Text = dt3.Rows[0]["Head"].ToString();
                        txtGroup.Text = dt3.Rows[0]["AgName"].ToString();
                        txtADDRS.Text = dt3.Rows[0]["Address1"].ToString();
                        txtADDRS1.Text = dt3.Rows[0]["Address2"].ToString();
                        txtADDRS2.Text = dt3.Rows[0]["Address3"].ToString();
                        txtAREACODE.Text = dt3.Rows[0]["District"].ToString();
                        txtCategory.Text = dt3.Rows[0]["Category"].ToString();
                        txtEMAIL.Text = dt3.Rows[0]["Email"].ToString();
                        txtPHNO.Text = dt3.Rows[0]["TelNo"].ToString();
                        txtMOBILE.Text = dt3.Rows[0]["Mobile"].ToString();
                        txtFAX.Text = dt3.Rows[0]["Fax"].ToString();
                        txtGSTIN.Text = dt3.Rows[0]["GSTinNo"].ToString();
                        txtStateCode.Text = dt3.Rows[0]["StateCode"].ToString();
                        txtserTaxno.Text = dt3.Rows[0]["ServiceTaxNo"].ToString();
                        txtPAN.Text = dt3.Rows[0]["PanNo"].ToString();
                        txtCRLIMIT.Text = dt3.Rows[0]["CreditLimit"].ToString();
                        txtCRDAYS.Text = dt3.Rows[0]["CreditDays"].ToString();
                        txtpriceGroup.Text = dt3.Rows[0]["PriceGroup"].ToString();
                        txtAGENTCODE.Text = dt3.Rows[0]["Agent"].ToString();
                        txtREMARKS.Text = dt3.Rows[0]["Remarks"].ToString();
                        foreach (DataColumn dc in dt3.Columns)
                        {
                            if (dc.ColumnName == "OPDRBal")
                            {
                                decimal OpCrBal = decimal.Parse(dt3.Rows[0]["OPCRBal"].ToString());
                                decimal OpDrBal = decimal.Parse(dt3.Rows[0]["OPDRBal"].ToString());
                                decimal CurCrBal = decimal.Parse(dt3.Rows[0]["CurCRBal"].ToString());
                                decimal CurDrBal = decimal.Parse(dt3.Rows[0]["CurDRBal"].ToString());
                                decimal CurBal = (OpCrBal + CurCrBal) - (OpDrBal + CurDrBal);
                                if (OpCrBal > 0)
                                {
                                    txtOPBAL.Text = OpCrBal.ToString();
                                    txtdrcr.Text = "CREDIT";
                                }
                                else if (OpDrBal > 0)
                                {
                                    txtOPBAL.Text = OpDrBal.ToString();
                                    txtdrcr.Text = "DEBIT";
                                }
                                if (CurBal > 0)
                                    txtCURBAL.Text = Math.Abs(CurBal).ToString() + " Cr";
                                else if (CurBal < 0)
                                    txtCURBAL.Text = Math.Abs(CurBal).ToString() + " Dr";
                            }
                        }
                    }
                }
                Disablelistbox();
            }
        }

        public void Disablelistbox()
        {
            ListGROUP.Visible = false;
            ListPriceGroup.Visible = false;
            ListCategory.Visible = false;
            ListBox1.Visible = false;
        }


        public void ClearFields()
        {
            txtHEAD.Text = "";
            //cmbunit.Text = "";
            txtCategory.Text = "";
            txtADDRS.Text = "";
            txtADDRS1.Text = "";
            txtADDRS2.Text = "";
            txtAREACODE.Text = "";
            txtEMAIL.Text = "";
            //cmbtax.Text = "";
            txtPHNO.Text = "";
            txtMOBILE.Text = "";
            txtFAX.Text = "";
            txtAGENTCODE.Text = "";
            txtREMARKS.Text = "";
            txtGroup.Text = "";
            txtGSTIN.Text = "";
            txtStateCode.Text = "";
            txtserTaxno.Text = "";
            txtPAN.Text = "";
            txtCRDAYS.Text = "";
            txtCRLIMIT.Text = "";
            txtpriceGroup.Text = "";
            txtOPBAL.Text = "";
            txtdrcr.Text = "";
            txtCURBAL.Text = "0";


        }

        public void DisableTextBox()
        {
            txtHEAD.Enabled = false;
            txtCategory.Enabled = false;
           
            txtADDRS.Enabled = false;
            txtADDRS1.Enabled = false;
            txtADDRS2.Enabled = false;
            txtAREACODE.Enabled = false;
            txtEMAIL.Enabled = false;
            txtPHNO.Enabled = false;
            txtMOBILE.Enabled = false;
            txtFAX.Enabled = false;
            txtAGENTCODE.Enabled = false;
            txtREMARKS.Enabled = false;
            txtGroup.Enabled = false;
            txtGSTIN.Enabled = false;
            txtStateCode.Enabled = false;
            txtserTaxno.Enabled = false;
            txtPAN.Enabled = false;
            txtCRDAYS.Enabled = false;
            txtCRLIMIT.Enabled = false;
            txtpriceGroup.Enabled = false;
            txtOPBAL.Enabled = false;
            txtdrcr.Enabled = false;
            txtCURBAL.Enabled = false;
        }
        public void EnableTextBox()
        {
            txtHEAD.Enabled = true;
            txtHEAD.BackColor = Color.White;
            txtCategory.Enabled = true;
            txtCategory.BackColor = Color.White;
            txtADDRS.Enabled = true;
            txtADDRS.BackColor = Color.White;
            txtADDRS1.Enabled = true;
            txtADDRS1.BackColor = Color.White;
            txtADDRS2.Enabled = true;
            txtADDRS2.BackColor = Color.White;
            txtAREACODE.Enabled = true;
            txtAREACODE.BackColor = Color.White;
            txtEMAIL.Enabled = true;
            txtEMAIL.BackColor = Color.White;
            txtPHNO.Enabled = true;
            txtPHNO.BackColor = Color.White;
            txtMOBILE.Enabled = true;
            txtMOBILE.BackColor = Color.White;
            txtFAX.Enabled = true;
            txtFAX.BackColor = Color.White;
            txtAGENTCODE.Enabled = true;
            txtAGENTCODE.BackColor = Color.White;
            txtREMARKS.Enabled = true;
            txtREMARKS.BackColor = Color.White;
            txtGroup.Enabled = true;
            txtGroup.BackColor = Color.White;
            txtGSTIN.Enabled = true;
            txtGSTIN.BackColor = Color.White;
            txtStateCode.Enabled = true;
            txtStateCode.BackColor = Color.White;
            txtserTaxno.Enabled = true;
            txtserTaxno.BackColor = Color.White;
            txtPAN.Enabled = true;
            txtPAN.BackColor = Color.White;
            txtCRDAYS.Enabled = true;
            txtCRDAYS.BackColor = Color.White;
            txtCRLIMIT.Enabled = true;
            txtCRLIMIT.BackColor = Color.White;
            txtpriceGroup.Enabled = true;
            txtpriceGroup.BackColor = Color.White;
            txtOPBAL.Enabled = true;
            txtOPBAL.BackColor = Color.White;
            txtdrcr.Enabled = true;
            txtdrcr.BackColor = Color.White;
            txtCURBAL.Enabled = true;
            txtCURBAL.BackColor = Color.White;

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
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnSearch.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnEdit.Enabled = true;
            // btnSerach.Enabled = true;
            btnDelete.Enabled = true;
            btnExit.Enabled = true;
            // userControl11.Enabled = true;
            GroupAdd.Visible = true;
            btnAdd.Visible = true;
            btnPrevious.Visible = true;
            btnNext.Visible = true;
            btnSearch.Visible = true;
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            btnExit.Visible = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtHEAD.Text != "" && txtGroup.Text != "" && txtCategory.Text != "" && txtdrcr.Text != "")
            {
                    if (txtOPBAL.Text == "")
                    {
                        txtOPBAL.Text = "0";
                    }
                    if (int.Parse(txtOPBAL.Text) < 0)
                    {
                        MessageBox.Show("Positive value only allowed");
                        int val = int.Parse(txtOPBAL.Text);
                        txtOPBAL.Text = ((val) * (-1)).ToString();
                        txtOPBAL.Focus();
                    }
                    if (check == 1)
                    {
                        objAMDAL.Head = txtHEAD.Text;
                        objAMDAL.AgId = int.Parse(ListGROUP.SelectedValue.ToString());
                        objAMDAL.Category = ListCategory.SelectedItem.ToString();
                        objAMDAL.Address1 = txtADDRS.Text;
                        objAMDAL.Address2 = txtADDRS1.Text;
                        objAMDAL.Address3 = txtADDRS2.Text;
                        objAMDAL.District = txtAREACODE.Text;
                        objAMDAL.State = "0";
                        objAMDAL.Email = txtEMAIL.Text;
                        objAMDAL.TelNo = txtPHNO.Text;
                        objAMDAL.Mobile = txtMOBILE.Text;
                        objAMDAL.Fax = txtFAX.Text;
                        objAMDAL.Agent = txtAGENTCODE.Text;
                        objAMDAL.Remarks = txtREMARKS.Text;
                        objAMDAL.GSTinNo = txtGSTIN.Text;
                        objAMDAL.PanNo = txtPAN.Text;

                        if (!string.IsNullOrEmpty(txtCRLIMIT.Text))
                            objAMDAL.CreditLimit = decimal.Parse(txtCRLIMIT.Text);
                        if (!string.IsNullOrEmpty(txtCRDAYS.Text))
                            objAMDAL.CreditDays = int.Parse(txtCRDAYS.Text);
                        objAMDAL.PriceGroup = txtpriceGroup.Text;

                        if (txtdrcr.Text == "CREDIT")
                        {
                            if (!string.IsNullOrEmpty(txtOPBAL.Text))
                                objAMDAL.OPCRBal = decimal.Parse(txtOPBAL.Text);
                            objAMDAL.OPDRBal = 0;
                        }
                        else if (txtdrcr.Text == "DEBIT")
                        {
                            objAMDAL.OPCRBal = 0;
                            if (!string.IsNullOrEmpty(txtOPBAL.Text))
                                objAMDAL.OPDRBal = decimal.Parse(txtOPBAL.Text);
                        }

                        objAMDAL.StateCode = txtStateCode.Text;
                        objAMDAL.ServiceTaxNo = txtserTaxno.Text;

                        objAMDAL.FyId = 1;
                        objAMDAL.BrId = 1;

                        objAMDAL.CompId = 1;

                        dt2 = objAMDAL.InsertAccount();
                        MessageBox.Show("Account Added Succesfully.!");
                    }
                    else if (check == 2)
                    {
                        objAMDAL.AmId = AmId;
                        objAMDAL.Head = txtHEAD.Text;
                        objAMDAL.AgId = int.Parse(ListGROUP.SelectedValue.ToString());
                        objAMDAL.Category = ListCategory.SelectedItem.ToString();
                        objAMDAL.Address1 = txtADDRS.Text;
                        objAMDAL.Address2 = txtADDRS1.Text;
                        objAMDAL.Address3 = txtADDRS2.Text;
                        objAMDAL.District = txtAREACODE.Text;
                        objAMDAL.State = "0";
                        objAMDAL.Email = txtEMAIL.Text;
                        objAMDAL.TelNo = txtPHNO.Text;
                        objAMDAL.Mobile = txtMOBILE.Text;
                        objAMDAL.Fax = txtFAX.Text;
                        objAMDAL.Agent = txtAGENTCODE.Text;
                        objAMDAL.Remarks = txtREMARKS.Text;
                        objAMDAL.GSTinNo = txtGSTIN.Text;
                        objAMDAL.PanNo = txtPAN.Text;

                        if (!string.IsNullOrEmpty(txtCRLIMIT.Text))
                            objAMDAL.CreditLimit = decimal.Parse(txtCRLIMIT.Text);
                        if (!string.IsNullOrEmpty(txtCRDAYS.Text))
                            objAMDAL.CreditDays = int.Parse(txtCRDAYS.Text);
                        objAMDAL.PriceGroup = txtpriceGroup.Text;

                        if (txtdrcr.Text == "CREDIT")
                        {
                            if (!string.IsNullOrEmpty(txtOPBAL.Text))
                                objAMDAL.OPCRBal = decimal.Parse(txtOPBAL.Text);
                            objAMDAL.OPDRBal = 0;
                        }
                        else if (txtdrcr.Text == "DEBIT")
                        {
                            objAMDAL.OPCRBal = 0;
                            if (!string.IsNullOrEmpty(txtOPBAL.Text))
                                objAMDAL.OPDRBal = decimal.Parse(txtOPBAL.Text);
                        }

                        objAMDAL.StateCode = txtStateCode.Text;
                        objAMDAL.ServiceTaxNo = txtserTaxno.Text;

                        objAMDAL.FyId = 1;
                        objAMDAL.BrId = 1;

                        objAMDAL.CompId = 1;

                        dt4 = objAMDAL.UpdateAccount();
                        MessageBox.Show("Account Updated Succesfully.!");
                    }

               ClearFields();
               DisableTextBox();
               loadvisiblebutton();
               Disablelistbox();
               btnAdd.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            DisableTextBox();
            loadvisiblebutton();
            Disablelistbox();
            GroupAdd.Visible = true;
            btnAdd.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            check = 1;
            FillListGroup();
            ClearFields();
            EnableTextBox();
            GroupBox1.Enabled = true;
            GroupAdd.Hide();
            GroupSave.Visible = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            Disablelistbox();
            txtHEAD.Focus();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            smode = "1";
            FrmCommonSearch frmcmsrch = new FrmCommonSearch();
            frmcmsrch.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            check = 2;
            smode = "2";
            if (txtHEAD.Text == "")
            {
                FrmCommonSearch frmcmsrch = new FrmCommonSearch();
                frmcmsrch.Show();
                this.Hide();
            }
            else
            {
                EnableTextBox();
                GroupBox1.Enabled = true;
                GroupAdd.Hide();
                GroupSave.Visible = true;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ClearFields();
            this.Hide();
        }

        private void txtHEAD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCategory.Focus();
            }
        }

        private void txtCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtADDRS.Focus();
            }
        }

        private void txtADDRS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtADDRS1.Focus();
            }
        }

        private void txtADDRS1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtADDRS2.Focus();
            }
        }

        private void txtADDRS2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAREACODE.Focus();
            }
        }

        private void txtAREACODE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEMAIL.Focus();
            }
        }

        private void txtEMAIL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPHNO.Focus();
            }
        }

        private void txtPHNO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMOBILE.Focus();
            }
        }

        private void txtMOBILE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFAX.Focus();
            }
        }

        private void txtFAX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAGENTCODE.Focus();
            }
        }

        private void txtAGENTCODE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtREMARKS.Focus();
            }
        }

        private void txtREMARKS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtGroup.Focus();
            }
        }

        private void txtGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtGSTIN.Focus();
            }
        }

        private void txtGSTIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtStateCode.Focus();
            }
        }

        private void txtStateCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtserTaxno.Focus();
            }
        }

        private void txtserTaxno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPAN.Focus();
            }
        }

        private void txtPAN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCRLIMIT.Focus();
            }
        }

        private void txtCRLIMIT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCRDAYS.Focus();
            }
        }

        private void txtCRDAYS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpriceGroup.Focus();
            }
        }

        private void txtpriceGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtOPBAL.Focus();
            }
        }

        private void txtOPBAL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtdrcr.Focus();
            }
        }

        private void txtdrcr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCURBAL.Focus();
            }
        }

        private void txtCURBAL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        public void FillListGroup()
        {
            dt.Clear();
            dt = objAMDAL.FetchListGroup();
            ListGROUP.DataSource = dt;
            ListGROUP.DisplayMember = "AgName";
            ListGROUP.ValueMember = "AgId";
        }

        private void txtGroup_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtGroup.Text == "")
            {
                txtGroup.ReadOnly = true;
                ListGROUP.Visible = true;
                ListGROUP.BringToFront();
                ListGROUP.Focus();
            }
        }

        private void txtGroup_TextChanged(object sender, EventArgs e)
        {
            ListGROUP.Visible = true;
            ListGROUP.BringToFront();
            objAMDAL.group = txtGroup.Text;
            dt1.Clear();
            dt1 = objAMDAL.FetchListGrouptxt();
            ListGROUP.DataSource = dt1;
            ListGROUP.DisplayMember = "AgName";
            ListGROUP.ValueMember = "AgId";
        }

        private void ListGROUP_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtGroup.Text = ListGROUP.Text;
            ListGROUP.Visible = false;
            txtGSTIN.Focus();
        }

        private void txtCategory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtCategory.Text == "")
            {
                txtCategory.ReadOnly = true;
                ListCategory.Visible = true;
                ListCategory.BringToFront();
                ListCategory.Focus();
            }
        }

        private void ListCategory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtCategory.Text = ListCategory.Text;
            ListCategory.Visible = false;
            if (txtCategory.Text == "ACCOUNTS" || txtCategory.Text == "CASH BOOK")
            {
                txtOPBAL.Focus();
            }
            else
            {
                txtADDRS.Focus();
            }
        }

        private void ListCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCategory.Text = ListCategory.Text;
                ListCategory.Visible = false;
                if (txtCategory.Text == "ACCOUNTS" || txtCategory.Text == "CASH BOOK")
                {
                    txtOPBAL.Focus();
                }
                else
                {
                    txtADDRS.Focus();
                }
            }
        }

        private void txtpriceGroup_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtpriceGroup.Text == "")
            {
                txtpriceGroup.ReadOnly = true;
                ListPriceGroup.Visible = true;
                ListPriceGroup.BringToFront();
                ListPriceGroup.Focus();
            }
        }

        private void ListPriceGroup_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtpriceGroup.Text = ListCategory.Text;
            ListPriceGroup.Visible = false;

            txtOPBAL.Focus();
        }

        private void ListPriceGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpriceGroup.Text = ListCategory.Text;
                ListPriceGroup.Visible = false;

                txtOPBAL.Focus();
            }
        }

        private void txtdrcr_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtdrcr.Text == "")
            {
                txtdrcr.ReadOnly = true;
                ListBox1.Visible = true;
                ListBox1.BringToFront();
                ListBox1.Focus();
            }
        }

        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtdrcr.Text = ListBox1.Text;
            ListBox1.Visible = false;

            txtCURBAL.Focus();
        }
        

       
    }
}
