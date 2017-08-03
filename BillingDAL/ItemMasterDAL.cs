using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BillingDAL
{
    public class ItemMasterDAL
    {
        DAL objDAL = new DAL();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        private int _ItmId;
        public int ItmId
        {
            get { return _ItmId; }
            set { _ItmId = value; }
        }

        private float _SGST;
        public float SGST
        {
            get { return _SGST; }
            set { _SGST = value; }
        }

        private float _CGST;
        public float CGST
        {
            get { return _CGST; }
            set { _CGST = value; }
        }

        private string _Gridval;
        public string Gridval
        {
            get { return _Gridval; }
            set { _Gridval = value; }
        }

        private int _SGSTId;
        public int SGSTId
        {
            get { return _SGSTId; }
            set { _SGSTId = value; }
        }

        private int _CGSTId;
        public int CGSTId
        {
            get { return _CGSTId; }
            set { _CGSTId = value; }
        }

        private int _ItmMGpId;
        public int ItmMGpId
        {
            get { return _ItmMGpId; }
            set { _ItmMGpId = value; }
        }

        private int _ItmGpId;
        public int ItmGpId
        {
            get { return _ItmGpId; }
            set { _ItmGpId = value; }
        }
        private int _UnitId;

        public int UnitId
        {
            get { return _UnitId; }
            set { _UnitId = value; }
        }

        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private int _mode;

        public int mode
        {
            get { return _mode; }
            set { _mode = value; }
        }

        private int _grpmain;

        public int grpmain
        {
            get { return _grpmain; }
            set { _grpmain = value; }
        }

        private string _ItemName;

        public string ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        private int _ReOrder;

        public int ReOrder
        {
            get { return _ReOrder; }
            set { _ReOrder = value; }
        }

        private int _MinLevel;

        public int MinLevel
        {
            get { return _MinLevel; }
            set { _MinLevel = value; }
        }

        private int _MaxLevel;

        public int MaxLevel
        {
            get { return _MaxLevel; }
            set { _MaxLevel = value; }
        }


        private int _FyId;

        public int FyId
        {
            get { return _FyId; }
            set { _FyId = value; }
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
        private int _CompId;

        public int CompId
        {
            get { return _CompId; }
            set { _CompId = value; }
        }

        private int _itemid;

        public int itemid
        {
            get { return _itemid; }
            set { _itemid = value; }
        }

        private string _Location;

        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

        private string _Category;

        public string Category
        {
            get { return _Category; }
            set { _Category = value; }
        }
        private string _HSNNo;

        public string HSNNo
        {
            get { return _HSNNo; }
            set { _HSNNo = value; }
        }

        private string _SchedNo;

        public string SchedNo
        {
            get { return _SchedNo; }
            set { _SchedNo = value; }
        }

        private string _Supplier;

        public string Supplier
        {
            get { return _Supplier; }
            set { _Supplier = value; }
        }

        private string _Description;

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        private string _Newitemname;

        public string newitwmname
        {
            get { return _Newitemname; }
            set { _Newitemname = value; }
        }
        private decimal _PPrice;

        public decimal PPrice
        {
            get { return _PPrice; }
            set { _PPrice = value; }
        }
        private decimal _LandCost;

        public decimal LandCost
        {
            get { return _LandCost; }
            set { _LandCost = value; }
        }
        private decimal _Price1;

        public decimal Price1
        {
            get { return _Price1; }
            set { _Price1 = value; }
        }
        private decimal _Price2;

        public decimal Price2
        {
            get { return _Price2; }
            set { _Price2 = value; }
        }
        private decimal _Price3;

        public decimal Price3
        {
            get { return _Price3; }
            set { _Price3 = value; }
        }
        private decimal _MRP;

        public decimal MRP
        {
            get { return _MRP; }
            set { _MRP = value; }
        }
        private float _TaxPer;

        public float TaxPer
        {
            get { return _TaxPer; }
            set { _TaxPer = value; }
        }
        private float _OPStock;

        public float OPStock
        {
            get { return _OPStock; }
            set { _OPStock = value; }
        }
        private float _OPLC;

        public float OPLC
        {
            get { return _OPLC; }
            set { _OPLC = value; }
        }
        private float _Stock;

        public float Stock
        {
            get { return _Stock; }
            set { _Stock = value; }
        }

        private int _TaxId;

        public int TaxId
        {
            get { return _TaxId; }
            set { _TaxId = value; }
        }
        private int _GdwId;

        public int GdwId
        {
            get { return _GdwId; }
            set { _GdwId = value; }
        }

        public DataTable FetchUnit()
        {
            
            dt = objDAL.ExecuteDT("FetchUnit");
            return dt;
        }

        public DataTable FetchSupplierList()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@CustSuppType","Suppliers")
            };
            dt = objDAL.ExecuteDT("FetchSupplierList", parameter);
            return dt;
        }

        public DataTable FetchSalesTax()
        {
            dt = objDAL.ExecuteDT("FetchSalesTax");
            return dt;
        }

        public DataTable FetchItemGroup()
        {
            dt = objDAL.ExecuteDT("FetchItemGroup");
            return dt;
        }

        public DataTable FetchGoDown()
        {

            dt = objDAL.ExecuteDT("FetchGoDown");
            return dt;
        }

        public DataTable FetchItemSubGroup()
        {
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@ItmGpId",ItmGpId)
            };
            dt = objDAL.ExecuteDT("FetchItemSubGroup", parameter);
            return dt;
        }

        public DataTable SearchItemMaster()
        {
            dt = objDAL.ExecuteDT("SearchItem");
            return dt;
        }

        public DataTable InsertItem()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@ItemName",ItemName),
            new SqlParameter("@UnitId",UnitId),
            new SqlParameter("@ItmMGpId",ItmMGpId),
            new SqlParameter("@ItmGpId",ItmGpId),
            new SqlParameter("@ReOrder",ReOrder),
            new SqlParameter("@MinLevel",MinLevel),
            new SqlParameter("@MaxLevel",MaxLevel),
            new SqlParameter("@HSNNo",HSNNo),
            new SqlParameter("@SchedNo",SchedNo),
            new SqlParameter("@Description",Description),
            new SqlParameter("@Supplier",Supplier),

            new SqlParameter("@PPrice",PPrice),
            new SqlParameter("@LandCost",LandCost),
            new SqlParameter("@Price1",Price1),
            new SqlParameter("@Price2",Price2),
            new SqlParameter("@Price3",Price3),
            new SqlParameter("@MRP",MRP),
            new SqlParameter("@SGST",SGST),
            new SqlParameter("@SGSTId",SGSTId),
            new SqlParameter("@OPStock",OPStock),
            new SqlParameter("@OPLC",OPLC),
            new SqlParameter("@Stock",Stock),
            new SqlParameter("@Location",Location),
            new SqlParameter("@GdwId",GdwId),
            new SqlParameter("@BrId",BrId),
            new SqlParameter("@FyId",FyId),
            new SqlParameter("@CompId",CompId),
            new SqlParameter("@CGST",CGST),
            new SqlParameter("@CGSTId",CGSTId)
    
            };
            dt = objDAL.ExecuteDT("InsertItem", parameter);
            return dt;
        }
        public DataTable InsertItem1()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@ItemName",ItemName),
            new SqlParameter("@ItemName1",newitwmname),
            new SqlParameter("@ITEMCODE",itemid),
           
            };
            dt = objDAL.ExecuteDT("sps_Sel_Items_CHANGENAME", parameter);
            return dt;
        }
        public DataTable UpdateItem()
        {
            SqlParameter[] parameter = new SqlParameter[] { 
            new SqlParameter("@ItmId",ItmId),
            new SqlParameter("@ItemName",ItemName),
            new SqlParameter("@UnitId",UnitId),
            new SqlParameter("@ItmMGpId",ItmMGpId),
            new SqlParameter("@ItmGpId",ItmGpId),
            new SqlParameter("@ReOrder",ReOrder),
            new SqlParameter("@MinLevel",MinLevel),
            new SqlParameter("@MaxLevel",MaxLevel),
            new SqlParameter("@HSNNo",HSNNo),
            new SqlParameter("@SchedNo",SchedNo),
            new SqlParameter("@Description",Description),
            new SqlParameter("@Supplier",Supplier),

            new SqlParameter("@PPrice",PPrice),
            new SqlParameter("@LandCost",LandCost),
            new SqlParameter("@Price1",Price1),
            new SqlParameter("@Price2",Price2),
            new SqlParameter("@Price3",Price3),
            new SqlParameter("@MRP",MRP),
            new SqlParameter("@SGST",SGST),
            new SqlParameter("@SGSTId",SGSTId),
            new SqlParameter("@OPStock",OPStock),
            new SqlParameter("@OPLC",OPLC),
            new SqlParameter("@Stock",Stock),
            new SqlParameter("@Location",Location),
            new SqlParameter("@GdwId",GdwId),
            new SqlParameter("@BrId",BrId),
            new SqlParameter("@FyId",FyId),
            new SqlParameter("@CompId",CompId),
            new SqlParameter("@CGST",CGST),
            new SqlParameter("@CGSTId",CGSTId)
    
            };
            dt = objDAL.ExecuteDT("UpdateItem", parameter);
            return dt;
        }

        public DataTable FetchItemMaster()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@ItmId",ItmId)
            };
            dt = objDAL.ExecuteDT("FetchItemMaster", parameter);
            return dt;
        }

        public DataTable FetchItemMasterGrid()
        {
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@Gridval",Gridval)
            };
            dt = objDAL.ExecuteDT("FetchItemMasterGrid", parameter);
            return dt;
        }
    }
}
