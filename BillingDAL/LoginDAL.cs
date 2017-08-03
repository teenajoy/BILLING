using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BillingDAL
{
    public class LoginDAL
    {
        int iUserId = 0;
        string vUserName = string.Empty;
        string vPassword = string.Empty;
        char cLoginStatus;
        char cStatus;
        int iCoId = 0;
        int iFinId = 0;
        int iBranchId = 0;

        DAL objDAL = new DAL();
        DataTable dt = new DataTable();
        SqlDataReader dr ;
        public int UserId
        {
            get
            {
                return iUserId;
            }
            set
            {
                iUserId = value;
            }
        }

        public string UserName
        {
            get
            {
                return vUserName;
            }
            set
            {
                vUserName = value;
            }
        }
        public string Password
        {
            get
            {
                return vPassword;
            }
            set
            {
                vPassword = value;
            }
        }
        public char LoginStatus
        {
            get
            {
                return cLoginStatus;
            }
            set
            {
                cLoginStatus = value;
            }
        }
        public char Status
        {
            get
            {
                return cStatus;
            }
            set
            {
                cStatus = value;
            }
        }
        public int CoId
        {
            get
            {
                return iCoId;
            }
            set
            {
                iCoId = value;
            }
        }
        public int BranchId
        {
            get
            {
                return iBranchId;
            }
            set
            {
                iBranchId = value;
            }
        }
        public int FinId
        {
            get
            {
                return iFinId;
            }
            set
            {
                iFinId = value;
            }
        }

        public DataTable ValidateLogin()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@Username",UserName),
            new SqlParameter("@Password",Password)
            };
            dt = objDAL.ExecuteDT("ValidateLogin", parameter);
            return dt;
        }

        public SqlDataReader ReaderLogin()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@Username",UserName),
            new SqlParameter("@Password",Password)
            };
            dr = objDAL.exereader("ValidateLogin", parameter);
            return dr;
        }
    }
}
