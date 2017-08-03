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
    public partial class FrmItemGrpSearch : Form
    {
        ItemGroupDAL objIGDAL = new ItemGroupDAL();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        public FrmItemGrpSearch()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(10, 60);
            SearchItemGroup();
        }

        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "1";
        public static string SetValueForText3 = "";

        public static string E_modevalue = "";
        public static string grpId = "";
        public static string count = "1";
        
       

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmItemGroup frmigrp = new FrmItemGroup();
            frmigrp.Show();
        }

        private void FrmItemGrpSearch_Load(object sender, EventArgs e)
        {
            count = "1";
            E_modevalue = FrmItemGroup.E_mode;
        }

        public void SearchItemGroup()
        {
            dt = objIGDAL.SearchItemGroup();
            gdv_ItemGrpSearch.DataSource = dt;
            gdv_ItemGrpSearch.Columns[0].Width = 100;
            gdv_ItemGrpSearch.Columns[1].Width = 280;
            gdv_ItemGrpSearch.Columns[2].Width = 200;
        }

       
        private void gdv_ItemGrpSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string var = "";
            var = gdv_ItemGrpSearch.CurrentRow.Cells[2].Value.ToString();

            if (var == "N")
            {
                SetValueForText1 = gdv_ItemGrpSearch.CurrentRow.Cells[1].Value.ToString();
                SetValueForText2 = gdv_ItemGrpSearch.CurrentRow.Cells[3].Value.ToString();
                SetValueForText3 = "2";
                grpId = gdv_ItemGrpSearch.CurrentRow.Cells[0].Value.ToString();
            }
            else if (var == "Y")
            {
                SetValueForText1 = gdv_ItemGrpSearch.CurrentRow.Cells[1].Value.ToString();
                SetValueForText3 = "1";
                grpId = gdv_ItemGrpSearch.CurrentRow.Cells[0].Value.ToString();
            }

            count = "0";
            this.Hide();
            FrmItemGroup frmitmgp = new FrmItemGroup();
            frmitmgp.Show(); 
        }

        private void TextGRNAME_TextChanged(object sender, EventArgs e)
        {
            FetchItemGrpGrid();
        }

        public void FetchItemGrpGrid()
        {
            objIGDAL.Gridvalue = TextGRNAME.Text;
            dt2 = objIGDAL.FetchItemGrpGrid();
            gdv_ItemGrpSearch.DataSource = dt2;
            gdv_ItemGrpSearch.Columns[0].Width = 100;
            gdv_ItemGrpSearch.Columns[1].Width = 300;
            gdv_ItemGrpSearch.Columns[2].Width = 200;
        }

        private void TextGRNAME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gdv_ItemGrpSearch.Focus();  
            }
        }

        private void gdv_ItemGrpSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string var = "";
                var = gdv_ItemGrpSearch.CurrentRow.Cells[2].Value.ToString();

                if (var == "N")
                {
                    SetValueForText1 = gdv_ItemGrpSearch.CurrentRow.Cells[1].Value.ToString();
                    SetValueForText2 = gdv_ItemGrpSearch.CurrentRow.Cells[3].Value.ToString();
                    SetValueForText3 = "2";
                    grpId = gdv_ItemGrpSearch.CurrentRow.Cells[0].Value.ToString();
                }
                else if (var == "Y")
                {
                    SetValueForText1 = gdv_ItemGrpSearch.CurrentRow.Cells[1].Value.ToString();
                    SetValueForText3 = "1";
                    grpId = gdv_ItemGrpSearch.CurrentRow.Cells[0].Value.ToString();
                }

                count = "0";
                this.Hide();
                FrmItemGroup frmitmgp = new FrmItemGroup();
                frmitmgp.Show();
            }
        }

    }
}
