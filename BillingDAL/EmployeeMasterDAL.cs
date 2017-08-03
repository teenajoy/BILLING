using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace BillingDAL
{
  public class EmployeeMasterDAL
    {
        DAL objDAL = new DAL();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        private string _empcode;
        public string employeecode
        {
            get { return _empcode; }
            set { _empcode = value; }
        }
        private string _empname;
        public string employeename
        {
            get { return _empname; }
            set { _empname = value; }
        }
        private string _empaddress1;
        public string employeeaddress1
        {
            get { return _empaddress1; }
            set { _empaddress1 = value; }
        }
        private string _empaddress2;
        public string employeeaddress2
        {
            get { return _empaddress2; }
            set { _empaddress2 = value; }
        }
        private string _empaddress3;
        public string employeeaddress3
        {
            get { return _empaddress3; }
            set { _empaddress3 = value; }
        }
        private string _emptelno;
        public string employeetelno
        {
            get { return _emptelno; }
            set { _emptelno = value; }
        }
        private string _empmobno;
        public string employeemobile
        {
            get { return _empmobno; }
            set { _empmobno = value; }
        }
        private DateTime _empdob;
        public DateTime employeedob
        {
            get { return _empdob; }
            set { _empdob = value; }
        }
        private string _empdesignation;
        public string employeedesignation
        {
            get { return _empdesignation; }
            set { _empdesignation = value; }
        }
        private string _empdepartment;
        public string employeedepartment
        {
            get { return _empdepartment; }
            set { _empdepartment = value; }
        }
        private float _empsalary;
        public float employeesalary
        {
            get { return _empsalary; }
            set { _empsalary = value; }
        }
        private string _empstatus;
        public string employeestatus
        {
            get { return _empstatus; }
            set { _empstatus = value; }
        }
        private DateTime _empjoining;
        public DateTime employeejoining
        {
            get { return _empjoining; }
            set { _empjoining = value; }
        }
        private DateTime _empreliving;
        public DateTime employeereliving
        {
            get { return _empreliving; }
            set { _empreliving = value; }
        }
        private string _Gridval;
        public string Gridval
        {
            get { return _Gridval; }
            set { _Gridval = value; }
        }
        private string _coid;
        public string coid
        {
            get { return _coid; }
            set { _coid = value; }
        }
        public DataTable FetchDesignation()
        {
            dt = objDAL.ExecuteDT("sps_Sel_Employee_Designation");
            return dt;
        }
        public DataTable FetchDepartment()
        {
            dt = objDAL.ExecuteDT("sps_Sel_Employee_Department");
            return dt;
        }
        public DataTable InsertItem()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@EmpName",employeename),
            new SqlParameter("@Add1",employeeaddress1),
            new SqlParameter("@Add2",employeeaddress2),
            new SqlParameter("@Add3",employeeaddress3),
            new SqlParameter("@PhNo",employeetelno),
            new SqlParameter("@MobileNo",employeemobile),
            new SqlParameter("@Dob",employeedob),
            new SqlParameter("@Designation",employeedesignation),
            new SqlParameter("@Department",employeedepartment),
            new SqlParameter("@Salary",employeesalary),
            new SqlParameter("@Doj",employeejoining),

           
            new SqlParameter("@Status",employeestatus),
            new SqlParameter("@Coid",coid),
            
            };
            dt = objDAL.ExecuteDT("sps_insert_Employee", parameter);
            return dt;
        }
        public DataTable DeleteEmployee()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@EmpCode",employeecode),
            new SqlParameter("@Coid",coid),
            };
            dt = objDAL.ExecuteDT("sps_DELETE_Employee", parameter);
            return dt;
        }
        public DataTable Update()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@EmpName",employeename),
            new SqlParameter("@Add1",employeeaddress1),
            new SqlParameter("@Add2",employeeaddress2),
            new SqlParameter("@Add3",employeeaddress3),
            new SqlParameter("@PhNo",employeetelno),
            new SqlParameter("@MobileNo",employeemobile),
            new SqlParameter("@Dob",employeedob),
            new SqlParameter("@Designation",employeedesignation),
            new SqlParameter("@Department",employeedepartment),
            new SqlParameter("@Salary",employeesalary),
            new SqlParameter("@Doj",employeejoining),

           
            new SqlParameter("@Status",employeestatus),
            new SqlParameter("@EmpCode",_empcode),
            new SqlParameter("@Coid",coid),
            
            };
            dt = objDAL.ExecuteDT("sps_Update_Employee", parameter);
            return dt;
        }
        public DataTable SearchAccount()
        {
            dt = objDAL.ExecuteDT("sps_Sel_EmployeeSearch");
            return dt;
        }
        public DataTable SearchEmployee()
        {
            dt = objDAL.ExecuteDT("sps_Sel_Employee");
            return dt;
        }
        public DataTable FetchEmployeeMasterGrid()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@Gridval",Gridval)
            };
            dt = objDAL.ExecuteDT("FetchEmployyeMasterGrid", parameter);
            return dt;
        }
        public DataTable FetchEmployeeMaster()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@EmpCode",employeecode)
            };
            dt = objDAL.ExecuteDT("FetchEmployeeMaster", parameter);
            return dt;
        }
    }
}
