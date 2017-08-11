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
using BILLING.View.MDI;
using BILLING.View.Utils;
using BILLING.View.Login;

namespace BILLING.View.Stock
{
    public partial class FrmStockPreview : Form
    {
        StockDAL objSDAL = new StockDAL();
        FrmCmpnyLogin objL = new FrmCmpnyLogin();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        string FrmCS = "";
        public static string val = "1";
        public FrmStockPreview()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(10, 60);
        }

        private void FrmStockPreview_Load(object sender, EventArgs e)
        {
            stockpreview();
        }
        public void stockpreview()
        {

            dt.Clear();
            objSDAL.cid = FrmCmpnyLogin.CompnId;
            objSDAL.Fid = FrmCmpnyLogin.FYID;
            dt = objSDAL.SearchStock();
            gdv_CommonSearch.DataSource = dt;
            GridWidth();
        }
         public void GridWidth()
        {

            gdv_CommonSearch.Columns[0].Width =60;
            gdv_CommonSearch.Columns[1].Width = 150;
            gdv_CommonSearch.Columns[2].Width = 60;
            gdv_CommonSearch.Columns[3].Width = 60;
            gdv_CommonSearch.Columns[4].Width = 100;
            gdv_CommonSearch.Columns[5].Width = 100;
            gdv_CommonSearch.Columns[6].Width = 100;
            gdv_CommonSearch.Columns[7].Width = 80;
            gdv_CommonSearch.Columns[8].Width = 50;
            gdv_CommonSearch.Columns[9].Width = 50;
            gdv_CommonSearch.Columns[10].Width = 50;
            gdv_CommonSearch.Columns[11].Width = 50;
               
            }

         private void ButtonAdd_Click(object sender, EventArgs e)
         {
             stockpreview();
         }

         private void ButtonExit_Click(object sender, EventArgs e)
         {
             this.Hide();
         }
    }
}
