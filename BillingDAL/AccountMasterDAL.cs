using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BillingDAL
{
    public class AccountMasterDAL
    {
        DAL objDAL = new DAL();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        private int _AmId;
        public int AmId
        {
            get { return _AmId; }
            set { _AmId = value; }
        }

        private int _AgId;
        public int AgId
        {
            get { return _AgId; }
            set { _AgId = value; }
        }


        private string _Head;

        public string Head
        {
            get { return _Head; }
            set { _Head = value; }
        }

        private string _Address1;

        public string Address1
        {
            get { return _Address1; }
            set { _Address1 = value; }
        }

        private string _Address2;

        public string Address2
        {
            get { return _Address2; }
            set { _Address2 = value; }
        }

        private string _Address3;

        public string Address3
        {
            get { return _Address3; }
            set { _Address3 = value; }
        }

        private string _Address4;

        public string Address4
        {
            get { return _Address4; }
            set { _Address4 = value; }
        }

        private string _District;

        public string District
        {
            get { return _District; }
            set { _District = value; }
        }


        private string _Agent;

        public string Agent
        {
            get { return _Agent; }
            set { _Agent = value; }
        }

        private string _State;

        public string State
        {
            get { return _State; }
            set { _State = value; }
        }


        private string _Pincode;

        public string Pincode
        {
            get { return _Pincode; }
            set { _Pincode = value; }
        }
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _TelNo;

        public string TelNo
        {
            get { return _TelNo; }
            set { _TelNo = value; }
        }
        private string _Mobile;

        public string Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }
        private string _Fax;

        public string Fax
        {
            get { return _Fax; }
            set { _Fax = value; }
        }
        private string _GSTinNo;

        public string GSTinNo
        {
            get { return _GSTinNo; }
            set { _GSTinNo = value; }
        }
        private string _CstNo;

        public string CstNo
        {
            get { return _CstNo; }
            set { _CstNo = value; }
        }
        private string _ServiceTaxNo;

        public string ServiceTaxNo
        {
            get { return _ServiceTaxNo; }
            set { _ServiceTaxNo = value; }
        }

        private string _StateCode;

        public string StateCode
        {
            get { return _StateCode; }
            set { _StateCode = value; }
        }

        private string _PanNo;

        public string PanNo
        {
            get { return _PanNo; }
            set { _PanNo = value; }
        }

        private string _Category;

        public string Category
        {
            get { return _Category; }
            set { _Category = value; }
        }
        private string _Remarks;

        public string Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }


        private decimal _CreditLimit;

        public decimal CreditLimit
        {
            get { return _CreditLimit; }
            set { _CreditLimit = value; }
        }

        private int _CreditDays;

        public int CreditDays
        {
            get { return _CreditDays; }
            set { _CreditDays = value; }
        }

        private string _PriceGroup;

        public string PriceGroup
        {
            get { return _PriceGroup; }
            set { _PriceGroup = value; }
        }

        private string _group;

        public string group
        {
            get { return _group; }
            set { _group = value; }
        }
        private string _accname;

        public string accname
        {
            get { return _accname; }
            set { _accname = value; }
        }
        private decimal _OPDRBal;

        public decimal OPDRBal
        {
            get { return _OPDRBal; }
            set { _OPDRBal = value; }
        }
        private decimal _OPCRBal;

        public decimal OPCRBal
        {
            get { return _OPCRBal; }
            set { _OPCRBal = value; }
        }
        private decimal _CurDRBal;

        public decimal CurDRBal
        {
            get { return _CurDRBal; }
            set { _CurDRBal = value; }
        }
        private decimal _CurCRBal;

        public decimal CurCRBal
        {
            get { return _CurCRBal; }
            set { _CurCRBal = value; }
        }
        private int _BrId;

        public int BrId
        {
            get { return _BrId; }
            set { _BrId = value; }
        }
        private int _DivId;

        public int DivId
        {
            get { return _DivId; }
            set { _DivId = value; }
        }
        private int _FyId;

        public int FyId
        {
            get { return _FyId; }
            set { _FyId = value; }
        }

        private int _CompId;

        public int CompId
        {
            get { return _CompId; }
            set { _CompId = value; }
        }

        private DateTime _DateFrom;

        public DateTime DateFrom
        {
            get { return _DateFrom; }
            set { _DateFrom = value; }
        }

        private DateTime _DateTo;

        public DateTime DateTo
        {
            get { return _DateTo; }
            set { _DateTo = value; }
        }

        public DataTable FetchListGroup()
        {
            dt = objDAL.ExecuteDT("FetchListGroup");
            return dt;
        }

        public DataTable FetchListGrouptxt()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@group",group)
           
            };
            dt = objDAL.ExecuteDT("FetchListGrouptxt", parameter);
            return dt;
        }

        public DataTable InsertAccount()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@AgId",AgId),
            new SqlParameter("@Head",Head),
            new SqlParameter("@Address1",Address1),
            new SqlParameter("@Address2",Address2),
            new SqlParameter("@Address3",Address3),
            new SqlParameter("@District",District),
            new SqlParameter("@State",State),

            new SqlParameter("@Email",Email),
            new SqlParameter("@TelNo",TelNo),
            new SqlParameter("@Mobile",Mobile),
            new SqlParameter("@Fax",Fax),
            new SqlParameter("@GSTinNo",GSTinNo),
            new SqlParameter("@StateCode",StateCode),
            new SqlParameter("@ServiceTaxNo",ServiceTaxNo),
            new SqlParameter("@PanNo",PanNo),
            new SqlParameter("@CreditLimit",CreditLimit),
            new SqlParameter("@CreditDays",CreditDays),
            new SqlParameter("@PriceGroup",PriceGroup),
            new SqlParameter("@Remarks",Remarks),
            new SqlParameter("@Category",Category),
            new SqlParameter("@Agent",Agent),

            new SqlParameter("@OPCRBal",OPCRBal),
            new SqlParameter("@OPDRBal",OPDRBal),
            new SqlParameter("@BrId",BrId),
            new SqlParameter("@FyId",FyId),
            new SqlParameter("@CompId",CompId)
            
    
            };
            dt = objDAL.ExecuteDT("InsertAccount", parameter);
            return dt;
        }

        public DataTable UpdateAccount()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@AmId",AmId),
            new SqlParameter("@Head",Head),
            new SqlParameter("@Address1",Address1),
            new SqlParameter("@Address2",Address2),
            new SqlParameter("@Address3",Address3),
            new SqlParameter("@District",District),
            new SqlParameter("@State",State),

            new SqlParameter("@Email",Email),
            new SqlParameter("@TelNo",TelNo),
            new SqlParameter("@Mobile",Mobile),
            new SqlParameter("@Fax",Fax),
            new SqlParameter("@GSTinNo",GSTinNo),
            new SqlParameter("@StateCode",StateCode),
            new SqlParameter("@ServiceTaxNo",ServiceTaxNo),
            new SqlParameter("@PanNo",PanNo),
            new SqlParameter("@CreditLimit",CreditLimit),
            new SqlParameter("@CreditDays",CreditDays),
            new SqlParameter("@PriceGroup",PriceGroup),
            new SqlParameter("@Remarks",Remarks),
            new SqlParameter("@Category",Category),
            new SqlParameter("@Agent",Agent),

            new SqlParameter("@OPCRBal",OPCRBal),
            new SqlParameter("@OPDRBal",OPDRBal),
            new SqlParameter("@BrId",BrId),
            new SqlParameter("@FyId",FyId),
            new SqlParameter("@CompId",CompId)
            };
            dt = objDAL.ExecuteDT("UpdateAccount", parameter);
            return dt;
        }

        public DataTable SearchAccount()
        {
            dt = objDAL.ExecuteDT("SearchAccount");
            return dt;
        }
        public DataTable FetchAccountMasterGrid()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@Accname",accname)
            };
            dt = objDAL.ExecuteDT("FetchAccountMasterGrid", parameter);
            return dt;
        }
        public DataTable FetchAccountDetails()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@AmId",AmId)
            };
            dt = objDAL.ExecuteDT("FetchAccountDetails", parameter);
            return dt;
        }

    }
}
