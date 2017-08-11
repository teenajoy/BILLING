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

namespace BILLING.View.Login
{
    public partial class FrmCmpnyLogin : Form
    {
        CmpntLoginDAL objCLDAL = new CmpntLoginDAL();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        public static int CompnId = 0;
        public static int FYID = 0;
        public FrmCmpnyLogin()
        {
            InitializeComponent();
        }

        private void cmbCompany_DropDown(object sender, EventArgs e)
        {
            FillcmbCompany();
      
        }

        private void FillcmbCompany()
        {
            try
            {
                dt.Clear();
                dt = objCLDAL.FetchCompany();
                cmbCompany.DataSource = dt;
                cmbCompany.DisplayMember = "CompName";
                cmbCompany.ValueMember = "CompId";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    this.GetNextControl(ActiveControl, true).Focus();
                }
            }
        }

        private void cmbFinancialYear_DropDown(object sender, EventArgs e)
        {
            try
            {
                FllFinancialYear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FllFinancialYear()
        {
            try
            {
                if (cmbCompany.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    dt1.Clear();
                    dt1 = objCLDAL.FetchFinancialYear();
                    cmbFinancialYear.DataSource = dt1;
                    cmbFinancialYear.DisplayMember = "FyName";
                    cmbFinancialYear.ValueMember = "FyId";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmbFinancialYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    this.GetNextControl(ActiveControl, true).Focus();
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbCompany.Text == "")
            {
                MessageBox.Show("Select Any Company", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCompany.Focus();
            }
            else if (cmbFinancialYear.Text == "")
            {
                MessageBox.Show("Select Any Financial Year", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbFinancialYear.Focus();
            }
            else
            {
                this.Hide();
                CompnId =Convert.ToInt32(cmbCompany.SelectedValue);
                FYID = Convert.ToInt32(cmbFinancialYear.SelectedValue);
                FrmLogin objFrmLogin = new FrmLogin();
                objFrmLogin.ShowDialog();
                
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
