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
using BILLING.View.MDI;

namespace BILLING.View.Login
{
    public partial class FrmLogin : Form
    {
        LoginDAL objLDAL = new LoginDAL();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        public static string username = "";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strUserName = txtUserName.Text;
            string strPassword = txtPassword.Text;
            if (strUserName == "")
            {
                MessageBox.Show("Enter User Name!! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
            }
            else if (strPassword == "")
            {
                MessageBox.Show("Enter Password!! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else
            {
                objLDAL.UserName = strUserName;
                objLDAL.Password = strPassword;
                dt = objLDAL.ValidateLogin();
                if (dt.Rows.Count>0)
                {
                    username = strUserName;
                    this.Hide();
                    FrmMDI mdi = new FrmMDI();
                    mdi.Show();
                }
                else
                {
                    MessageBox.Show("Invalid UserName or Password !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Text = "";
                    txtUserName.Text = "";
                    txtUserName.Focus();
                }

            }
        }
        private void General_KeyDown(object sender, KeyEventArgs e)
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
     
    }
}
