using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace BillingDAL
{
  
   public class StockDAL
    {

        DAL objDAL = new DAL();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        private int _itmid;
        public int itmid
        {
            get { return _itmid; }
            set { _itmid = value; }
        }
        private string _itmname;
        public string itmname
        {
            get { return _itmname; }
            set { _itmname = value; }
        }
        private float _opstock;
        public float opstock
        {
            get { return _opstock; }
            set { _opstock = value; }
        }
        private decimal _pprice;
        public decimal pprice
        {
            get { return _pprice; }
            set { _pprice = value; }
        }
        private decimal _landcost;
        public decimal landcost
        {
            get { return _landcost; }
            set { _landcost = value; }
        }
        private decimal _price1;
        public decimal price1
        {
            get { return _price1; }
            set { _price1 = value; }
        }
        private decimal _price2;
        public decimal price2
        {
            get { return _price2; }
            set { _price2 = value; }
        }
        private decimal _price3;
        public decimal price3
        {
            get { return _price3; }
            set { _price3 = value; }
        }
        private decimal _mrp;
        public decimal mrp
        {
            get { return _mrp; }
            set { _mrp = value; }
        }
        private string _Gridval;
        public string Gridval
        {
            get { return _Gridval; }
            set { _Gridval = value; }
        }
        private int _cid;
        public int cid
        {
            get { return _cid; }
            set { _cid = value; }
        }
        private int _Fid;
        public int Fid
        {
            get { return _Fid; }
            set { _Fid = value; }
        }
        public DataTable selectstock()
       {
           dt = objDAL.ExecuteDT("prcItemStockEntry");
           return dt;
       }
        public DataTable updatestock()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@itemcode",itmid),
            new SqlParameter("@Item",itmname),
            new SqlParameter("@stk",opstock),
            new SqlParameter("@PPrice",pprice),
            new SqlParameter("@LandCost",landcost),
            new SqlParameter("@Price1",price1),
            new SqlParameter("@Price2",price2),
            new SqlParameter("@Price3",price3),
            new SqlParameter("@MRP",mrp),
            };
            dt = objDAL.ExecuteDT("prcUpdateStockEntry", parameter);
            return dt;
        }
        public DataTable FetchStockEntryMasterGrid()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@Gridval",Gridval),

            };
            dt = objDAL.ExecuteDT("FetchStockEntryMasterGrid", parameter);
            return dt;
        }
        public DataTable SearchStock()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@coid",cid),
            new SqlParameter("@year",Fid),
            };
            dt = objDAL.ExecuteDT("Sps_ItemStock", parameter);
            return dt;
        }
    }
 
}
