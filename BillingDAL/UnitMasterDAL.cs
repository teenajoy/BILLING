using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BillingDAL
{
    public class UnitMasterDAL
    {
        DAL objDAL = new DAL();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        private int _UnitId;
        public int UnitId
        {
            get { return _UnitId; }
            set { _UnitId = value; }
        }

        private string _SubUnit;

        public string SubUnit
        {
            get { return _SubUnit; }
            set { _SubUnit = value; }
        }

        private string _Unit;

        public string Unit
        {
            get { return _Unit; }
            set { _Unit = value; }
        }

        private float _ConFactor;

        public float ConFactor
        {
            get { return _ConFactor; }
            set { _ConFactor = value; }
        }

        private string _GridUnit;

        public string GridUnit
        {
            get { return _GridUnit; }
            set { _GridUnit = value; }
        }

        public DataTable InsertUnit()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@Unit",Unit),
            new SqlParameter("@SubUnit",SubUnit),
            new SqlParameter("@ConFactor",ConFactor)
    
            };
            dt = objDAL.ExecuteDT("InsertUnit", parameter);
            return dt;
        }

        public DataTable SearchUnitMaster()
        {
            dt = objDAL.ExecuteDT("SearchUnitMaster");
            return dt;
        }

        public DataTable FetchUnitMasterGrid()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@GridUnit",GridUnit)
            };
            dt = objDAL.ExecuteDT("FetchUnitMasterGrid", parameter);
            return dt;
        }

        public DataTable FetchUnitMaster()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@UnitId",UnitId)
            };
            dt = objDAL.ExecuteDT("FetchUnitMaster", parameter);
            return dt;
        }
    }
}
