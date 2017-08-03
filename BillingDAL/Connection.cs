using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace BillingDAL
{
    class Connection
    {
        public SqlConnection conSql;
        SqlCommand cmd;
        public string strConnect;
        public void OpenConnection()
        {

            try
            {
                strConnect = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

                conSql = new SqlConnection(strConnect);
                string s = conSql.State.ToString();
                if (s != "Open")
                {
                    conSql.Open();
                }
            }
            catch (Exception ex)
            {


            }


        }
        /// <summary>
        /// 
        /// </summary>
        public void CloseConnection()
        {
            string s = conSql.State.ToString();
            if (s != "Closed")
            {
                conSql.Close();
            }

        }
        #region Methods

        public int insUpdata(string procName, params SqlParameter[] parms)
        {
            //cmd.Connection = conSql;
            OpenConnection();
            cmd = new SqlCommand(procName, conSql);
            if (parms != null)
            {
                foreach (SqlParameter p in parms)
                {
                    if ((p.Direction == ParameterDirection.InputOutput) && (p.Value == null))
                    {
                        p.Value = DBNull.Value;
                    } cmd.Parameters.Add(p);


                }
            }
            cmd.CommandType = CommandType.StoredProcedure;
            int iStatus = cmd.ExecuteNonQuery();
            CloseConnection();
            return iStatus;
        }
        public int InsUpdataWithRet(string procName, params SqlParameter[] parms)
        {
            //cmd.Connection = conSql;
            OpenConnection();
            cmd = new SqlCommand(procName, conSql);
            if (parms != null)
            {
                foreach (SqlParameter p in parms)
                {
                    if ((p.Direction == ParameterDirection.InputOutput) && (p.Value == null))
                    {
                        p.Value = DBNull.Value;
                    }

                    cmd.Parameters.Add(p);


                }
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            //int iStatus = cmd.ExecuteNonQuery();         
            // object str = cmd.Parameters["@ReturnId"].Value;
            int iRtn = Convert.ToInt32(cmd.Parameters["@ReturnId"].Value.ToString());
            CloseConnection();
            return iRtn;
        }
        public int insUpdata(SqlCommand sqlcmds, string procName, params SqlParameter[] parms)
        {
            sqlcmds.CommandType = CommandType.StoredProcedure;
            sqlcmds.CommandText = procName;
            sqlcmds.Parameters.Clear();
            if (parms != null)
            {
                foreach (SqlParameter p in parms)
                {
                    if ((p.Direction == ParameterDirection.InputOutput) && (p.Value == null))
                    {
                        p.Value = DBNull.Value;
                    }
                    sqlcmds.Parameters.Add(p);

                }
            }
            if (conSql.State == ConnectionState.Closed)
            {
                conSql.Open();
            }
            sqlcmds.Connection = conSql;
            OpenConnection();
            int iStatus = sqlcmds.ExecuteNonQuery();
            CloseConnection();
            return iStatus;
        }

        public DataTable fnSelectData(string procName, params SqlParameter[] parms)
        {
            //SqlConnection _Dbconnect = new SqlConnection(ConfigurationSettings.AppSettings["dbConnect"].ToString());
            DataTable dts = new DataTable();
            SqlCommand cmd = new SqlCommand(procName, conSql);
            if (parms != null)
            {
                foreach (SqlParameter p in parms)
                {
                    if ((p.Direction == ParameterDirection.InputOutput) && (p.Value == null))
                    {
                        p.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(p);

                }
            }
            SqlDataAdapter adp = new SqlDataAdapter();
            OpenConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand = cmd;
            cmd.Connection = conSql;
            adp.Fill(dts);
            CloseConnection();
            return dts;
        }
        #endregion 
    }
}
