using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BillingDAL
{
    public class DAL
    {
        public SqlConnection conSql;
        SqlCommand cmd;
        SqlDataReader rdr = null;
        public string strConnect;

        public string GetConnectionString()
        {

            string StrCon = null;
            try
            {
                StrCon = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            }
            catch
            { throw; }
            return StrCon;
        }

        public DataTable ExecuteDT(string ProcName)
        {
            string StrCon = GetConnectionString();
            SqlConnection Connection = null;
            DataTable dt = new DataTable();
            try
            {
                Connection = new SqlConnection(StrCon);
                Connection.Open();
                if (Connection.State == System.Data.ConnectionState.Open)
                {
                    SqlDataAdapter da = new SqlDataAdapter(ProcName, Connection);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(dt);
                }
            }
            catch (SqlException)
            { throw; }
            catch
            { throw; }
            finally
            {
                Connection.Close();
                Connection.Dispose();
            }
            return dt;
        }

        public SqlDataReader exereader(string ProcName)
        {
            string StrCon = GetConnectionString();
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(StrCon);
                Connection.Open();
                if (Connection.State == System.Data.ConnectionState.Open)
                {

                    SqlCommand cmd = new SqlCommand(ProcName, Connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    rdr = cmd.ExecuteReader();

                }
            }
            catch (SqlException)
            { throw; }
            catch
            { throw; }
            finally
            {
                Connection.Close();
                Connection.Dispose();
            }
            return rdr;
        }

        public SqlDataReader exereader(string ProcName, SqlParameter[] sqlparamter)
        {
            string StrCon = GetConnectionString();
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(StrCon);
                Connection.Open();
                if (Connection.State == System.Data.ConnectionState.Open)
                {

                    SqlCommand cmd = new SqlCommand(ProcName, Connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (object X in sqlparamter)
                    {
                        cmd.Parameters.Add(X);
                    }
                    rdr = cmd.ExecuteReader();

                }
            }
            catch (SqlException)
            { throw; }
            catch
            { throw; }
            finally
            {
                Connection.Close();
                Connection.Dispose();
            }
            return rdr;

        }

        public DataTable ExecuteDT(string ProcName, SqlParameter[] sqlparamter)
        {
            string StrCon = GetConnectionString();
            DataTable dt = new DataTable();
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(StrCon);
                Connection.Open();
                if (Connection.State == System.Data.ConnectionState.Open)
                {
                    SqlDataAdapter da = new SqlDataAdapter(ProcName, Connection);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    foreach (object X in sqlparamter)
                    {
                        da.SelectCommand.Parameters.Add(X);
                    }
                    da.Fill(dt);
                }
            }
            catch (SqlException)
            { throw; }
            catch
            { throw; }
            finally
            {
                Connection.Close();
                Connection.Dispose();
            }
            return dt;
        }

    }
}
