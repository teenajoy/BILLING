using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingDAL;
namespace BILLING.View.Stock
{
    
    public partial class FrmStockEntry : Form
    {
        StockDAL objSDAL = new StockDAL();
        public FrmStockEntry()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            TextGRNAME.Size = Screen.PrimaryScreen.WorkingArea.Size;
            groupBox2.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
        public void load()
        {
            DataTable dt = new DataTable();
           dt= objSDAL.selectstock();
           dgdItemEdit.DataSource = dt;
           dgdItemEdit.Columns["Units"].ReadOnly = true;
           label2.Text = dgdItemEdit.RowCount.ToString() + " Records Found ";
        }
        public void fnSave()
        {

        }
        private void FrmStockEntry_Load(object sender, EventArgs e)
        {
            load();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            for(int i=0;i<dgdItemEdit.Rows.Count;i++)
            {
                objSDAL.itmid =Convert.ToInt32(dgdItemEdit.Rows[i].Cells["ItmId"].Value.ToString());
                objSDAL.itmname = dgdItemEdit.Rows[i].Cells["ItemName"].Value.ToString();
                objSDAL.opstock = float.Parse(dgdItemEdit.Rows[i].Cells["OpeningStock"].Value.ToString());
                objSDAL.pprice = Convert.ToDecimal(dgdItemEdit.Rows[i].Cells["PPRICE"].Value.ToString());
                objSDAL.landcost = Convert.ToDecimal(dgdItemEdit.Rows[i].Cells["LandingCost"].Value.ToString());
                objSDAL.price1 = Convert.ToDecimal(dgdItemEdit.Rows[i].Cells["Price1"].Value.ToString());
                objSDAL.price2 = Convert.ToDecimal(dgdItemEdit.Rows[i].Cells["Price2"].Value.ToString());
                objSDAL.price3 = Convert.ToDecimal(dgdItemEdit.Rows[i].Cells["Price3"].Value.ToString());
                objSDAL.mrp = Convert.ToDecimal(dgdItemEdit.Rows[i].Cells["MRP"].Value.ToString());
                DataTable dt1 = new DataTable();
                dt1 = objSDAL.updatestock();
            }
            MessageBox.Show("Updated Successfully");
            load();
            TextGRNAME.Text = "";
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TextGRNAME_TextChanged(object sender, EventArgs e)
        {
            DataTable dt4 = new DataTable();
            objSDAL.Gridval = TextGRNAME.Text;
            dt4 = objSDAL.FetchStockEntryMasterGrid();
            dgdItemEdit.DataSource = dt4;
            dgdItemEdit.Columns["Units"].ReadOnly = true;
            label2.Text = dgdItemEdit.RowCount.ToString() + " Records Found ";
        }
    }
}
