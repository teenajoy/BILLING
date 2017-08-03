using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace BillingDAL
{
    public class GodownNameDAL
    {
        DAL objDAL = new DAL();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        private string _godwnname;
        public string godownname
        {
            get { return _godwnname; }
            set { _godwnname = value; }
        }
        private int _coid;
        public int coid
        {
            get { return _coid; }
            set { _coid = value; }
        }
        private int _brid;
        public int brid
        {
            get { return _brid; }
            set { _brid = value; }
        }
        public DataTable InsertItem()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@Godown",godownname),
            new SqlParameter("@Coid",coid),
            new SqlParameter("@brId",brid),
            
            };
            dt = objDAL.ExecuteDT("sps_insert_GodownMaster", parameter);
            return dt;
        }
        public DataTable FetchGodownMasterGrid()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@Godwnname",godownname)
            };
            dt = objDAL.ExecuteDT("FetchGodownMasterGrid", parameter);
            return dt;
        }
        public DataTable FetchGodownnamewisesearch()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@name",godownname),
           
            };
            dt = objDAL.ExecuteDT("sps_Sel_GODOWNNamewiseSearch", parameter);
            return dt;
        }
        public DataTable DeleteGododown()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@Godown",godownname),
            new SqlParameter("@Coid",coid),
            };
            dt = objDAL.ExecuteDT("sps_delete_GodownMaster", parameter);
            return dt;
        }
        public DataTable SearchGodown()
        {
            dt = objDAL.ExecuteDT("sps_Sel_GodownSearch");
            return dt;
        }
        public DataTable FetchGodownMaster()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@Godown",godownname)
            };
            dt = objDAL.ExecuteDT("FetchGodownMaster", parameter);
            return dt;
        }
       
    }
}
