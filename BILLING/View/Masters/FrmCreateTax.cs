using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingDAL;
using BILLING.View.Search;

namespace BILLING.View.Masters
{
    public partial class FrmCreateTax : Form
    {
       
        CmpntLoginDAL objCLDAL = new CmpntLoginDAL();
        public static string FYear = "";
        public static string smode = "";
        public static string new1 = "";
        public static string new2 = "";
        public static int j = 0;
        string grpid = "";
        int check = 0;
        TaxDAL objtaxDAL = new TaxDAL();
        public FrmCreateTax()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(10, 60);
        }
        public void ClearFeilds()
        {
            Textcategory.Text = "";
            Combotype.Text = "";
            ComboTaxPer.Text = "";
            TextAccountHead1.Text = "";
            Textundergroup.Text = "";
            ListUndergroup.Hide();
        }
     
        private void Listcategory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Textcategory.Text = Listcategory.SelectedItem.ToString();
            Listcategory.Hide();
        }

        private void Combotype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ComboTaxPer.Focus();
            }
        }

        private void ComboTaxPer_KeyDown(object sender, KeyEventArgs e)
        {
            //string new1 =Textcategory.Text+Combotype.Text+ComboTaxPer.Text+"%";
            if (e.KeyCode == Keys.Enter)
            {
                accounthead();
                Textundergroup.Focus();
                ListUndergroup.Visible = true;
            }
        }
        public void accounthead()
        {
            if (RadioNT.Checked == true)
            {
                string new2 = Textcategory.Text +" "+ "NON TAXABLE";
                TextAccountHead1.Text = new2;
            }
           else if (RadioT.Checked == true)
            {
                string new2 = Textcategory.Text +" "+ Combotype.Text +" "+ ComboTaxPer.Text + "% TAXABLE";
                TextAccountHead1.Text = new2;
            }
           else if (RadioTC.Checked == true)
            {
                string new2 = Textcategory.Text +" "+ Combotype.Text +" "+ ComboTaxPer.Text + "% TAX COLLECTED";
                TextAccountHead1.Text = new2;
            }
        }
        public void taxhead()
        {
            if (RadioNT.Checked == true)
            {
               new1 = "NONTAXABLE";
               
            }
            else if (RadioT.Checked == true)
            {
             new1 ="TAXABLE";
             }
            else if (RadioTC.Checked == true)
            {
              new1 = "TAX COLLECTED";
              
            }
        }
        public void finyear()
        {
            DataTable dt1 = new DataTable();
            dt1 = objCLDAL.FetchFinancialYear();
            FYear = dt1.Rows[0][1].ToString();
        }
        public void EnableTextBox()
        {
            Textcategory.Enabled = true;
            Combotype.Enabled = true;
            ComboTaxPer.Enabled = true;
            TextAccountHead1.Enabled = true;
            Textundergroup.Enabled = true;

        }
        private void FrmCreateTax_Load(object sender, EventArgs e)
        {
            DataTable dt3 = new DataTable();
            dt3 = objtaxDAL.SearchGroupMaster();
            if (dt3.Rows.Count > 0)
            {
                ListUndergroup.DisplayMember = "AgName";
                ListUndergroup.DataSource = dt3;
            }
            if (int.Parse(FrmCommonSearch.val) == 1)
            {
                if (FrmCommonSearch.smodevalue == "1")
                {
                    Textcategory.Enabled = false;
                    Combotype.Enabled = false;
                    ComboTaxPer.Enabled = false;
                    TextAccountHead1.Enabled = false;
                    Textundergroup.Enabled = true;
                    Combocurrt.Enabled = true;
                    GroupBox1.Enabled = true;
                    button6.Enabled = true;
                    button7.Enabled = true;
                    grpid = FrmCommonSearch.SetValueForText1.ToString();
                    int j = 0;
                    j = FrmCommonSearch.SetValueForCount;
                    objtaxDAL.taxid =Convert.ToInt32(grpid);
                    DataTable dt5 = new DataTable();
                    dt5.Clear();
                    dt5 = objtaxDAL.FetchTAXMaster();
                    if (dt5.Rows.Count > 0)
                    {
                        Textcategory.Text = dt5.Rows[0]["Category"].ToString();
                        Combotype.Text = dt5.Rows[0]["TaxType"].ToString();
                        ComboTaxPer.Text = dt5.Rows[0]["TaxPer"].ToString();
                        TextAccountHead1.Text = dt5.Rows[0]["Head"].ToString();
                        Textundergroup.Text = dt5.Rows[0]["AgName1"].ToString();
                        Combocurrt.Text = dt5.Rows[0]["Active"].ToString();
                        

                    }
                    else
                    {
                        MessageBox.Show("Couldnt find the selected Item..!!");
                    }
                }
                else if (FrmCommonSearch.smodevalue == "2")
                {
                    check = 2;
                    Textcategory.Enabled = false;
                    Combotype.Enabled = false;
                    ComboTaxPer.Enabled = false;
                    TextAccountHead1.Enabled = false;
                    Textundergroup.Enabled = true;
                    Combocurrt.Enabled = true;
                    GroupBox1.Enabled = true;
                 //   loadbutton1();
                    groupBox2.Hide();
                    RadioNT.Enabled = false;
                    RadioT.Enabled = false;
                    RadioTC.Enabled = false;
                    grpid = FrmCommonSearch.SetValueForText1.ToString();
                    int j = 0;
                    j = FrmCommonSearch.SetValueForCount;
                    objtaxDAL.taxid = Convert.ToInt32(grpid);
                    DataTable dt5 = new DataTable();
                    dt5.Clear();
                    dt5 = objtaxDAL.FetchTAXMaster();
                    if (dt5.Rows.Count > 0)
                    {
                        Textcategory.Text = dt5.Rows[0]["Category"].ToString();
                        Combotype.Text = dt5.Rows[0]["TaxType"].ToString();
                        ComboTaxPer.Text = dt5.Rows[0]["TaxPer"].ToString();
                        TextAccountHead1.Text = dt5.Rows[0]["Head"].ToString();
                        Textundergroup.Text = dt5.Rows[0]["AgName1"].ToString();
                        Combocurrt.Text = dt5.Rows[0]["Active"].ToString();
                        
                    }
                    else
                    {
                        MessageBox.Show("Couldnt find the selected Item..!!");
                    }
                   // loadbutton1();
                }
                else
                {
                    GroupBox1.Visible = true;
                   // groupBox2.Visible = true;
                }
            }
        }

        private void ListUndergroup_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Textundergroup.Text = ListUndergroup.Text;
            ListUndergroup.Hide();
        }

    
        private void RadioNT_Click(object sender, EventArgs e)
        {
            if (RadioNT.Checked == true)
            {
                ComboTaxPer.ReadOnly = true;
                Combotype.ReadOnly = true;
            }
        }

        private void RadioT_Click(object sender, EventArgs e)
        {
            if (RadioT.Checked == true)
            {
                ComboTaxPer.ReadOnly = false;
                Combotype.ReadOnly = false;
            }
        }

     
        private void button5_Click(object sender, EventArgs e)
        {
            GroupBox1.Enabled = true;
            check = 0;
            RadioNT.Enabled = true;
            RadioT.Enabled = true;
            RadioTC.Enabled = true;
            Combotype.Enabled = true;
            ComboTaxPer.Enabled = true;
            TextAccountHead1.Enabled = true;
            Listcategory.Visible = true;
            ClearFeilds();
            groupBox2.Hide();
          //  loadbutton1();
            GroupBox1.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt7 = new DataTable();
            dt7.Clear();
            objtaxDAL.compid = Convert.ToInt32("1");
            objtaxDAL.fyid = "1";
            dt7 = objtaxDAL.SearchTax();
            if (j < dt7.Rows.Count && j != 0)
            {
                j--;
                Textcategory.Text = dt7.Rows[j]["Group"].ToString();
                Combotype.Text = dt7.Rows[j]["Type"].ToString();
                ComboTaxPer.Text = dt7.Rows[j]["Tax%"].ToString();
                TextAccountHead1.Text = dt7.Rows[j]["Head"].ToString();
                Textundergroup.Text = dt7.Rows[j]["Category"].ToString();
                Combocurrt.Text = dt7.Rows[j]["Using(Y/N)"].ToString();
            }
            else
            {
                MessageBox.Show("No Next Record..!!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt6 = new DataTable();
            dt6.Clear();
            objtaxDAL.compid = Convert.ToInt32("1");
            objtaxDAL.fyid = "1";
            dt6 = objtaxDAL.SearchTax();
            if (j < dt6.Rows.Count - 1)
            {
                j++;
                Textcategory.Text = dt6.Rows[j]["Group"].ToString();
                Combotype.Text = dt6.Rows[j]["Type"].ToString();
                ComboTaxPer.Text = dt6.Rows[j]["Tax%"].ToString();
                TextAccountHead1.Text = dt6.Rows[j]["Head"].ToString();
                Textundergroup.Text = dt6.Rows[j]["Category"].ToString();
                Combocurrt.Text = dt6.Rows[j]["Using(Y/N)"].ToString();
            }
            else
            {
                MessageBox.Show("No Next Record..!!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            smode = "1";
            FrmCommonSearch frmcmsrch = new FrmCommonSearch();
            frmcmsrch.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            smode = "2";
            check = 2;
            FrmCommonSearch frmcmsrch = new FrmCommonSearch();
            frmcmsrch.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFeilds();
            // GroupSave.Hide();
            groupBox2.Visible = true;
            groupBox2.BringToFront();
            ////GroupAdd.Visible = true;
            ////GroupAdd.BringToFront();
            ////ListUndergroup.Hide();
            ////GroupBox1.Enabled = false;
            //GroupSave.Hide();
            GroupBox1.Enabled = false;
            smode = "";
            new1 = "";
            new2 = "";
            grpid = "";
            ////GroupAdd.Visible = true;
            ////GroupAdd.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((Textcategory.Text == "") & (check == 0))
            {
                MessageBox.Show("Please select Category");
                return;
            }
            if (check == 0)
            {

                objtaxDAL.category = Listcategory.Text;
                taxhead();
                objtaxDAL.taxtype = Combotype.Text;
                objtaxDAL.taxpet = !string.IsNullOrEmpty(ComboTaxPer.Text) ? Convert.ToDecimal(ComboTaxPer.Text) : 0; ;
                objtaxDAL.amid = Textundergroup.Text;
                objtaxDAL.head = TextAccountHead1.Text;
                objtaxDAL.taxcategory = new1;
                objtaxDAL.active = Combocurrt.Text;
                objtaxDAL.fyid = "2017-2018";
                objtaxDAL.compid = 1;
                DataTable dt6 = new DataTable();
                dt6 = objtaxDAL.FetchBillSearch();
                if (dt6.Rows.Count == 0)
                {
                    objtaxDAL.category = Listcategory.Text;
                    taxhead();
                    objtaxDAL.taxtype = Combotype.Text;
                    objtaxDAL.taxpet = !string.IsNullOrEmpty(ComboTaxPer.Text) ? Convert.ToDecimal(ComboTaxPer.Text) : 0; ;
                    objtaxDAL.amid = Textundergroup.Text;
                    objtaxDAL.head = TextAccountHead1.Text;
                    objtaxDAL.taxcategory = new1;
                    objtaxDAL.active = Combocurrt.Text;
                    finyear();
                    objtaxDAL.fyid = "2017-2018";
                    objtaxDAL.compid = 1;

                    DataTable dt4 = new DataTable();
                    dt4 = objtaxDAL.InsertItem();

                    MessageBox.Show("Items Saved Successfully..!!");
                    // ClearFields();
                }
                else
                {
                    MessageBox.Show("Already Exist..!!");
                }
            }
            else
            {
                objtaxDAL.active = Combocurrt.Text;
                objtaxDAL.head = TextAccountHead1.Text;
                DataTable dt4 = new DataTable();
                dt4 = objtaxDAL.UpdateItem();

                MessageBox.Show("Items Updated Successfully..!!");
                ClearFeilds();
            }
            groupBox2.Visible = true;
            GroupBox1.Visible = true;
            ClearFeilds();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearFeilds();
            this.Hide();
        }
    
    }
}
