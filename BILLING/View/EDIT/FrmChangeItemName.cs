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
namespace BILLING.View.EDIT
{
    public partial class FrmChangeItemName : Form
    {
        ItemMasterDAL objIMDAL = new ItemMasterDAL();
        public static string FYear = "";
        public static string smode = "";
        int grpid = 0;
        int check = 0;
        public FrmChangeItemName()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(10, 60);
        }
      
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            smode = "1";
            FrmItemMasterSearch frmmsrch = new FrmItemMasterSearch();
            frmmsrch.Show();
            this.Hide();
        }

        private void FrmChangeItemName_Load(object sender, EventArgs e)
        {
            if (int.Parse(FrmItemMasterSearch.val) != 1)
            {
                if (FrmItemMasterSearch.smodevalue == "1")
                {
                    GroupBox1.Enabled = true;

                    DataTable dt5 = new DataTable();
                    grpid = int.Parse(FrmItemMasterSearch.SetValueForText1);
                    objIMDAL.ItmId = grpid;
                    dt5.Clear();
                    dt5 = objIMDAL.FetchItemMaster();
                    if (dt5.Rows.Count > 0)
                    {
                        TextITEMNAME.Text = dt5.Rows[0]["ItemName"].ToString();
                        TextITEMCODE.Text = dt5.Rows[0]["ItmId"].ToString();
                       
                    }
                    else
                    {
                        MessageBox.Show("Couldnt find the selected Item..!!");
                    }
                    ButtonSearch.Visible = false;
                    ButtonSave.Visible = true;
                    ButtonCancel.Visible = true;
                    button1.Visible = false;
                  
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if ((TextITEMNAMENEW.Text == "") )
            {
                MessageBox.Show("Please Type New Name");
                return;
            }
            
                objIMDAL.ItemName = TextITEMNAME.Text;
                objIMDAL.newitwmname = TextITEMNAMENEW.Text;
                objIMDAL.ItmId = Convert.ToInt32(TextITEMCODE.Text);
                
                DataTable dt4 = new DataTable();
                dt4 = objIMDAL.InsertItem1();

                MessageBox.Show("Item Name Changed Successfully..!!");
                clearfields();
                ButtonSave.Visible = false;
                ButtonSearch.Visible = true;
                button1.Visible = true;
                ButtonCancel.Visible = false;
                GroupBox1.Enabled = false;
     
           
            
        }
        public void clearfields()
        {
            TextITEMCODE.Text = "";
            TextITEMNAME.Text = "";
            TextITEMNAMENEW.Text = "";
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            GroupBox1.Enabled = false;
            ButtonSearch.Visible = true;
            button1.Visible = true;
            ButtonCancel.Visible = false;
            ButtonSave.Visible = false;
            clearfields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearfields();
            this.Hide();
        }

        private void TextITEMNAME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextITEMNAMENEW.Focus();
            }
        }

        private void TextITEMNAMENEW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonSave.Focus();
            }
        }

       
    }
}

