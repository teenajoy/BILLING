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
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace BILLING.View.Masters
{
    public partial class FrmBackUp : Form
    {
        CmpntLoginDAL objCLDAL = new CmpntLoginDAL();
        BacuUpDAL objBUDAL = new BacuUpDAL();
        public static string FYear = "";
        public static string smode = "";
        public FrmBackUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(10, 60);
            finyear();
        }
        public void finyear()
        {
            DataTable dt1 = new DataTable();
            dt1 = objCLDAL.FetchFinancialYear();
            FYear = dt1.Rows[0][1].ToString();
            Listfinyear.Items.Add(FYear);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            folderBrowserDlg.ShowNewFolderButton = false;
            DialogResult dlgResult = folderBrowserDlg.ShowDialog();
            if (dlgResult.Equals(DialogResult.OK))
            {
                TextBACKUPPATH.Text = folderBrowserDlg.SelectedPath;
                Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;
            }
        }

        private void Listfinyear_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textFinYear.Text = Listfinyear.SelectedItem.ToString();
            Listfinyear.Hide();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (textFinYear.Text != "" && TextBACKUPPATH.Text != "" && TxtID.Text != "")
            {
                string d = Convert.ToString(System.DateTime.Now.Day);
                string m = Convert.ToString(System.DateTime.Now.Month);
                string y = Convert.ToString(System.DateTime.Now.Year);
                string path = TextBACKUPPATH.Text;
                string s = (d + '-' + m + '-' + y);
              //  string path1 = path + "\"" + s + "";
                objBUDAL.path = path;
                objBUDAL.InsertItem();

            }
        
        }
    }
}
