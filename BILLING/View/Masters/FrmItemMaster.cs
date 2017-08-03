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

namespace BILLING.View.Masters
{
    public partial class FrmItemMaster : Form
    {
        ItemMasterDAL objIMDAL = new ItemMasterDAL();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dt5 = new DataTable();
        int grpmain = 0;

        public static string smode = "";

        int grpid;
        int check = 1;

        public FrmItemMaster()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(10, 60);

            ClearFields();
            DisableTextBox();
            loadvisiblebutton();
            Disablelistbox();
            btnAdd.Focus();

            FetchItemGroup();
            FetchGoDown();
            //FetchItemSubGroup();
        }

        public void DisableTextBox()
        {
            txtitemname.Enabled = false;
            cmbunit.Enabled = false;
            txtpprice.Enabled = false;
            txtlandcost.Enabled = false;
            txtprice1.Enabled = false;
            txtprice2.Enabled = false;
            txtprice3.Enabled = false;
            txtoplc.Enabled = false;
            txtopstock.Enabled = false;
            txtmaxlevel.Enabled = false;
            txtminlevel.Enabled = false;
            txtreorder.Enabled = false;
            txtlocation.Enabled = false;
            txtdescription.Enabled = false;
            txthsncode.Enabled = false;
            txtScheduleNo.Enabled = false;
            txtmrp.Enabled = false;
            cmbtax.Enabled = false;
            cmbCGST.Enabled = false;
            cmbGroup.Enabled = false;
            cmbSubGroup.Enabled = false;
            cmbGodown.Enabled = false;
            txtsupplier.Enabled = false;
            TextSTOCK.Enabled=false;
            groupBox1.Enabled = false;
        }
      
        public void Disablelistbox()
        {
            ListboxTax.Visible = false;
            ListboxSGST.Visible = false;
            ListboxUnit.Visible = false;
            ListboxSupplier.Visible = false;
        }

        public void EnableTextBox()
        {
            txtitemname.Enabled = true;
            txtitemname.BackColor = Color.White;
            cmbunit.Enabled = true;
            cmbunit.BackColor = Color.White;
            txtpprice.Enabled = true;
            txtpprice.BackColor = Color.White;
            txtlandcost.Enabled = true;
            txtlandcost.BackColor = Color.White;
            txtprice1.Enabled = true;
            txtprice1.BackColor = Color.White;
            txtprice2.Enabled = true;
            txtprice2.BackColor = Color.White;
            txtprice3.Enabled = true;
            txtprice3.BackColor = Color.White;
            txtprice3.Enabled = true;
            txtprice3.BackColor = Color.White;
            txtmrp.Enabled = true;
            txtmrp.BackColor = Color.White;
            cmbCGST.Enabled = true;
            cmbCGST.BackColor = Color.White;
            cmbtax.Enabled = true;
            cmbtax.BackColor = Color.White;
            cmbGroup.Enabled = true;
            cmbGroup.BackColor = Color.White;
            cmbSubGroup.Enabled = true;
            cmbSubGroup.BackColor = Color.White;
            txtsupplier.Enabled = true;
            txtsupplier.BackColor = Color.White;
            cmbGodown.Enabled = true;
            cmbGodown.BackColor = Color.White;
            txtoplc.Enabled = true;
            txtoplc.BackColor = Color.White;
            txtopstock.Enabled = true;
            txtopstock.BackColor = Color.White;
            txtmaxlevel.Enabled = true;
            txtmaxlevel.BackColor = Color.White;
            txtminlevel.Enabled = true;
            txtminlevel.BackColor = Color.White;
            txtreorder.Enabled = true;
            txtreorder.BackColor = Color.White;
            txtlocation.Enabled = true;
            txtlocation.BackColor = Color.White;
            txtdescription.Enabled = true;
            txtdescription.BackColor = Color.White;
            txthsncode.Enabled = true;
            txthsncode.BackColor = Color.White;
            txtScheduleNo.Enabled = true;
            txtScheduleNo.BackColor = Color.White;

        }
        public void ClearFields()
        {
            txtitemname.Text = "";
            //cmbunit.Text = "";
            txtpprice.Text = "";
            txtlandcost.Text = "";
            txtprice1.Text = "";
            txtprice2.Text = "";
            txtprice3.Text = "";
            txtprice3.Text = "";
            //cmbtax.Text = "";
            txtoplc.Text = "";
            txtoplc.Text = "";
            txtmaxlevel.Text = "";
            txtminlevel.Text = "";
            txtreorder.Text = "";
            txtlocation.Text = "";
            txtdescription.Text = "";
            cmbtax.Text = "";
            cmbCGST.Text = "";
            cmbunit.Text = "";
            txtsupplier.Text = "";
            txthsncode.Text = "";
            txtScheduleNo.Text = "";
            txtmrp.Text = "";
            txtopstock.Text = "";
            TextSTOCK.Text = "1";


        }
        public void loadvisiblebutton()
        {
            groupBox3.Visible = false;
            btnAdd.Visible = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnEdit.Visible = true;
            //btnSerach.Visible = true;
            btnDelete.Visible = true;
            btnExit.Visible = true;
            //userControl11.Visible = true;

            btnAdd.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnSearch.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnEdit.Enabled = true;
           // btnSerach.Enabled = true;
            btnDelete.Enabled = true;
            btnExit.Enabled = true;
           // userControl11.Enabled = true;
            groupBox2.Visible = true;
            btnAdd.Visible = true;
            btnPrevious.Visible = true;
            btnNext.Visible = true;
            btnSearch.Visible = true;
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            btnExit.Visible = true;

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            ClearFields();
            this.Hide();
        }

        private void FrmItemMaster_Load(object sender, EventArgs e)
        {
            if (int.Parse(FrmItemMasterSearch.val) != 1)
            {
                if (FrmItemMasterSearch.smodevalue == "1")
                {
                    DisableTextBox();
                    groupBox1.Enabled = true;
                    groupBox2.Visible = true;
                    groupBox3.Hide();
                    loadvisiblebutton();
                    grpid = int.Parse(FrmItemMasterSearch.SetValueForText1);
                    objIMDAL.ItmId = grpid;
                    dt5.Clear();
                    dt5 = objIMDAL.FetchItemMaster();
                    if (dt5.Rows.Count > 0)
                    {
                        txtitemname.Text = dt5.Rows[0]["ItemName"].ToString();
                        txtScheduleNo.Text = dt5.Rows[0]["SchedNo"].ToString();
                        txthsncode.Text = dt5.Rows[0]["HSNNo"].ToString();
                        cmbunit.Text = dt5.Rows[0]["Unit"].ToString();
                        Unitlbl.Text = dt5.Rows[0]["UnitId"].ToString();
                        SGSTlbl.Text = dt5.Rows[0]["SGSTId"].ToString();
                        CGSTlbl.Text = dt5.Rows[0]["CGSTId"].ToString();
                        txtpprice.Text = dt5.Rows[0]["PPrice"].ToString();
                        txtlandcost.Text = dt5.Rows[0]["LandCost"].ToString();
                        txtprice1.Text = dt5.Rows[0]["Price1"].ToString();
                        txtprice2.Text = dt5.Rows[0]["Price2"].ToString();
                        txtprice3.Text = dt5.Rows[0]["Price3"].ToString();
                        txtmrp.Text = dt5.Rows[0]["MRP"].ToString();
                        cmbtax.Text = dt5.Rows[0]["SGST"].ToString();
                        cmbCGST.Text = dt5.Rows[0]["CGST"].ToString();
                        txtdescription.Text = dt5.Rows[0]["Description"].ToString();
                        TextSTOCK.Text = dt5.Rows[0]["Stock"].ToString();
                        cmbGroup.SelectedItem = dt5.Rows[0]["ItmGpName"].ToString();
                        cmbSubGroup.SelectedItem = dt5.Rows[0]["SubGrp"].ToString();
                        txtsupplier.Text = dt5.Rows[0]["Supplier"].ToString();
                        txtopstock.Text = dt5.Rows[0]["OPStock"].ToString();
                        txtoplc.Text = dt5.Rows[0]["OPLC"].ToString();
                        txtmaxlevel.Text = dt5.Rows[0]["MaxLevel"].ToString();
                        txtreorder.Text = dt5.Rows[0]["ReOrder"].ToString();
                        txtminlevel.Text = dt5.Rows[0]["MinLevel"].ToString();
                        txtlocation.Text = dt5.Rows[0]["Location"].ToString();
                        cmbGodown.SelectedItem = dt5.Rows[0]["Godown"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Couldnt find the selected Item..!!");
                    }

                }
                else if (FrmItemMasterSearch.smodevalue == "2")
                {
                    check = 2;
                    EnableTextBox();
                    groupBox1.Enabled = true;
                    groupBox2.Hide();
                    groupBox3.Visible = true;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    grpid = int.Parse(FrmItemMasterSearch.SetValueForText1);
                    objIMDAL.ItmId = grpid;
                    dt5.Clear();
                    dt5 = objIMDAL.FetchItemMaster();
                    if (dt5.Rows.Count > 0)
                    {
                        txtitemname.Text = dt5.Rows[0]["ItemName"].ToString();
                        txtScheduleNo.Text = dt5.Rows[0]["SchedNo"].ToString();
                        txthsncode.Text = dt5.Rows[0]["HSNNo"].ToString();
                        cmbunit.Text = dt5.Rows[0]["Unit"].ToString();
                        Unitlbl.Text = dt5.Rows[0]["UnitId"].ToString();
                        SGSTlbl.Text = dt5.Rows[0]["SGSTId"].ToString();
                        CGSTlbl.Text = dt5.Rows[0]["CGSTId"].ToString();
                        txtpprice.Text = dt5.Rows[0]["PPrice"].ToString();
                        txtlandcost.Text = dt5.Rows[0]["LandCost"].ToString();
                        txtprice1.Text = dt5.Rows[0]["Price1"].ToString();
                        txtprice2.Text = dt5.Rows[0]["Price2"].ToString();
                        txtprice3.Text = dt5.Rows[0]["Price3"].ToString();
                        txtmrp.Text = dt5.Rows[0]["MRP"].ToString();
                        cmbtax.Text = dt5.Rows[0]["SGST"].ToString();
                        cmbCGST.Text = dt5.Rows[0]["CGST"].ToString();
                        txtdescription.Text = dt5.Rows[0]["Description"].ToString();
                        TextSTOCK.Text = dt5.Rows[0]["Stock"].ToString();
                        cmbGroup.SelectedItem = dt5.Rows[0]["ItmGpName"].ToString();
                        cmbSubGroup.SelectedItem = dt5.Rows[0]["SubGrp"].ToString();
                        txtsupplier.Text = dt5.Rows[0]["Supplier"].ToString();
                        txtopstock.Text = dt5.Rows[0]["OPStock"].ToString();
                        txtoplc.Text = dt5.Rows[0]["OPLC"].ToString();
                        txtmaxlevel.Text = dt5.Rows[0]["MaxLevel"].ToString();
                        txtreorder.Text = dt5.Rows[0]["ReOrder"].ToString();
                        txtminlevel.Text = dt5.Rows[0]["MinLevel"].ToString();
                        txtlocation.Text = dt5.Rows[0]["Location"].ToString();
                        cmbGodown.SelectedItem = dt5.Rows[0]["Godown"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Couldnt find the selected Item..!!");
                    }
                }
            }
        }

        public void FetchItemGroup()
        {
            dt1.Clear();
            dt1 = objIMDAL.FetchItemGroup();
            cmbGroup.DataSource = dt1;
            cmbGroup.DisplayMember = "ItmGpName";
            cmbGroup.ValueMember = "ItmGpId";

            FetchItemSubGroup();

            grpmain = 1;
            //  cmbGrpUnder.Items.Insert(0, new ListItem("Primary Group", "0"));
        }

        private void FetchItemSubGroup()
        {
            dt2.Clear();
            objIMDAL.ItmGpId = int.Parse(cmbGroup.SelectedValue.ToString());
            dt2 = objIMDAL.FetchItemSubGroup();

            cmbSubGroup.DataSource = dt2;
            cmbSubGroup.ValueMember = "ItmGpId";
            cmbSubGroup.DisplayMember = "ItmGpName";
            
            //dp_SubGroup.Items.Insert(0, new ListItem("", "0"));

        }

        private void FetchGoDown()
        {
            dt.Clear();
            //objIMDAL.BrId = int.Parse(Session["BranchId"].ToString());
            //objIMDAL.DivId = int.Parse(Session["DivisionId"].ToString());
            //objIMDAL.CompId = int.Parse(Session["CompanyId"].ToString());
            dt = objIMDAL.FetchGoDown();
            if (dt.Rows.Count > 0)
            {
                cmbGodown.DataSource = dt;
                cmbGodown.ValueMember = "GdwId";
                cmbGodown.DisplayMember = "Godown";
                //cmbGodown.DataBind();
                    // dp_Godown.Items.Insert(0, new ListItem("-Select-", "0"));
                }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
            EnableTextBox();
            groupBox1.Enabled = true;
            groupBox2.Hide();
            groupBox3.Visible = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            txtitemname.Focus();
            check = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtitemname.Text != "" && cmbCGST.Text != "" && cmbtax.Text != "" && cmbunit.Text != "")
            {
                if (check == 1)
                {
                    objIMDAL.ItemName = txtitemname.Text;
                    objIMDAL.SchedNo = txtScheduleNo.Text;
                    objIMDAL.HSNNo = txthsncode.Text;
                    objIMDAL.UnitId = int.Parse(Unitlbl.Text);
                    objIMDAL.PPrice = !string.IsNullOrEmpty(txtpprice.Text) ? decimal.Parse(txtpprice.Text) : 0;
                    objIMDAL.LandCost = !string.IsNullOrEmpty(txtlandcost.Text) ? decimal.Parse(txtlandcost.Text) : 0;
                    objIMDAL.Price1 = !string.IsNullOrEmpty(txtprice1.Text) ? decimal.Parse(txtprice1.Text) : 0;
                    objIMDAL.Price2 = !string.IsNullOrEmpty(txtprice2.Text) ? decimal.Parse(txtprice2.Text) : 0;
                    objIMDAL.Price3 = !string.IsNullOrEmpty(txtprice3.Text) ? decimal.Parse(txtprice3.Text) : 0;
                    objIMDAL.MRP = !string.IsNullOrEmpty(txtmrp.Text) ? decimal.Parse(txtmrp.Text) : 0;
                    objIMDAL.SGST = float.Parse(cmbtax.Text);
                    objIMDAL.SGSTId = int.Parse(SGSTlbl.Text);
                    objIMDAL.CGSTId = int.Parse(CGSTlbl.Text);
                    objIMDAL.CGST = float.Parse(cmbCGST.Text);
                    objIMDAL.Description = txtdescription.Text;

                    objIMDAL.Stock = int.Parse(TextSTOCK.Text);
                    objIMDAL.ItmGpId = int.Parse(cmbGroup.SelectedValue.ToString());
                    objIMDAL.ItmMGpId = int.Parse(cmbSubGroup.SelectedValue.ToString());
                    objIMDAL.Supplier = txtsupplier.Text;
                    objIMDAL.OPStock = !string.IsNullOrEmpty(txtopstock.Text) ? float.Parse(txtopstock.Text) : 0;
                    objIMDAL.OPLC = !string.IsNullOrEmpty(txtoplc.Text) ? float.Parse(txtoplc.Text) : 0;
                    objIMDAL.MaxLevel = (int)(!string.IsNullOrEmpty(txtmaxlevel.Text) ? float.Parse(txtmaxlevel.Text) : 0);
                    objIMDAL.ReOrder = (int)(!string.IsNullOrEmpty(txtreorder.Text) ? float.Parse(txtreorder.Text) : 0);
                    objIMDAL.MinLevel = (int)(!string.IsNullOrEmpty(txtminlevel.Text) ? float.Parse(txtminlevel.Text) : 0);
                    objIMDAL.Location = txtlocation.Text;
                    objIMDAL.GdwId = int.Parse(cmbGodown.SelectedValue.ToString());
                    objIMDAL.FyId = 1;
                    objIMDAL.BrId = 1;
                    objIMDAL.CompId = 1;
                    dt4 = objIMDAL.InsertItem();

                    MessageBox.Show("Items Saved Successfully..!!");
                }
                else if(check==2)
                {
                    objIMDAL.ItmId = grpid;
                    objIMDAL.ItemName = txtitemname.Text;
                    objIMDAL.SchedNo = txtScheduleNo.Text;
                    objIMDAL.HSNNo = txthsncode.Text;
                    objIMDAL.UnitId = int.Parse(Unitlbl.Text);
                    objIMDAL.PPrice = !string.IsNullOrEmpty(txtpprice.Text) ? decimal.Parse(txtpprice.Text) : 0;
                    objIMDAL.LandCost = !string.IsNullOrEmpty(txtlandcost.Text) ? decimal.Parse(txtlandcost.Text) : 0;
                    objIMDAL.Price1 = !string.IsNullOrEmpty(txtprice1.Text) ? decimal.Parse(txtprice1.Text) : 0;
                    objIMDAL.Price2 = !string.IsNullOrEmpty(txtprice2.Text) ? decimal.Parse(txtprice2.Text) : 0;
                    objIMDAL.Price3 = !string.IsNullOrEmpty(txtprice3.Text) ? decimal.Parse(txtprice3.Text) : 0;
                    objIMDAL.MRP = !string.IsNullOrEmpty(txtmrp.Text) ? decimal.Parse(txtmrp.Text) : 0;
                    objIMDAL.SGST = float.Parse(cmbtax.Text);
                    objIMDAL.SGSTId = int.Parse(SGSTlbl.Text);
                    objIMDAL.CGSTId = int.Parse(CGSTlbl.Text);
                    objIMDAL.CGST = float.Parse(cmbCGST.Text);
                    objIMDAL.Description = txtdescription.Text;

                    objIMDAL.Stock = int.Parse(TextSTOCK.Text);
                    objIMDAL.ItmGpId = int.Parse(cmbGroup.SelectedValue.ToString());
                    objIMDAL.ItmMGpId = int.Parse(cmbSubGroup.SelectedValue.ToString());
                    objIMDAL.Supplier = txtsupplier.Text;
                    objIMDAL.OPStock = !string.IsNullOrEmpty(txtopstock.Text) ? float.Parse(txtopstock.Text) : 0;
                    objIMDAL.OPLC = !string.IsNullOrEmpty(txtoplc.Text) ? float.Parse(txtoplc.Text) : 0;
                    objIMDAL.MaxLevel = (int)(!string.IsNullOrEmpty(txtmaxlevel.Text) ? float.Parse(txtmaxlevel.Text) : 0);
                    objIMDAL.ReOrder = (int)(!string.IsNullOrEmpty(txtreorder.Text) ? float.Parse(txtreorder.Text) : 0);
                    objIMDAL.MinLevel = (int)(!string.IsNullOrEmpty(txtminlevel.Text) ? float.Parse(txtminlevel.Text) : 0);
                    objIMDAL.Location = txtlocation.Text;
                    objIMDAL.GdwId = int.Parse(cmbGodown.SelectedValue.ToString());
                    objIMDAL.FyId = 1;
                    objIMDAL.BrId = 1;
                    objIMDAL.CompId = 1;
                    dt4.Clear();
                    dt4 = objIMDAL.UpdateItem();

                    MessageBox.Show("Items Updated Successfully..!!");

                }

                ClearFields();
                DisableTextBox();
                loadvisiblebutton();
                Disablelistbox();
                btnAdd.Focus();
            }
            else
            {
                MessageBox.Show("Mandatory Fields cant be blank..!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            DisableTextBox();
            loadvisiblebutton();
            Disablelistbox();
            groupBox2.Visible = true;
            btnAdd.Focus();
        }
        
        public void FetchUnit()
        {
            ListboxUnit.Show();
            ListboxUnit.Items.Clear();
            dt = objIMDAL.FetchUnit();
            ListboxUnit.DisplayMember = "Unit";
            ListboxUnit.ValueMember = "UnitId";
            

            // set the DataSource to the DataTable 
            ListboxUnit.DataSource = dt;
            ListboxUnit.Focus();
        }

        public void FetchSupplier()
        {
            ListboxSupplier.Show();
            ListboxSupplier.Items.Clear();
            dt = objIMDAL.FetchSupplierList();
            ListboxSupplier.DisplayMember = "Head";
            ListboxSupplier.ValueMember = "Head";

            // set the DataSource to the DataTable 
            ListboxSupplier.DataSource = dt;
            ListboxSupplier.Focus();
        }

        public void FetchTax()
        {
            ListboxTax.Show();
            ListboxTax.Items.Clear();
            dt = objIMDAL.FetchSalesTax();
            ListboxTax.DisplayMember = "Head";
            ListboxTax.ValueMember = "TaxPer";

            // set the DataSource to the DataTable 
            ListboxTax.DataSource = dt;
            ListboxTax.Focus();
        }

        private void cmbunit_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                FetchUnit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListboxUnit_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {

                DataRowView drv = (DataRowView)ListboxUnit.SelectedItem;
                String valueOfItem = drv["Unit"].ToString();
                String idofItem = drv["UnitId"].ToString();
                cmbunit.Text = valueOfItem;
                Unitlbl.Text = idofItem;

                ListboxUnit.Hide();
                txtpprice.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListboxUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                ListboxUnit_MouseDoubleClick(null, null);
        }

        private void txtsupplier_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                FetchSupplier();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListboxSupplier_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)ListboxSupplier.SelectedItem;
                String valueOfItem = drv["Head"].ToString();
                txtsupplier.Text = valueOfItem;

                ListboxSupplier.Hide();
                txtopstock.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtsupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                ListboxSupplier_MouseDoubleClick(null, null);
            txtopstock.Focus();
        }

        private void cmbtax_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                ListboxSGST.Show();
                ListboxSGST.Items.Clear();
                dt3 = objIMDAL.FetchSalesTax();
                ListboxSGST.DisplayMember = "Head";
                ListboxSGST.ValueMember = "TaxPer";

                // set the DataSource to the DataTable 
                ListboxSGST.DataSource = dt3;
                ListboxSGST.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListboxTax_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {

                DataRowView drv = (DataRowView)ListboxTax.SelectedItem;
                String valueOfItem = drv["TaxPer"].ToString();
                String idofItem = drv["TaxId"].ToString();
                cmbCGST.Text = valueOfItem;
                CGSTlbl.Text=idofItem;

                ListboxTax.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListboxTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                ListboxTax_MouseDoubleClick(null, null);
        }

       

        private void cmbGroup_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (grpmain==1)
            {
                FetchItemSubGroup();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            smode = "1";
            FrmItemMasterSearch frmmsrch = new FrmItemMasterSearch();
            frmmsrch.Show();
            this.Hide();
        }

        private void txtopstock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextSTOCK.Text = txtopstock.Text;
                txtoplc.Focus();
            }
        }

        private void cmbCGST_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                FetchTax();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListboxSGST_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {

                DataRowView drv = (DataRowView)ListboxSGST.SelectedItem;
                String valueOfItem = drv["TaxPer"].ToString();
                String idofItem = drv["TaxId"].ToString();
                cmbtax.Text = valueOfItem;
                SGSTlbl.Text = idofItem;

                ListboxSGST.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListboxSGST_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                ListboxSGST_MouseDoubleClick(null, null);
        }

        private void txtScheduleNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txthsncode.Focus();
            }
        }

        private void txthsncode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbunit.Focus();
            }
        }

        private void cmbunit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpprice.Focus();
            }
        }

        private void txtpprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtlandcost.Focus();
            }
        }

        private void txtlandcost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtprice1.Focus();
            }
        }

        private void txtprice1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtprice2.Focus();
            }
        }

        private void txtprice2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtprice3.Focus();
            }
        }

        private void txtprice3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtmrp.Focus();
            }
        }

        private void txtoplc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtmaxlevel.Focus();
            }
        }

        private void txtmaxlevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtreorder.Focus();
            }
        }

        private void txtreorder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtminlevel.Focus();
            }
        }

        private void txtminlevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtlocation.Focus();
            }
        }

        private void txtlandcost_Leave(object sender, EventArgs e)
        {
            
            if (txtpprice.Text != "")
            {
                int lc = int.Parse(txtlandcost.Text);
                int pp = int.Parse(txtpprice.Text);
                if (txtlandcost.Text == "")
                {
                    txtlandcost.Text = txtpprice.Text;
                }
                else
                {
                    if (pp > lc)
                    {
                        MessageBox.Show("LC SHOULD >=PURCHASE PRICE");
                        txtlandcost.Text = "";
                        txtlandcost.Focus();
                    }
                }
            }
        }

        private void txtprice1_Leave(object sender, EventArgs e)
        {
            
            if (txtlandcost.Text != "" && txtprice1.Text != "")
            {
                int p = int.Parse(txtprice1.Text);
                int lc = int.Parse(txtlandcost.Text);
                if (p < lc)
                {
                    txtprice1.Text = "";
                    MessageBox.Show("PRICE SHOULD > or = TO  LANDING COST");
                    txtprice1.Focus();
                }
            }
        }

        private void txtmrp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbtax.Focus();
            }
        }

        private void cmbtax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCGST.Focus();
            }
        }

        private void cmbCGST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtdescription.Focus();
            }
        }

        private void txtdescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbGroup.Focus();
            }
        }

        private void cmbGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbSubGroup.Focus();
            }
        }

        private void txtlocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbGodown.Focus();
            }
        }

        private void cmbGodown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void txtitemname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtScheduleNo.Focus();
            }
        }

        private void txtprice2_Leave(object sender, EventArgs e)
        {
            
            if (txtlandcost.Text != "" && txtprice2.Text != "")
            {
                int p = int.Parse(txtprice2.Text);
                int lc = int.Parse(txtlandcost.Text);
                if (p < lc)
                {
                    txtprice2.Text = "";
                    MessageBox.Show("PRICE SHOULD > or = TO LANDING COST");
                    txtprice2.Focus();
                }
            }
        }

        private void txtprice3_Leave(object sender, EventArgs e)
        {
            
            if (txtlandcost.Text != "" && txtprice3.Text != "")
            {
                int p = int.Parse(txtprice3.Text);
                int lc = int.Parse(txtlandcost.Text);
                if (p < lc)
                {
                    txtprice3.Text = "";
                    MessageBox.Show("PRICE SHOULD > or = TO LANDING COST");
                    txtprice3.Focus();
                }
            }
        }

        private void txtmrp_Leave(object sender, EventArgs e)
        {
            
            if (txtlandcost.Text != "" && txtmrp.Text != "")
            {
                int mrp = int.Parse(txtmrp.Text);
                int lc = int.Parse(txtlandcost.Text);
                if (mrp < lc)
                {
                    txtmrp.Text = "";
                    MessageBox.Show("LC SHOULD >=PURCHASE PRICE");
                    txtmrp.Focus();
                }
            }
        }

        private void txtreorder_Leave(object sender, EventArgs e)
        {
            
            if (txtreorder.Text != "" && txtmaxlevel.Text != "")
            {
                int ro = int.Parse(txtreorder.Text);
                int ml = int.Parse(txtmaxlevel.Text);
                if (ro > ml)
                {
                    MessageBox.Show("Check your Maximum level");
                    txtreorder.Focus();
                }
            }
        }

        private void ListboxUnit_Leave(object sender, EventArgs e)
        {
            ListboxUnit.Visible = false;
        }

        private void ListboxSGST_Leave(object sender, EventArgs e)
        {
            ListboxSGST.Visible = false;
        }

        private void ListboxTax_Leave(object sender, EventArgs e)
        {
            ListboxTax.Visible = false;
        }

        private void ListboxSupplier_Leave(object sender, EventArgs e)
        {
            ListboxSupplier.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            smode = "2";
            check = 2;
            if (txtitemname.Text == "")
            {
                FrmItemMasterSearch frmmsrch = new FrmItemMasterSearch();
                frmmsrch.Show();
                this.Hide();
            }
            else
            {
                EnableTextBox();
                groupBox1.Enabled = true;
                groupBox2.Hide();
                groupBox3.Visible = true;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

   
    }
}
