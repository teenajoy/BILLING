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
using BILLING.View.Masters;
using BILLING.View.EDIT;

namespace BILLING.View.Search
{
    public partial class FrmItemMasterSearch : Form
    {
        ItemMasterDAL objIMDAL = new ItemMasterDAL();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        string FrmCS = "";
        public FrmItemMasterSearch()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(10, 60);
            SearchItemMaster();
        }

        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = "";
        public static string SetValueForText6 = "";
        public static string SetValueForText7 = "";
        public static string SetValueForText8 = "";
        public static string SetValueForText9 = "";
        public static string SetValueForText10 = "";
        public static string SetValueForText11 = "";

        public static string smodevalue = "";
        public static string grpId = "";
        public static string val = "1";


        private void ButtonExit_Click(object sender, EventArgs e)
        {
            if (FrmCS == "ITEM MASTER")
            {
                this.Hide();
                FrmItemMaster frmitm = new FrmItemMaster();
                frmitm.Show();
            }
            else if (FrmCS == "CHANGE ITEM NAME")
            {
                this.Hide();
                FrmChangeItemName frmitm = new FrmChangeItemName();
                frmitm.Show();
            }
        }

        private void FrmItemMasterSearch_Load(object sender, EventArgs e)
        {
            FrmCS = common.Commn;
            val = "1";
            smodevalue = FrmItemMaster.smode;
            if (FrmCS == "ITEM MASTER")
            {
                smodevalue = FrmItemMaster.smode;
                
            }
           else if (FrmCS == "CHANGE ITEM NAME")
            {
                smodevalue = FrmChangeItemName.smode;
               
            }
        }

        public void SearchItemMaster()
        {
            dt = objIMDAL.SearchItemMaster();
            gdv_ItemMasterSearch.DataSource = dt;
            gdv_ItemMasterSearch.Columns[0].Width = 68;
            gdv_ItemMasterSearch.Columns[1].Width = 175;
            gdv_ItemMasterSearch.Columns[2].Width = 68;
            gdv_ItemMasterSearch.Columns[3].Width = 76;
            gdv_ItemMasterSearch.Columns[4].Width = 76;
            gdv_ItemMasterSearch.Columns[5].Width = 76;
            gdv_ItemMasterSearch.Columns[6].Width = 76;
            gdv_ItemMasterSearch.Columns[7].Width = 76;
            gdv_ItemMasterSearch.Columns[8].Width = 76;
            gdv_ItemMasterSearch.Columns[9].Width = 68;
     
            
        }

        private void gdv_ItemMasterSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FrmCS == "ITEM MASTER")
            {
                SetValueForText1 = gdv_ItemMasterSearch.CurrentRow.Cells[0].Value.ToString();

                val = "0";

                this.Hide();
                FrmItemMaster frmitmmstr = new FrmItemMaster();
                frmitmmstr.Show();
            }
            else if (FrmCS == "CHANGE ITEM NAME")
            {
                SetValueForText1 = gdv_ItemMasterSearch.CurrentRow.Cells[0].Value.ToString();

                val = "0";

                this.Hide();
                FrmChangeItemName frmitmmstr = new FrmChangeItemName();
                frmitmmstr.Show();
            }

        }

        private void TextGRNAME_TextChanged(object sender, EventArgs e)
        {
            FetchItemMasterGrid();
        }

        public void FetchItemMasterGrid()
        {
            objIMDAL.Gridval = TextGRNAME.Text;
            dt2 = objIMDAL.FetchItemMasterGrid();
            gdv_ItemMasterSearch.DataSource = dt2;
            gdv_ItemMasterSearch.Columns[0].Width = 68;
            gdv_ItemMasterSearch.Columns[1].Width = 175;
            gdv_ItemMasterSearch.Columns[2].Width = 68;
            gdv_ItemMasterSearch.Columns[3].Width = 76;
            gdv_ItemMasterSearch.Columns[4].Width = 76;
            gdv_ItemMasterSearch.Columns[5].Width = 76;
            gdv_ItemMasterSearch.Columns[6].Width = 76;
            gdv_ItemMasterSearch.Columns[7].Width = 76;
            gdv_ItemMasterSearch.Columns[8].Width = 76;
            gdv_ItemMasterSearch.Columns[9].Width = 68;
        }

        private void TextGRNAME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gdv_ItemMasterSearch.Focus();
            }
        }

        private void gdv_ItemMasterSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (FrmCS == "ITEM MASTER")
                {
                    SetValueForText1 = gdv_ItemMasterSearch.CurrentRow.Cells[0].Value.ToString();

                    val = "0";

                    this.Hide();
                    FrmItemMaster frmitmmstr = new FrmItemMaster();
                    frmitmmstr.Show();
                }
                else if (FrmCS == "CHANGE ITEM NAME")
                {
                    SetValueForText1 = gdv_ItemMasterSearch.CurrentRow.Cells[0].Value.ToString();

                    val = "0";

                    this.Hide();
                    FrmChangeItemName frmitmmstr = new FrmChangeItemName();
                    frmitmmstr.Show();
                }

            }
        }

       
    }
}
