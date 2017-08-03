using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace BillingDAL
{
   public class BillSeriesMasterDAL
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
        private int _coid;
        public int coid
        {
            get { return _coid; }
            set { _coid = value; }
        }
        private String _Series;
        public string series
        {
            get { return _Series; }
            set { _Series = value; }
        }
        private int _serialno;
        public int serialno
        {
            get { return _serialno; }
            set { _serialno = value; }
        }
        private String _Finyear;
        public string Finyear
        {
            get { return _Finyear; }
            set { _Finyear = value; }
        }
        private int _Estatus;
        public int Estatus
        {
            get { return _Estatus; }
            set { _Estatus = value; }
        }
        public DataTable InsertItem()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@Category",category),
            new SqlParameter("@Series",series),
            new SqlParameter("@VSerialNo",serialno),
            new SqlParameter("@Coid",coid),
            new SqlParameter("@FYCode",Finyear),
            new SqlParameter("@OEStatus",Estatus),
            
            };
            dt = objDAL.ExecuteDT("sps_insert_serailNoMaster", parameter);
            return dt;
        }
        public DataTable FetchBillSeriesMasterGrid()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@Category",category)
            };
            dt = objDAL.ExecuteDT("FetchBillSeriesMasterGrid", parameter);
            return dt;
        }
        public DataTable SearchBillSeries()
        {
            dt = objDAL.ExecuteDT("sps_Sel_BillSerialSearch");
            return dt;
        }
        public DataTable FetchBillSearch()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@Category",category),
            new SqlParameter("@Series",series)
            };
            dt = objDAL.ExecuteDT("sps_Sel_BillSearch", parameter);
            return dt;
        }
        public DataTable FetchBillSeriesMaster()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@Category",category)
            };
            dt = objDAL.ExecuteDT("FetchBillSeriesMaster", parameter);
            return dt;
        }
        public DataTable DeleteSeries()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@Category",category),
            new SqlParameter("@Series",series),
            new SqlParameter("@FYCode",Finyear),
            new SqlParameter("@OEStatus",Estatus),
            new SqlParameter("@Coid",coid),
            };
            dt = objDAL.ExecuteDT("sps_DELETE_SerielNoMaster", parameter);
            return dt;
        }
        public DataTable Update()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@Category",category),
            new SqlParameter("@Series",series),
            new SqlParameter("@Serialno",serialno),

            
            };
            dt = objDAL.ExecuteDT("sps_Update_BillSeries", parameter);
            return dt;
        }
    }
}
