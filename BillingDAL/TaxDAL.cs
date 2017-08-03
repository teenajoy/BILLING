using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BillingDAL;
namespace BillingDAL
{
    
  public  class TaxDAL
    {
        DAL objDAL = new DAL();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        private string _category;
        public string category
        {
            get { return _category; }
            set { _category = value; }
        }
        private string _taxtype;
        public string taxtype
        {
            get { return _taxtype; }
            set { _taxtype = value; }
        }
        private decimal _taxper;
        public decimal taxpet
        {
            get { return _taxper; }
            set { _taxper = value; }
        }
        private string _amid;
        public string amid
        {
            get { return _amid; }
            set { _amid = value; }
        }
        private string _head;
        public string head
        {
            get { return _head; }
            set { _head = value; }
        }
        private string _taxcategory;
        public string taxcategory
        {
            get { return _taxcategory; }
            set { _taxcategory = value; }
        }
        private string _active;
        public string active
        {
            get { return _active; }
            set { _active = value; }
        }
        private string _fyid;
        public string fyid
        {
            get { return _fyid; }
            set { _fyid = value; }
        }
        private int _compid;
        public int compid
        {
            get { return _compid; }
            set { _compid = value; }
        }
        private int _taxid;
        public int taxid
        {
            get { return _taxid; }
            set { _taxid = value; }
        }
        private string _Gridval;
        public string Gridval
        {
            get { return _Gridval; }
            set { _Gridval = value; }
        }
        public DataTable SearchGroupMaster()
        {
            dt = objDAL.ExecuteDT("sps_Sel_NAME_GroupMaster");
            return dt;
        }
        public DataTable SearchTAX()
        {
            dt = objDAL.ExecuteDT("sps_Sel_TAX");
            return dt;
        }
        public DataTable InsertItem()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@Category",category),
            new SqlParameter("@TaxType",taxtype),
            new SqlParameter("@TaxPer",taxpet),
            new SqlParameter("@groupName",amid),
            new SqlParameter("@AccountHead1",head),
            new SqlParameter("@TaxCategory",taxcategory),
            new SqlParameter("@Coid",compid),
            new SqlParameter("@FYCode",fyid),
            new SqlParameter("@OEStatus",compid),
            
            };
            dt = objDAL.ExecuteDT("sps_insert_TaxMaster", parameter);
            return dt;
        }
        public DataTable UpdateItem()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            
            new SqlParameter("@Category",head),
             new SqlParameter("@Series",active),
            
            };
            dt = objDAL.ExecuteDT("sps_Update_TAX", parameter);
            return dt;
        }
        public DataTable FetchBillSearch()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@AccountHead",head),
          
            };
            dt = objDAL.ExecuteDT("sps_Sel_TaxSearch", parameter);
            return dt;

        }
        public DataTable SearchTax()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@Coid",compid),
            new SqlParameter("@FYCode",fyid),
            };
            dt = objDAL.ExecuteDT("sps_select_TaxMasterSearch", parameter);
            return dt;
        }
        public DataTable FetchTAXMasterGrid()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@Gridval",Gridval),
            new SqlParameter("@Coid",compid),
            new SqlParameter("@FYCode",fyid),
            };
            dt = objDAL.ExecuteDT("FetchTAXMasterGrid", parameter);
            return dt;
        }
        public DataTable FetchTAXMaster()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@Taxid",taxid)
            };
            dt = objDAL.ExecuteDT("FetchTAXMaster", parameter);
            return dt;
        }
    }

}
