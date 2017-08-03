using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BillingDAL
{
    public class ItemGroupDAL
    {
        DAL objDAL = new DAL();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        private int _ItmGpId;
        public int ItmGpId
        {
            get { return _ItmGpId; }
            set { _ItmGpId = value; }
        }

        private int _ItmMGpId;

        public int ItmMGpId
        {
            get { return _ItmMGpId; }
            set { _ItmMGpId = value; }
        }

        private string _ItmGpName;

        public string ItmGpName
        {
            get { return _ItmGpName; }
            set { _ItmGpName = value; }
        }

        private string _PrimaryGroup;
        public string PrimaryGroup
        {
            get { return _PrimaryGroup; }
            set { _PrimaryGroup = value; }
        }

        private string _Gridvalue;
        public string Gridvalue
        {
            get { return _Gridvalue; }
            set { _Gridvalue = value; }
        }

        public DataTable FetchItemGroup()
        {
            dt = objDAL.ExecuteDT("FetchItemGroup");
            return dt;
        }

        public DataTable InsertItemGroup()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@ItmGpName",ItmGpName),
            new SqlParameter("@ItmMGpId",ItmMGpId),
            new SqlParameter("@PrimaryGroup",PrimaryGroup)
    
            };
            dt = objDAL.ExecuteDT("InsertItemGroup", parameter);
            return dt;
        }

        public DataTable SearchItemGroup()
        {
            dt = objDAL.ExecuteDT("SearchItemGroup");
            return dt;
        }

        public DataTable UpdateItemGroup()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@ItmGpId",ItmGpId),
            new SqlParameter("@ItmGpName",ItmGpName),
            new SqlParameter("@ItmMGpId",ItmMGpId),
            new SqlParameter("@PrimaryGroup",PrimaryGroup)
            };
            dt = objDAL.ExecuteDT("UpdateItemGroup", parameter);
            return dt;
        }

        public DataTable FetchItemGrpGrid()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
                new SqlParameter("@Gridvalue",Gridvalue),
            };
            dt = objDAL.ExecuteDT("FetchItemGrpGrid", parameter);
            return dt;
        }
    }
}
