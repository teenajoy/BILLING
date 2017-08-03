using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BillingDAL
{
    public class CmpntLoginDAL
    {
        DAL objDAL = new DAL();
        DataTable dt = new DataTable();

        private string _UserName;
        private string _Password;
        private int _DivId;
        private int _CompId;
        private string _UserType;

        public string UserType
        {
            get { return _UserType; }
            set { _UserType = value; }
        }

        public int CompId
        {
            get { return _CompId; }
            set { _CompId = value; }
        }
        private int _BrId;

        public int BrId
        {
            get { return _BrId; }
            set { _BrId = value; }
        }

        public int DivId
        {
            get { return _DivId; }
            set { _DivId = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        public DataTable FetchCompany()
        {
            dt = objDAL.ExecuteDT("FetchCompany");
            return dt;
        }

        public DataTable FetchFinancialYear()
        {
            dt = objDAL.ExecuteDT("FetchFinancialYear");
            return dt;
        }
    }
}
