using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BillingDAL
{
    public class AccountGroupDAL
    {
        DAL objDAL = new DAL();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        private int _AgId;
        public int AgId
        {
            get { return _AgId; }
            set { _AgId = value; }
        }

        private int _AmgId;

        public int AmgId
        {
            get { return _AmgId; }
            set { _AmgId = value; }
        }

        private string _AgName;

        public string AgName
        {
            get { return _AgName; }
            set { _AgName = value; }
        }

        public DataTable FetchAccountGroup()
        {
            dt = objDAL.ExecuteDT("FetchAccountGroup");
            return dt;
        }

        public DataTable FetchAccountGroupwise()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@AgId",AgId)
            };
            dt = objDAL.ExecuteDT("FetchAccountGroupwise", parameter);
            return dt;
        }
    }
}
