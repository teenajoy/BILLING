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
using BILLING.View.Login;
namespace BILLING.View.Masters
{
    public partial class FrmBillSeries : Form
    {
        BillSeriesMasterDAL objBSDAL = new BillSeriesMasterDAL();
        CmpntLoginDAL objCLDAL = new CmpntLoginDAL();
        FrmCmpnyLogin objL = new FrmCmpnyLogin();
        public static string FYear = "";
        public static string smode = "";
        string grpid = "";
        int check = 0;
        public FrmBillSeries()
        {
           
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(10, 60);
            Listcategory.Visible = false;
            GroupBox1.Enabled = false;
            display();
            ButtonExit.Visible = true;
            
        }
        public void enable()
        {
            ButtonAdd.Enabled = true;
            ButtonSearch.Enabled = true;
            ButtonEdit.Enabled = true;
            ButtonDelete.Enabled = true;
            ButtonSave.Enabled = false;
            ButtonCancel.Enabled = false;
        }
        public void desabled()
        {
            ButtonAdd.Enabled = false;
            ButtonSearch.Enabled = false;
            ButtonEdit.Enabled = false;
            ButtonDelete.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonCancel.Enabled = true;
        }
 
        public void display()
        {
            ButtonAdd.Visible = true;
            ButtonSearch.Visible = true;
            ButtonEdit.Visible = true;
            ButtonDelete.Visible = true;
            ButtonDelete.Enabled = false;
            ButtonSave.Visible = false;
            ButtonCancel.Visible = false;
        }
        public void display1()
        {
            ButtonAdd.Visible = false;
            ButtonSearch.Visible = false;
            ButtonEdit.Visible = false;
            ButtonDelete.Visible = false;
            ButtonSave.Visible = true;
            ButtonCancel.Visible = true;
        }
        public void list()
        {
            Listcategory.Items.Clear();
            Listcategory.Items.Add("Contra");
            Listcategory.Items.Add("Credit Note");
            Listcategory.Items.Add("Customer Details Entry");
            Listcategory.Items.Add("Debit Note");
            Listcategory.Items.Add("Delivery Challan In");
            Listcategory.Items.Add("Delivery Challan Out");
            Listcategory.Items.Add("Journel");
            Listcategory.Items.Add("Payment");
            Listcategory.Items.Add("Purchase");
            Listcategory.Items.Add("Purchase Order");
            Listcategory.Items.Add("Purchase Return");
            Listcategory.Items.Add("Quotation");
            Listcategory.Items.Add("Sales");
            Listcategory.Items.Add("Sales Order");
            Listcategory.Items.Add("Sales Return");
            Listcategory.Items.Add("Stock Transfer");
            Listcategory.Items.Add("Receipt");
            Listcategory.Items.Add("CONTRACT");
        }
        public void series()
        {
            Comboseries.Items.Clear();
            Comboseries.Items.Add("MAIN");
            Comboseries.SelectedIndex = -1;
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            ButtonExit.Visible = false;
            GroupBox1.Enabled = true;
            EnableTextBox();
            check = 1;
            display1();
            Listcategory.Visible = true;
            list();
            series();
        }

        private void Listcategory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Textcategory.Text = Listcategory.SelectedItem.ToString();
            Listcategory.Hide();

        }
        public void finyear()
        {
            DataTable dt1 = new DataTable();
            dt1 = objCLDAL.FetchFinancialYear();
            FYear = dt1.Rows[0][1].ToString();
        }
        public void ClearFields()
        {
            Textcategory.Text = "";
            Comboseries.Text = "";
            TextserialNo.Text = "";
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if ((Textcategory.Text == "") & (check == 1))
            {
                MessageBox.Show("Please select Category");
                return;
            }
            if ((Comboseries.Text == "") & (check == 1))
            {
                MessageBox.Show("Please select Series");
                return;
            }
            if ((TextserialNo.Text == "") & (check == 1))
            {
                MessageBox.Show("Please type SerialNumber");
                return;
            }
            if (check == 1)
            {

                objBSDAL.category = Listcategory.Text;
                objBSDAL.series = Comboseries.Text;
                DataTable dt6 = new DataTable();
                dt6 = objBSDAL.FetchBillSearch();
                if (dt6.Rows.Count == 0)
                {
                    objBSDAL.category = Listcategory.Text;
                    objBSDAL.series = Comboseries.Text;
                    objBSDAL.serialno = Convert.ToInt32(TextserialNo.Text);
                    objBSDAL.coid = FrmCmpnyLogin.CompnId;
                    finyear();
                    objBSDAL.Finyear = FYear.ToString();
                    objBSDAL.Estatus = 0;

                    DataTable dt4 = new DataTable();
                    dt4 = objBSDAL.InsertItem();

                    MessageBox.Show("Items Saved Successfully..!!");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Already Exist..!!");
                }
            }
            else 
            {
                objBSDAL.category = Textcategory.Text;
                objBSDAL.series = Comboseries.Text;
                objBSDAL.serialno = Convert.ToInt32(TextserialNo.Text);
               
                DataTable dt4 = new DataTable();
                dt4 = objBSDAL.Update();

                MessageBox.Show("Items Updated Successfully..!!");
                ClearFields();
            }
            ButtonExit.Visible = true;
            GroupBox1.Enabled = false;
            DisableTextBox();

            display();
            ClearFields();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            ButtonExit.Visible = true;
            smode = "1";
            FrmCommonSearch frmcmsrch = new FrmCommonSearch();
            frmcmsrch.Show();
            this.Hide();
        }

        private void FrmBillSeries_Load(object sender, EventArgs e)
        {
            if (int.Parse(FrmCommonSearch.val) == 1)
            {
                if (FrmCommonSearch.smodevalue == "1")
                {
                    //EnableTextBox();
                    GroupBox1.Enabled = true;
                    display();
                    ButtonDelete.Visible = true;
                    ButtonDelete.Enabled = true;
                    ButtonCancel.Visible = false;
                    // groupBox2.Visible = true;
                    // ButtonNext.Enabled = true;
                    //ButtonPrevious.Enabled = true;
                    //  loadvisiblebutton();
                    DataTable dt5 = new DataTable();
                    grpid = FrmCommonSearch.SetValueForText1.ToString();
                    int j = 0;
                    j = FrmCommonSearch.SetValueForCount;
                    objBSDAL.category = grpid;
                    dt5.Clear();
                    dt5 = objBSDAL.FetchBillSeriesMaster();
                    if (dt5.Rows.Count > 0)
                    {
                        Textcategory.Text = dt5.Rows[0]["Category"].ToString();
                        Comboseries.Text = dt5.Rows[0]["Series"].ToString();
                        TextserialNo.Text = dt5.Rows[0]["VSerialNo"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Couldnt find the selected Item..!!");
                    }
                }
                else if (FrmCommonSearch.smodevalue == "2")
                {
                    //EnableTextBox();
                    GroupBox1.Enabled = true;
                    ButtonDelete.Visible = true;
                    ButtonDelete.Enabled = true;
                    ButtonCancel.Visible = false;
                    display1();
                    ButtonExit.Visible = false;
                    // groupBox2.Visible = true;
                    // ButtonNext.Enabled = true;
                    //ButtonPrevious.Enabled = true;
                    //  loadvisiblebutton();
                    DataTable dt5 = new DataTable();
                    grpid = FrmCommonSearch.SetValueForText1.ToString();
                    int j = 0;
                    j = FrmCommonSearch.SetValueForCount;
                    objBSDAL.category = grpid;
                    dt5.Clear();
                    dt5 = objBSDAL.FetchBillSeriesMaster();
                    if (dt5.Rows.Count > 0)
                    {
                        Textcategory.Text = dt5.Rows[0]["Category"].ToString();
                        Comboseries.Text = dt5.Rows[0]["Series"].ToString();
                        TextserialNo.Text = dt5.Rows[0]["VSerialNo"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Couldnt find the selected Item..!!");
                    }
                }
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            ButtonExit.Visible = true;
            smode = "2";
            check = 2;
            
                FrmCommonSearch frmmsrch = new FrmCommonSearch();
                frmmsrch.Show();
                this.Hide();
            
        }

        private void Textcategory_MouseClick(object sender, MouseEventArgs e)
        {
            if (smode == "1")
            {
                Listcategory.Visible = true;
                list();
            }
            else
            {
                Listcategory.Visible = false;
            }
        }
        public void DisableTextBox()
        {
            TextserialNo.Enabled = false;
            Comboseries.Enabled = false;
            Textcategory.Enabled = false;
        }
        public void EnableTextBox()
        {
            TextserialNo.Enabled = true;
            Comboseries.Enabled = true;
            Textcategory.Enabled = true;
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            ButtonExit.Visible = true;
            GroupBox1.Enabled = false;
            DisableTextBox();
           
            display();
            ClearFields();
            Listcategory.Hide();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            ClearFields();
            this.Hide();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            objBSDAL.category = Textcategory.Text;
            objBSDAL.series = Comboseries.Text;
            finyear();
            objBSDAL.Finyear = FYear;
            objBSDAL.Estatus = 0;
            objBSDAL.coid = 1;

            DialogResult dr = MessageBox.Show("Are you sure to delete row?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                DataTable dt6 = new DataTable();
                dt6 = objBSDAL.DeleteSeries();
                MessageBox.Show("Record Deleted..!!");
                ClearFields();
            }
            else if (dr == DialogResult.No)
            {
                ClearFields();
            }
        }

        private void Listcategory_KeyPress(object sender, KeyPressEventArgs e)
        {

            this.Textcategory.Text = this.Listcategory.Text;
            this.Listcategory.Visible = false;
            this.Comboseries.Focus();
        }
    }
}
