using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace BillingDAL
{
  public class AdUserDAL
    {
        DAL objDAL = new DAL();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        private string _usernam;
        public string username
        {
            get { return _usernam; }
            set { _usernam = value; }
        }
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        private string _Gridval;
        public string Gridval
        {
            get { return _Gridval; }
            set { _Gridval = value; }
        }
      private int _userid;
      public int userid
      {
          get { return _userid; }
          set { _userid = value; }
      }
        public DataTable InsertItem()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@Password1",Password),
            new SqlParameter("@UserName",username),
                   
            };
            dt = objDAL.ExecuteDT("sps_insert_LoginMaster", parameter);
            return dt;
        }
        public DataTable SearchUser()
        {

            dt = objDAL.ExecuteDT("sps_Sel_ADDUserSearch");
            return dt;
        }
        public DataTable FetchUserMasterGrid()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@Gridval",Gridval),

            };
            dt = objDAL.ExecuteDT("FetchUserMasterGrid", parameter);
            return dt;
        }
        public DataTable FetchUserMaster()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@userid",userid),
            };
            dt = objDAL.ExecuteDT("sps_FetchADDUserSearch", parameter);
            return dt;
        }
        public DataTable FetchUserSearchMaster()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@username",username),
            };
            dt = objDAL.ExecuteDT("sps_FetchUserSearch", parameter);
            return dt;
        }
    }
}
