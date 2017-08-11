using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BillingDAL;
using BILLING.View.Masters;
using BILLING.View.EDIT;
using BILLING.View.Stock;
using BILLING.View.Login;
using BILLING.View.Utils;
using BILLING.View.Search;

namespace BILLING.View.MDI
{
   
    public partial class FrmMDI : Form
    {
        FrmLogin objL = new FrmLogin();
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void itemMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            common.Commn = "ITEM MASTER";
            FrmItemMaster frmItem=new FrmItemMaster();
            frmItem.Show();
        }
      
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void itemGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItemGroup frmitmgrp = new FrmItemGroup();
            frmitmgrp.Show();

        }

        private void unitMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUnitMaster frmunit = new FrmUnitMaster();
            frmunit.Show();
        }

        private void createNewAccountHeadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAccountMaster frmacnt = new FrmAccountMaster();
            frmacnt.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            common.Commn = "EMPLOYEE MASTER";
            frmEmployeeRegister frmemployeemster = new frmEmployeeRegister();
            frmemployeemster.Show();
        }

        private void createNewAccountGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNewAccountGroup frmemployeemster = new FrmNewAccountGroup();
            frmemployeemster.Show();
            
        }

        private void createGodownNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            common.Commn = "GODOWN MASTER";
            FrmGodownName frmgodownname = new FrmGodownName();
            frmgodownname.Show();
        }

        private void billSeriesNOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            common.Commn = "BILL SERIES & NOS";
            FrmBillSeries frmbillseriesnos = new FrmBillSeries();
            frmbillseriesnos.Show();
        }

        private void changeItemNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            common.Commn = "CHANGE ITEM NAME";
            FrmChangeItemName frmchangeitem = new FrmChangeItemName();
            frmchangeitem.Show();
        }

        private void dATABACKUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            common.Commn = "DATA BACKUP";
            FrmBackUp frmchangeitem = new FrmBackUp();
            frmchangeitem.Show();
        }

        private void createNewTaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                 common.Commn = "CREATE TAX";
                 FrmCreateTax frmcreatetax = new FrmCreateTax();
                 frmcreatetax.Show();
        }

        private void stockEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            common.Commn = "Stock Entry";
            FrmStockEntry frmstockentry = new FrmStockEntry();
            frmstockentry.Show();
        }

        private void FrmMDI_Load(object sender, EventArgs e)
        {
            this.Text = FrmLogin.username;
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            common.Commn = "ADD USER";
            FrmAdUser frmaduser = new FrmAdUser();
            frmaduser.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
          common.Commn = "ACCOUNT HEADS LIST";
          FrmCommonSearch frmaduser = new FrmCommonSearch();
            frmaduser.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            common.Commn = "STOCK PREVIEW";
            FrmStockPreview frmSp = new FrmStockPreview();
            frmSp.Show();
        }

        private void masterItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            common.Commn = "ITEM MASTER PREVIEW";
            FrmItemMsterPreview frmSp = new FrmItemMsterPreview();
            frmSp.Show();
        }
    }
}
