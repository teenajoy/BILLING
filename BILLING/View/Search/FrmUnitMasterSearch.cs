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

namespace BILLING.View.Search
{
    public partial class FrmUnitMasterSearch : Form
    {
        UnitMasterDAL objUMDAL = new UnitMasterDAL();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        public FrmUnitMasterSearch()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(10, 60);
            SearchUnitMaster();
        }


        public static string SetValueForText1 = "";
        public static string umodevalue = "";

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUnitMaster frmum = new FrmUnitMaster();
            frmum.Show();
        }

        private void FrmUnitMasterSearch_Load(object sender, EventArgs e)
        {
            umodevalue = FrmUnitMaster.umode;

        }

        public void SearchUnitMaster()
        {
            dt = objUMDAL.SearchUnitMaster();
            gdv_UnitMasterSearch.DataSource = dt;
            gdv_UnitMasterSearch.Columns[0].Width = 68;
            gdv_UnitMasterSearch.Columns[1].Width = 175;
            gdv_UnitMasterSearch.Columns[2].Width = 68;
            gdv_UnitMasterSearch.Columns[3].Width = 76;
        }

        private void TextGRNAME_TextChanged(object sender, EventArgs e)
        {
            FetchUnitMasterGrid();
        }

        public void FetchUnitMasterGrid()
        {
            objUMDAL.GridUnit = TextGRNAME.Text;
            dt2 = objUMDAL.FetchUnitMasterGrid();
            gdv_UnitMasterSearch.DataSource = dt2;
            gdv_UnitMasterSearch.Columns[0].Width = 68;
            gdv_UnitMasterSearch.Columns[1].Width = 175;
            gdv_UnitMasterSearch.Columns[2].Width = 68;
            gdv_UnitMasterSearch.Columns[3].Width = 76;
        }

        private void TextGRNAME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gdv_UnitMasterSearch.Focus();
            }
        }

        private void gdv_UnitMasterSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetValueForText1 = gdv_UnitMasterSearch.CurrentRow.Cells[0].Value.ToString();

               // val = "0";

                this.Hide();
                FrmUnitMaster frmitumstr = new FrmUnitMaster();
                frmitumstr.Show();
            }
        }

        private void gdv_UnitMasterSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SetValueForText1 = gdv_UnitMasterSearch.CurrentRow.Cells[0].Value.ToString();

            this.Hide();
            FrmUnitMaster frmitumstr = new FrmUnitMaster();
            frmitumstr.Show();
        }
    }
}
