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
namespace BILLING.View.Search
{
    public partial class FrmCommonSearch : Form
    {
        AccountMasterDAL objAMDAL = new AccountMasterDAL();
        EmployeeMasterDAL objEMDAL = new EmployeeMasterDAL();
        GodownNameDAL objGDDAL = new GodownNameDAL();
        BillSeriesMasterDAL objBSMDAL = new BillSeriesMasterDAL();
        TaxDAL objCTDAL = new TaxDAL();
        AdUserDAL objAUDAL = new AdUserDAL();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        string FrmCS = "";
        public static string val = "1";
        public FrmCommonSearch()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(10, 60);
        }
        public static string SetValueForText1 = "";
        public static int SetValueForCount =0;
        public static string smodevalue = "";
        public void SearchMaster()
        {
            if (FrmCS == "ACCOUNT MASTER" || FrmCS == "ACCOUNT HEADS LIST")
            {
                //smodeValue = FrmAccountMaster.smode;
                dt.Clear();
                dt = objAMDAL.SearchAccount();
                gdv_CommonSearch.DataSource = dt;
                GridWidth();
            }
            if (FrmCS == "EMPLOYEE MASTER")
            {
                dt.Clear();
                dt = objEMDAL.SearchAccount();
                gdv_CommonSearch.DataSource = dt;
                GridWidth();
            }
            if (FrmCS == "GODOWN MASTER")
            {
                dt1.Clear();
                dt1 = objGDDAL.SearchGodown();
                gdv_CommonSearch.DataSource = dt1;
                GridWidth();
            }
            if (FrmCS == "BILL SERIES & NOS")
            {
                dt1.Clear();
                dt1 = objBSMDAL.SearchBillSeries();
                gdv_CommonSearch.DataSource = dt1;
                GridWidth();
            }
            if (FrmCS == "CREATE TAX")
            {
                dt1.Clear();
                objCTDAL.compid = Convert.ToInt32("1");
                objCTDAL.fyid = "1";
                dt1 = objCTDAL.SearchTax();
                gdv_CommonSearch.DataSource = dt1;
                GridWidth();
            }
            if (FrmCS == "ADD USER")
            {
                dt1.Clear();
                objCTDAL.compid = Convert.ToInt32("1");
                objCTDAL.fyid = "1";
                dt1 = objAUDAL.SearchUser();
                gdv_CommonSearch.DataSource = dt1;
                GridWidth();
            }
        }

        public void GridWidth()
        {
            if (FrmCS == "ACCOUNT MASTER" || FrmCS == "ACCOUNT HEADS LIST")
            {
                //this.WindowState = FormWindowState.Normal;
                //this.Size = new System.Drawing.Size(730, 427);
                //this.groupBox1.Size = new System.Drawing.Size(720, 393);
                gdv_CommonSearch.Columns[0].Width = 100;
                gdv_CommonSearch.Columns[1].Width = 283;
                gdv_CommonSearch.Columns[2].Width = 283;
                groupBox1.Text = "LIST-ACCOUNT MASTER";
            }
            if (FrmCS == "EMPLOYEE MASTER")
            {
                //this.WindowState = FormWindowState.Normal;
                //this.Size = new System.Drawing.Size(730, 427);
                //this.groupBox1.Size = new System.Drawing.Size(720, 393);
                gdv_CommonSearch.Columns[0].Width = 100;
                gdv_CommonSearch.Columns[1].Width = 200;
                gdv_CommonSearch.Columns[2].Width = 175;
                gdv_CommonSearch.Columns[3].Width = 150;
                gdv_CommonSearch.Columns[4].Width = 120;
                gdv_CommonSearch.Columns[5].Width = 75;
                gdv_CommonSearch.Columns[6].Width = 100;
                groupBox1.Text = "LIST-EMPLOYEE MASTER";
            }
            if (FrmCS == "GODOWN MASTER")
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new System.Drawing.Size(730, 427);
                this.groupBox1.Size = new System.Drawing.Size(720, 393);
                gdv_CommonSearch.Columns[0].Width = 675;
                groupBox1.Text = "LIST-GODOWN MASTER";
            }
            if (FrmCS == "BILL SERIES & NOS")
            {
                //this.WindowState = FormWindowState.Normal;
                //this.Size = new System.Drawing.Size(730, 427);
                //this.groupBox1.Size = new System.Drawing.Size(720, 393);
                gdv_CommonSearch.Columns[0].Width = 200;
                gdv_CommonSearch.Columns[1].Width = 200;
                gdv_CommonSearch.Columns[2].Width = 200;
                groupBox1.Text = "LIST-BILL SERIES & NOS";
            }
            if (FrmCS == "CREATE TAX")
            {
                //this.WindowState = FormWindowState.Normal;
                //this.Size = new System.Drawing.Size(730, 427);
                //this.groupBox1.Size = new System.Drawing.Size(720, 393);
                gdv_CommonSearch.Columns[0].Width = 0;
                gdv_CommonSearch.Columns[0].Visible = false;
                gdv_CommonSearch.Columns[1].Width = 65;
                gdv_CommonSearch.Columns[2].Width = 60;
                gdv_CommonSearch.Columns[3].Width = 55;
                gdv_CommonSearch.Columns[4].Width = 250;
                gdv_CommonSearch.Columns[5].Width = 105;
                gdv_CommonSearch.Columns[6].Width = 100;
                gdv_CommonSearch.Columns[7].Width = 40;

                groupBox1.Text = "LIST-CREATE TAX";
            }
            if (FrmCS == "ADD USER")
            {
                //this.WindowState = FormWindowState.Normal;
                //this.Size = new System.Drawing.Size(730, 427);
                //this.groupBox1.Size = new System.Drawing.Size(720, 393);
                gdv_CommonSearch.Columns[0].Width = 150;
                gdv_CommonSearch.Columns[1].Width = 150;
                gdv_CommonSearch.Columns[2].Width = 150;
                gdv_CommonSearch.Columns[3].Width = 150;
                groupBox1.Text = "LIST-USERS";
            }
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            val = "0";
            if (FrmCS == "ACCOUNT MASTER")
            {
                this.Hide();
                FrmAccountMaster frmacnt = new FrmAccountMaster();
                frmacnt.Show();
            }
            if (FrmCS == "ACCOUNT HEADS LIST")
            {
                this.Hide();
                FrmMDI frmacnt = new FrmMDI();
                frmacnt.Show();
            }
            if (FrmCS == "EMPLOYEE MASTER")
            {
                this.Hide();
                frmEmployeeRegister frmacnt = new frmEmployeeRegister();
                frmacnt.Show();
            }
            if (FrmCS == "GODOWN MASTER")
            {
                this.Hide();
                FrmGodownName frmacnt = new FrmGodownName();
                frmacnt.Show();
            }
            if (FrmCS == "BILL SERIES & NOS")
            {
                this.Hide();
                FrmBillSeries frmacnt = new FrmBillSeries();
                frmacnt.Show();
            }
            if (FrmCS == "CREATE TAX")
            {
                this.Hide();
                FrmCreateTax frmacnt = new FrmCreateTax();
                frmacnt.Show();
            }
            if (FrmCS == "ADD USER")
            {
                this.Hide();
                FrmAdUser frmadusr = new FrmAdUser();
                frmadusr.Show();
            }
        }

        private void FrmCommonSearch_Load(object sender, EventArgs e)
        {
          //  smodevalue = frmEmployeeRegister.smode;
            FrmCS = common.Commn;
            val = "1";
            if (FrmCS == "ACCOUNT MASTER" || FrmCS == "ACCOUNT HEADS LIST")
            {
                smodevalue = FrmAccountMaster.smode;
                SearchMaster();
            }
            if (FrmCS == "EMPLOYEE MASTER")
            {
                smodevalue = frmEmployeeRegister.smode;
                SearchMaster();
            }
            if (FrmCS == "GODOWN MASTER")
            {
                smodevalue = FrmGodownName.smode;
                SearchMaster();
            }
            if (FrmCS == "BILL SERIES & NOS")
            {
                smodevalue = FrmBillSeries.smode;
                SearchMaster();
            }
            if (FrmCS == "CREATE TAX")
            {
                smodevalue = FrmCreateTax.smode;
                SearchMaster();
            }
            if (FrmCS == "ADD USER")
            {
                smodevalue = FrmAdUser.smode;
                SearchMaster();
            }
        }

        private void TextGRNAME_TextChanged(object sender, EventArgs e)
        {
            display12();
        }
        private void display12()
        {
            if (FrmCS == "ACCOUNT MASTER" || FrmCS == "ACCOUNT HEADS LIST")
            {
                FetchAccountMasterGrid();

            }
            if (FrmCS == "EMPLOYEE MASTER")
            {
                FetchItemMasterGrid();
               
            }
            else if (FrmCS == "GODOWN MASTER")
            {
                FetchGodownMasterGrid();
            }
            else if (FrmCS == "BILL SERIES & NOS")
            {
                FetchBillSeriesMasterGrid();
            }
            else if (FrmCS == "CREATE TAX")
            {
                FetchTAXMasterGrid();
            }
            else if (FrmCS == "ADD USER")
            {
                FetchUserMasterGrid();
            }
        }
        public void FetchItemMasterGrid()
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new System.Drawing.Size(730, 427);
            this.groupBox1.Size = new System.Drawing.Size(720, 393);
            objEMDAL.Gridval = TextGRNAME.Text;
            dt2 = objEMDAL.FetchEmployeeMasterGrid();
            gdv_CommonSearch.DataSource = dt2;
            gdv_CommonSearch.Columns[0].Width = 100;
            gdv_CommonSearch.Columns[1].Width = 200;
            gdv_CommonSearch.Columns[2].Width = 175;
            gdv_CommonSearch.Columns[3].Width = 150;
            gdv_CommonSearch.Columns[4].Width = 120;
            gdv_CommonSearch.Columns[5].Width = 75;
            gdv_CommonSearch.Columns[6].Width = 100;
        }
        public void FetchAccountMasterGrid()
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new System.Drawing.Size(730, 427);
            this.groupBox1.Size = new System.Drawing.Size(720, 393);
            objAMDAL.accname = TextGRNAME.Text;
            dt2 = objAMDAL.FetchAccountMasterGrid();
            gdv_CommonSearch.DataSource = dt2;
            gdv_CommonSearch.Columns[0].Width = 100;
            gdv_CommonSearch.Columns[1].Width = 283;
            gdv_CommonSearch.Columns[2].Width = 283;
            groupBox1.Text = "LIST-ACCOUNT MASTER";
        }
        public void FetchGodownMasterGrid()
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new System.Drawing.Size(730, 427);
            this.groupBox1.Size = new System.Drawing.Size(720, 393);
            objGDDAL.godownname = TextGRNAME.Text;
            dt2 = objGDDAL.FetchGodownMasterGrid();
            gdv_CommonSearch.DataSource = dt2;
            gdv_CommonSearch.Columns[0].Width = 600;

          
        }
        public void FetchBillSeriesMasterGrid()
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new System.Drawing.Size(730, 427);
            this.groupBox1.Size = new System.Drawing.Size(720, 393);
            objBSMDAL.category = TextGRNAME.Text;
            dt2 = objBSMDAL.FetchBillSeriesMasterGrid();
            gdv_CommonSearch.DataSource = dt2;
            gdv_CommonSearch.Columns[0].Width = 675;

        }
        public void FetchTAXMasterGrid()
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new System.Drawing.Size(730, 427);
            this.groupBox1.Size = new System.Drawing.Size(720, 393);
            objCTDAL.Gridval = TextGRNAME.Text;
            objCTDAL.compid = Convert.ToInt32("1");
            objCTDAL.fyid = "1";
            dt2 = objCTDAL.FetchTAXMasterGrid();
            gdv_CommonSearch.DataSource = dt2;
            gdv_CommonSearch.Columns[0].Width = 0;
            gdv_CommonSearch.Columns[0].Visible = false;
            gdv_CommonSearch.Columns[1].Width = 65;
            gdv_CommonSearch.Columns[2].Width = 60;
            gdv_CommonSearch.Columns[3].Width = 55;
            gdv_CommonSearch.Columns[4].Width = 250;
            gdv_CommonSearch.Columns[5].Width = 105;
            gdv_CommonSearch.Columns[6].Width = 100;
            gdv_CommonSearch.Columns[7].Width = 40;

        }
        public void FetchUserMasterGrid()
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new System.Drawing.Size(730, 427);
            this.groupBox1.Size = new System.Drawing.Size(720, 393);
            objAUDAL.Gridval = TextGRNAME.Text;
            dt2 = objAUDAL.FetchUserMasterGrid();
            gdv_CommonSearch.DataSource = dt2;
            gdv_CommonSearch.Columns[0].Width = 150;
            gdv_CommonSearch.Columns[1].Width = 150;
            gdv_CommonSearch.Columns[2].Width = 150;
            gdv_CommonSearch.Columns[3].Width = 150;

        }
        private void TextGRNAME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gdv_CommonSearch.Focus();
            }
        }

        private void gdv_CommonSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (FrmCS == "EMPLOYEE MASTER")
                {
                    SetValueForText1 = gdv_CommonSearch.CurrentRow.Cells[0].Value.ToString();
                    this.Hide();
                    frmEmployeeRegister frmitmmstr = new frmEmployeeRegister();
                    frmitmmstr.Show();
                }
                else if (FrmCS == "GODOWN MASTER")
                {
                    SetValueForText1 = gdv_CommonSearch.CurrentRow.Cells[0].Value.ToString();
                    this.Hide();
                    FrmGodownName frmgdmstr = new FrmGodownName();
                    frmgdmstr.Show();
                }
                else if (FrmCS == "BILL SERIES & NOS")
                {
                    SetValueForText1 = gdv_CommonSearch.CurrentRow.Cells[0].Value.ToString();
                    this.Hide();
                    FrmBillSeries frmgdmstr = new FrmBillSeries();
                    frmgdmstr.Show();
                }
                else if (FrmCS == "CREATE TAX")
                {
                    SetValueForText1 = gdv_CommonSearch.CurrentRow.Cells[0].Value.ToString();
                    this.Hide();
                    FrmCreateTax frmgdmstr = new FrmCreateTax();
                    frmgdmstr.Show();
                }
                else if (FrmCS == "ADD USER")
                {
                    SetValueForText1 = gdv_CommonSearch.CurrentRow.Cells[0].Value.ToString();
                    this.Hide();
                    FrmAdUser frmadusr = new FrmAdUser();
                    frmadusr.Show();
                }
                val = "0";
            }
        }

        private void gdv_CommonSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FrmCS == "ACCOUNT MASTER" || FrmCS == "ACCOUNT HEADS LIST")
            {
                SetValueForText1 = gdv_CommonSearch.CurrentRow.Cells[0].Value.ToString();
                this.Hide();
                FrmAccountMaster frmacmstr = new FrmAccountMaster();
                frmacmstr.Show();
            }
           else if (FrmCS == "EMPLOYEE MASTER")
            {
                SetValueForText1 = gdv_CommonSearch.CurrentRow.Cells[0].Value.ToString();
                SetValueForCount = gdv_CommonSearch.CurrentCell.RowIndex;
                this.Hide();
                frmEmployeeRegister frmitmmstr = new frmEmployeeRegister();
                frmitmmstr.Show();
            }
            else if (FrmCS == "GODOWN MASTER")
            {
                SetValueForText1 = gdv_CommonSearch.CurrentRow.Cells[0].Value.ToString();
                SetValueForCount = gdv_CommonSearch.CurrentCell.RowIndex;
                this.Hide();
                FrmGodownName frmgdmstr = new FrmGodownName();
                frmgdmstr.Show();
            }
            else if (FrmCS == "BILL SERIES & NOS")
            {
                SetValueForText1 = gdv_CommonSearch.CurrentRow.Cells[0].Value.ToString();
                SetValueForCount = gdv_CommonSearch.CurrentCell.RowIndex;
                this.Hide();
                FrmBillSeries frmgdmstr = new FrmBillSeries();
                frmgdmstr.Show();
            }
            else if (FrmCS == "CREATE TAX")
            {
                SetValueForText1 = gdv_CommonSearch.CurrentRow.Cells[0].Value.ToString();
                SetValueForCount = gdv_CommonSearch.CurrentCell.RowIndex;
                this.Hide();
                FrmCreateTax frmgdmstr = new FrmCreateTax();
                frmgdmstr.Show();
            }
            else if (FrmCS == "ADD USER")
            {
                SetValueForText1 = gdv_CommonSearch.CurrentRow.Cells[0].Value.ToString();
                SetValueForCount = gdv_CommonSearch.CurrentCell.RowIndex;
                this.Hide();
                FrmAdUser frmadusr = new FrmAdUser();
                frmadusr.Show();
            }
            val = "0";
        }
    }
}
