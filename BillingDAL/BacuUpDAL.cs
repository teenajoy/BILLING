using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace BillingDAL
{
  public class BacuUpDAL
    {
        DAL objDAL = new DAL();
        Connection con = new Connection();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        private string _path;
        public string path
        {
            get { return _path; }
            set { _path = value; }
        }
        public DataTable InsertItem()
        {
           
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@path",path),
       
            };
            dt = objDAL.ExecuteDT("FetchBackUp", parameter);
            return dt;
        }
    
    }
}
