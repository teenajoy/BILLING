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
    public partial class frmEmployeeRegister : Form
    {
        EmployeeMasterDAL objIMDAL = new EmployeeMasterDAL();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dt5 = new DataTable();
        DataTable dt6 = new DataTable();
        DataTable dt7 = new DataTable();
        int grpmain = 0;
        public static int j = 0;
        public static string smode = "";

        string grpid="";
        int check = 1;
        public frmEmployeeRegister()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(10, 60);
            loadbutton();
            ClearFields();
            DisableTextBox();
            ButtonAdd.Focus();
            ComboStatus.SelectedIndex = 0;

        }
        public void DisableTextBox()
        {
            TextEMPCODE.Enabled = false;
            TextName.Enabled = false;
            TextADDRS1.Enabled = false;
            TextADDRS2.Enabled = false;
            TextADDRS3.Enabled = false;
            TextPHNO.Enabled = false;
            TextMOBILE.Enabled = false;
            DTPDob.Enabled = false;
            Textage.Enabled = false;
            ComboDesig.Enabled = false;
            ComboDept.Enabled = false;
            Textsalary.Enabled = false;
            DTPJoin.Enabled = false;
           
            
        }
        public void loadbutton()
        {
            ButtonAdd.Visible = true;
            ButtonAdd.Enabled = true;
            ButtonPrevious.Visible = true;
            ButtonPrevious.Enabled = false;
            ButtonNext.Visible = true;
            ButtonNext.Enabled = false;
            ButtonSearch.Visible = true;
            ButtonSearch.Enabled = true;
            ButtonEdit.Visible = true;
            ButtonEdit.Enabled = true;
            ButtonDelete.Visible = true;
            ButtonDelete.Enabled = false;
            ButtonExit.Visible = true;
            ButtonExit.Enabled = true;
            button1.Visible = false;
            button3.Visible = false;

        }
        public void loadbutton1()
        {
            ButtonAdd.Visible = false;
            ButtonPrevious.Visible = false;
            ButtonNext.Visible = false;
            ButtonSearch.Visible = false;
            ButtonEdit.Visible = false;
            ButtonDelete.Visible = false;
            ButtonExit.Visible = false;
            button1.Visible = true;
            button1.Enabled = true;
            button3.Visible = true;
            button3.Enabled = true;

        }
        public void EnableTextBox()
        {
            TextEMPCODE.Enabled = true;
            TextEMPCODE.BackColor = Color.White;
            TextName.Enabled = true;
            TextName.BackColor = Color.White;
            TextADDRS1.Enabled = true;
            TextADDRS1.BackColor = Color.White;
            TextADDRS2.Enabled = true;
            TextADDRS2.BackColor = Color.White;
            TextADDRS3.Enabled = true;
            TextADDRS3.BackColor = Color.White;
            TextPHNO.Enabled = true;
            TextPHNO.BackColor = Color.White;
            TextMOBILE.Enabled = true;
            TextMOBILE.BackColor = Color.White;
            DTPDob.Enabled = true;
            DTPDob.BackColor = Color.White;
            Textage.Enabled = true;
            Textage.BackColor = Color.White;
            ComboDesig.Enabled = true;
            ComboDesig.BackColor = Color.White;
            ComboDept.Enabled = true;
            ComboDept.BackColor = Color.White;
            Textsalary.Enabled = true;
            Textsalary.BackColor = Color.White;
       

        }
        public void ClearFields()
        {
            TextEMPCODE.Text = "";
            TextName.Text = "";
            TextADDRS1.Text = "";
            TextADDRS2.Text = "";
            TextADDRS3.Text = "";
            TextPHNO.Text = "";
            TextMOBILE.Text = "";
            DTPDob.Text = "";
            Textage.Text = "";
            ComboDesig.Text = "";
            ComboDept.Text = "";
            Textsalary.Text = "";
            DTPJoin.Text = "";
           


        }
       
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
            GroupBox1.Enabled = true;
            loadbutton1();
            EnableTextBox();
            check = 1;      
            dt1 = objIMDAL.FetchDesignation();
            ComboDesig.DataSource = dt1;
            ComboDesig.DisplayMember = "Designation";
            ComboDesig.SelectedIndex = -1;
            dt2 = objIMDAL.FetchDepartment();
            ComboDept.DataSource = dt2;
            ComboDept.DisplayMember = "Department";
            ComboDept.SelectedIndex = -1;
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            if (TextName.Text != "" && ComboDesig.Text != "" && ComboDept.Text != "")
            {
                if (check == 1)
                {
                    objIMDAL.employeename = TextName.Text;
                    objIMDAL.employeeaddress1 = TextADDRS1.Text;
                    objIMDAL.employeeaddress2 = TextADDRS2.Text;
                    objIMDAL.employeeaddress3 = TextADDRS3.Text;
                    objIMDAL.employeetelno = TextPHNO.Text;
                    objIMDAL.employeemobile = TextMOBILE.Text;
                    objIMDAL.employeedob = Convert.ToDateTime(DTPDob.Text);
                    objIMDAL.employeedesignation = ComboDesig.Text;
                    objIMDAL.employeedepartment = ComboDept.Text;
                    objIMDAL.employeesalary = !string.IsNullOrEmpty(Textsalary.Text) ? float.Parse(Textsalary.Text) : 0;
                    objIMDAL.employeejoining = Convert.ToDateTime(DTPJoin.Text);

                    objIMDAL.employeestatus = ComboStatus.Text;
                    objIMDAL.coid = "1";

                    dt4 = objIMDAL.InsertItem();

                    MessageBox.Show("Items Saved Successfully..!!");
                    ClearFields();
                }
                else if (check == 2)
                {
                    objIMDAL.employeename = TextName.Text;
                    objIMDAL.employeeaddress1 = TextADDRS1.Text;
                    objIMDAL.employeeaddress2 = TextADDRS2.Text;
                    objIMDAL.employeeaddress3 = TextADDRS3.Text;
                    objIMDAL.employeetelno = TextPHNO.Text;
                    objIMDAL.employeemobile = TextMOBILE.Text;
                    objIMDAL.employeedob = Convert.ToDateTime(DTPDob.Text);
                    objIMDAL.employeedesignation = ComboDesig.Text;
                    objIMDAL.employeedepartment = ComboDept.Text;
                    objIMDAL.employeesalary = !string.IsNullOrEmpty(Textsalary.Text) ? float.Parse(Textsalary.Text) : 0;
                    objIMDAL.employeejoining = Convert.ToDateTime(DTPJoin.Text);
                    objIMDAL.employeecode = TextEMPCODE.Text;
                    objIMDAL.employeestatus = ComboStatus.Text;
                    objIMDAL.coid = "1";
                    dt4.Clear();
                    dt4 = objIMDAL.Update();

                    MessageBox.Show("Items Updated Successfully..!!");
                    GroupBox1.Enabled = false;
                    DisableTextBox();
                    loadbutton();
                    ClearFields();
                }
            }
            ClearFields();
            GroupBox1.Visible = true;
            groupBox2.Visible = true;
            loadbutton();
            //ButtonAdd.Visible = true;
            //ButtonAdd.Enabled = true;
            //ButtonPrevious.Visible = true;
            //ButtonPrevious.Enabled = false;
            //ButtonNext.Visible = true;
            //ButtonNext.Enabled = false;
            //ButtonSearch.Visible = true;
            //ButtonSearch.Enabled = true;
            //ButtonEdit.Visible = true;
            //ButtonSearch.Enabled = true;
            //ButtonEdit.Visible = true;
            //b

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GroupBox1.Enabled = false;
            DisableTextBox();
            loadbutton();
            ClearFields();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            smode = "1";
            FrmCommonSearch frmcmsrch = new FrmCommonSearch();
            frmcmsrch.Show();
            this.Hide();
        }

        private void frmEmployeeRegister_Load(object sender, EventArgs e)
        {
            if (int.Parse(FrmCommonSearch.val) == 1)
            {
                if (FrmCommonSearch.smodevalue == "1")
                {
                    EnableTextBox();
                    GroupBox1.Enabled = true;
                    groupBox2.Visible = true;
                    ButtonNext.Enabled = true;
                    ButtonPrevious.Enabled = true;
                    ButtonDelete.Enabled = true;
                    //loadvisiblebutton();
                    grpid = FrmCommonSearch.SetValueForText1.ToString();
                    int j = 0;
                    j = FrmCommonSearch.SetValueForCount;
                    objIMDAL.employeecode = grpid;
                    dt5.Clear();
                    dt5 = objIMDAL.FetchEmployeeMaster();
                    if (dt5.Rows.Count > 0)
                    {
                        TextEMPCODE.Text = dt5.Rows[0]["EmpCode"].ToString();
                        TextName.Text = dt5.Rows[0]["EmpName"].ToString();
                        TextADDRS1.Text = dt5.Rows[0]["Add1"].ToString();
                        TextADDRS2.Text = dt5.Rows[0]["Add2"].ToString();
                        TextADDRS3.Text = dt5.Rows[0]["Add3"].ToString();
                        TextPHNO.Text = dt5.Rows[0]["PhNo"].ToString();
                        TextMOBILE.Text = dt5.Rows[0]["MobileNo"].ToString();
                        DTPDob.Text = dt5.Rows[0]["DOB"].ToString();
                        ComboDesig.Text = dt5.Rows[0]["Designation"].ToString();
                        ComboDept.Text = dt5.Rows[0]["Department"].ToString();
                        Textsalary.Text = dt5.Rows[0]["Salary"].ToString();
                        DTPJoin.Text = dt5.Rows[0]["DOJ"].ToString();
                        DTPRelive.Text = dt5.Rows[0]["DOL"].ToString();
                        ComboStatus.Text = dt5.Rows[0]["Status"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Couldnt find the selected Item..!!");
                    }
                }
                else if (FrmCommonSearch.smodevalue == "2")
                {
                    check = 2;
                    EnableTextBox();
                    GroupBox1.Enabled = true;
                    //button3.Enabled = true;
                    //button1.Enabled = true;
                    //button1.Visible = true;
                    //button3.Visible = true;
                   // groupBox2.Hide();
                    ButtonDelete.Enabled = true;
                    ButtonNext.Enabled = true;
                    ButtonPrevious.Enabled = true;
                    grpid = FrmCommonSearch.SetValueForText1.ToString();
                    int j = 0;
                    j = FrmCommonSearch.SetValueForCount;
                    objIMDAL.employeecode = grpid;
                    dt5.Clear();
                    dt5 = objIMDAL.FetchEmployeeMaster();
                    if (dt5.Rows.Count > 0)
                    {
                        TextEMPCODE.Text = dt5.Rows[0]["EmpCode"].ToString();
                        TextName.Text = dt5.Rows[0]["EmpName"].ToString();
                        TextADDRS1.Text = dt5.Rows[0]["Add1"].ToString();
                        TextADDRS2.Text = dt5.Rows[0]["Add2"].ToString();
                        TextADDRS3.Text = dt5.Rows[0]["Add3"].ToString();
                        TextPHNO.Text = dt5.Rows[0]["PhNo"].ToString();
                        TextMOBILE.Text = dt5.Rows[0]["MobileNo"].ToString();
                        DTPDob.Text = dt5.Rows[0]["DOB"].ToString();
                        ComboDesig.Text = dt5.Rows[0]["Designation"].ToString();
                        ComboDept.Text = dt5.Rows[0]["Department"].ToString();
                        Textsalary.Text = dt5.Rows[0]["Salary"].ToString();
                        DTPJoin.Text = dt5.Rows[0]["DOJ"].ToString();
                        DTPRelive.Text = dt5.Rows[0]["DOL"].ToString();
                        ComboStatus.Text = dt5.Rows[0]["Status"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Couldnt find the selected Item..!!");
                    }
                    GroupBox1.Enabled = true;
                   // loadbutton1();
                    button1.Visible = true;
                    button3.Visible = true;
                    ButtonAdd.Enabled = true;
                    ButtonPrevious.Visible = true;
                    ButtonNext.Visible = true;
                    ButtonSearch.Visible = false;
                    ButtonEdit.Visible = false;
                    ButtonDelete.Visible = true;
                    ButtonExit.Visible = true;
                    EnableTextBox();
                }
                else
                {
                    GroupBox1.Visible = true;
                    groupBox2.Visible = true;
                }
               
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            smode = "2";
            check = 2;
            if (TextName.Text == "")
            {
                FrmCommonSearch frmmsrch = new FrmCommonSearch();
                frmmsrch.Show();
                this.Hide();
            }
            else
            {
                GroupBox1.Enabled = true;
                loadbutton1();
                EnableTextBox();
               
            }

           
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            dt6.Clear();
            dt6 = objIMDAL.SearchEmployee();
            if(j<dt6.Rows.Count-1)
            {
                j++;
                TextEMPCODE.Text = dt6.Rows[j]["EmpCode"].ToString();
                TextName.Text = dt6.Rows[j]["EmpName"].ToString();
                TextADDRS1.Text = dt6.Rows[j]["Add1"].ToString();
                TextADDRS2.Text = dt6.Rows[j]["Add2"].ToString();
                TextADDRS3.Text = dt6.Rows[j]["Add3"].ToString();
                TextPHNO.Text = dt6.Rows[j]["PhNo"].ToString();
                TextMOBILE.Text = dt6.Rows[j]["MobileNo"].ToString();
                DTPDob.Text = dt6.Rows[j]["DOB"].ToString();
                ComboDesig.Text = dt6.Rows[j]["Designation"].ToString();
                ComboDept.Text = dt6.Rows[j]["Department"].ToString();
                Textsalary.Text = dt6.Rows[j]["Salary"].ToString();
                DTPJoin.Text = dt6.Rows[j]["DOJ"].ToString();
                DTPRelive.Text = dt6.Rows[j]["DOL"].ToString();
                ComboStatus.Text = dt6.Rows[j]["Status"].ToString();

            }
            else
            {
                MessageBox.Show("No Next Record..!!");
            }
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            dt7.Clear();
            dt7 = objIMDAL.SearchEmployee();
            if (j < dt7.Rows.Count && j != 0)
            {
                j--;
                
                TextEMPCODE.Text = dt7.Rows[j]["EmpCode"].ToString();
                TextName.Text = dt7.Rows[j]["EmpName"].ToString();
                TextADDRS1.Text = dt7.Rows[j]["Add1"].ToString();
                TextADDRS2.Text = dt7.Rows[j]["Add2"].ToString();
                TextADDRS3.Text = dt7.Rows[j]["Add3"].ToString();
                TextPHNO.Text = dt7.Rows[j]["PhNo"].ToString();
                TextMOBILE.Text = dt7.Rows[j]["MobileNo"].ToString();
                DTPDob.Text = dt7.Rows[j]["DOB"].ToString();
                ComboDesig.Text = dt7.Rows[j]["Designation"].ToString();
                ComboDept.Text = dt7.Rows[j]["Department"].ToString();
                Textsalary.Text = dt7.Rows[j]["Salary"].ToString();
                DTPJoin.Text = dt7.Rows[j]["DOJ"].ToString();
                DTPRelive.Text = dt7.Rows[j]["DOL"].ToString();
                ComboStatus.Text = dt7.Rows[j]["Status"].ToString();

            }
            else
            {
                MessageBox.Show("No Previous Record..!!");
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            ClearFields();
            this.Hide();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            objIMDAL.employeecode= TextEMPCODE.Text;
            objIMDAL.coid = "1";

            DialogResult dr = MessageBox.Show("Are you sure to delete row?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                DataTable dt6 = new DataTable();
                dt6 = objIMDAL.DeleteEmployee();
                MessageBox.Show("Record Deleted..!!");
                ClearFields();
            }
            else if (dr == DialogResult.No)
            {
                ClearFields();
            }
        }

        private void General_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    this.GetNextControl(ActiveControl, true).Focus();
                }
            }
        }

        private void TextName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextADDRS1.Focus();
            }
        }

        private void TextADDRS1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextADDRS2.Focus();
            }
        }

        private void TextADDRS2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextADDRS3.Focus();
            }
        }

        private void TextADDRS3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextPHNO.Focus();
            }
        }

        private void TextPHNO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextMOBILE.Focus();
            }
        }

        private void TextMOBILE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DTPDob.Focus();
            }
        }

        private void DTPDob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ComboDesig.Focus();
            }
        }

        private void ComboDesig_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ComboDept.Focus();
            }
        }

        private void ComboDept_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Textsalary.Focus();
            }
        }

        private void Textsalary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ComboStatus.Focus();
            }
        }

        private void ComboStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DTPJoin.Focus();
            }
        }

        private void DTPJoin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DTPRelive.Focus();
            }
        }
    }
}
