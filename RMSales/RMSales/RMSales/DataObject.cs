using System;
using System.Data;
using System.Data.SQLite;

namespace RMSales
{
    public class DataObject
    {
        Utilities util = new Utilities();
        DataTable dt;
        public SQLiteConnection GetConnection()
        {
            SQLiteConnection   con = new SQLiteConnection(string.Format(DBSQL.conStr, util.GetConfigValue("DBFilePath")));
            con.Open();
            return con;
        }
        private string getSqlString(string pdata)
        {
            string rstr = "";
            foreach (string str in pdata.Split(','))
                rstr += "'" + str + "',";
            return rstr.Trim(',');
        }
        internal void UpdateCheckList(string rowHeader, string colHeader, string val)
        {
            string mainSQL = string.Format(DBSQL.sqlProducsAll, rowHeader, val, colHeader);
            SQLiteCommand cmd = new SQLiteCommand(mainSQL, GetConnection());
            cmd.ExecuteNonQuery();
        }
        //Quotes
      
        public DataTable GetTableAll(TableType tType)
        {
            dt = new DataTable();
            string MainSQL = "";
            switch (tType)
            {
                case TableType.Expenses:
                    MainSQL = DBSQL.sqlExpenditureAll;
                    break;
                case TableType.SalesItem:
                    MainSQL = DBSQL.sqlSalesItemAll;
                    break;
                case TableType.Sales:
                    MainSQL = DBSQL.sqlSalesAll;
                    break;
                case TableType.Product:
                    MainSQL = DBSQL.sqlProducsAll;
                    break;
                case TableType.Investment:
                    MainSQL = DBSQL.sqlInvestmentAll;
                    break;
                case TableType.Purchase:
                    MainSQL = DBSQL.sqlPurchaseAll;
                    break;
                case TableType.Supplier:
                    MainSQL = DBSQL.sqlSupplierAll;
                    break;
                case TableType.Technician:
                    MainSQL = DBSQL.sqlTechnicianAll;
                    break;
                case TableType.Stock:
                    MainSQL = DBSQL.sqlStock;
                    break;
            }

            SQLiteCommand cmd = new SQLiteCommand(MainSQL, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public void AddSaleItem(string saleID, string pcode, string pname, string qty, string tp, string itemPrice)
        {
            string MainSQL = string.Format(DBSQL.sqlInsertSaleItem, saleID, pcode, pname, qty, tp, itemPrice);
            SQLiteCommand cmd = new SQLiteCommand(MainSQL, GetConnection());
            cmd.ExecuteNonQuery();
        }
        public DataTable GetSalesItemBySaleID(string saleID)
        {
            dt = new DataTable();
            string MainSQL = string.Format(DBSQL.sqlSalesItemBySaleID, saleID);
            SQLiteCommand cmd = new SQLiteCommand(MainSQL, GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public int AddSale(string techName, string sdate, string qty, string tp)
        {
            string MainSQL = string.Format(DBSQL.sqlInsertSale, techName, sdate, qty, tp);
            
            SQLiteCommand cmd = new SQLiteCommand(MainSQL, GetConnection());
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT last_insert_rowid()";
            Int64 LastRowID64 = (Int64)cmd.ExecuteScalar();

            return (int)LastRowID64;

        }
        public void UpdateSale(string saleID)
        {
            string MainSQL = string.Format(DBSQL.sqlUpdateSaleAmt, saleID);
            SQLiteCommand cmd = new SQLiteCommand(MainSQL, GetConnection());
            cmd.ExecuteNonQuery();
        }
        internal void AddMasterProduct(string type, string details, string OPrice, string sPrice)
        {
            string MainSQL = string.Format(DBSQL.sqlInsertMasterProducts, type, details, OPrice, sPrice);
            SQLiteCommand cmd = new SQLiteCommand(MainSQL, GetConnection());
            cmd.ExecuteNonQuery();
        }

        internal void SalesItemDeleteByID(string sid)
        {
            string MainSQL = string.Format(DBSQL.sqlSalesItemDeleteByID, sid);
            SQLiteCommand cmd = new SQLiteCommand(MainSQL, GetConnection());
            cmd.ExecuteNonQuery();
        }

        internal DataTable GetOrderItemByID(string pid)
        {
            dt = new DataTable();
            SQLiteCommand cmd = new SQLiteCommand(string.Format(DBSQL.sqlOrderItemByID, pid), GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        internal object GetOrderByCode(string pCode)
        {
            dt = new DataTable();
            SQLiteCommand cmd = new SQLiteCommand(string.Format(DBSQL.sqlOrderByCode, pCode), GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        internal object GetSaleByCode(string pCode)
        {
            dt = new DataTable();
            SQLiteCommand cmd = new SQLiteCommand(string.Format(DBSQL.sqlSaleByCode, pCode), GetConnection());
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        internal void UpdateProductPrice(string rowHeader, string colHeader, string val)
        {
            string MainSQL = string.Format(DBSQL.sqlUpdateProductPrice, rowHeader, val, colHeader);
            SQLiteCommand cmd = new SQLiteCommand(MainSQL, GetConnection());
            cmd.ExecuteNonQuery();
        }

        internal int CreateOrder(string sName, string date)
        {
            string MainSQL = string.Format(DBSQL.sqlCreatePO, sName, date, "Draft");
            SQLiteCommand cmd = new SQLiteCommand(MainSQL, GetConnection());
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT last_insert_rowid()";
            Int64 LastRowID64 = (Int64)cmd.ExecuteScalar();

            return (int)LastRowID64;
        }

        internal void CreatePoItem(string pid, string pcode, string pname, string qty, string pprice)
        {
            string MainSQL = string.Format(DBSQL.sqlCreatePOitem, pid, pcode, pname, qty, pprice);
            SQLiteCommand cmd = new SQLiteCommand(MainSQL, GetConnection());
            cmd.ExecuteNonQuery();
        }

        internal void UpdateOrder(string Orderid)
        {
            string MainSQL = string.Format(DBSQL.sqlUpdatePO, Orderid);
            SQLiteCommand cmd = new SQLiteCommand(MainSQL, GetConnection());
            cmd.ExecuteNonQuery();
        }


        internal void UpdatePOstatus(string pid, string status)
        {
            string MainSQL = string.Format(DBSQL.sqlUpdatePOStatus, status, pid);
             SQLiteCommand cmd = new SQLiteCommand(MainSQL, GetConnection());
            cmd.ExecuteNonQuery();
        }

        internal void UpdatePoItem(string pid, string rqty, string sPrice)
        {
            string MainSQL = string.Format(DBSQL.sqlUpdatePOItem, rqty, sPrice, pid);
            SQLiteCommand cmd = new SQLiteCommand(MainSQL, GetConnection());
            cmd.ExecuteNonQuery();
        }
    }
    public class DBSQL
    {
        public const string conStr =             @"URI=file:{0}";
        public const string sqlInsertMasterProducts = "INSERT INTO tblMasterProducts(Type, Details, PurchasePricePerUnit, ExpSalePricePerUnit) VALUES ('{0}','{1}','{2}','{3}')";
        public const string sqlInsertSale =     "INSERT INTO tblSales(TechnicianName, SaleDate, Quantity, TotalPrice) VALUES ('{0}','{1}','{2}','{3}')";
        public const string sqlUpdateSaleAmt =  "Update tblSales SET Quantity = (SELECT sum(Quantity) FROM tblSalesItem WHERE SaleID ='{0}'), TotalPrice = (SELECT sum(TotalPrice) FROM tblSalesItem WHERE SaleID ='{0}') WHERE ID ='{0}'";
        public const string sqlInsertSaleItem = "INSERT INTO tblSalesItem(SaleID, ProductCode, ProductName, Quantity, TotalPrice, SalePrice) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')";
        public const string sqlCreatePO =       "INSERT INTO tblOrder(SupplierName, Date, OrderStatus) VALUES ('{0}', '{1}', '{2}')";
        public const string sqlCreatePOitem =   "INSERT INTO tblOrderItem(OrderID, ProductCode, ProductName, OrderQty, PurchasedPrice) VALUES ('{0}','{1}','{2}','{3}','{4}')";

        public const string sqlUpdatePO = @"UPDATE tblOrder SET 
                                        ItemCount = (SELECT count(*) FROM tblOrderItem WHERE OrderID ='{0}'), 
                                        TotalPrice = (SELECT sum(PurchasedPrice) FROM tblOrderItem WHERE OrderID ='{0}'),
                                        TotalQty = (SELECT sum(OrderQty) FROM tblOrderItem WHERE OrderID ='{0}') 
                                        WHERE ID ='{0}'";
        public const string sqlUpdatePOStatus = "Update tblOrder SET OrderStatus ='{0}' WHERE ID = '{1}'";
        public const string sqlUpdatePOItem =   "Update tblOrderItem SET ReceivedQty = '{0}', EstSalePrice='{1}' WHERE ID = '{2}'";

        public const string sqlProducsAll =     "SELECT * FROM tblMasterProducts Order by Details";
        public const string sqlPurchaseAll =    "SELECT * FROM tblOrder WHERE OrderStatus='Draft'";
        public const string sqlOrderItemByID =  "SELECT * FROM tblOrderItem WHERE OrderID='{0}'";
        public const string sqlInvestmentAll =  "SELECT * FROM tblInvestments";
        public const string sqlExpenditureAll = "SELECT * FROM tblExpenses";
        public const string sqlSupplierAll =    "SELECT * FROM tblSupplier";
        public const string sqlSalesItemAll =   "SELECT * FROM tblSalesItem";
        public const string sqlSalesAll =       "SELECT * FROM tblSales Order By ID Desc";
        public const string sqlTechnicianAll =  "SELECT Id, Name FROM tblTechnician Order by Name";
        public const string sqlSalesItemBySaleID = @"SELECT ID, ROW_NUMBER () OVER (ORDER BY ID) SNo, productName, 
                            SalePrice As ItemPrice,  Quantity, TotalPrice FROM tblSalesItem WHERE SaleID = '{0}'";
        public const string sqlSalesItemDeleteByID = "DELETE FROM tblSalesItem WHERE ID = '{0}'";
        public const string sqlUpdateProductPrice =  "UPDATE tblMasterProducts Set {0} = '{1}' WHERE ID = '{2}'";

        public const string sqlStock = @"SELECT ID, code, details, OrderCount, SaleCount, OrderCount-SaleCount As Stock, BuyPrice FROM(
                    SELECT ID, code, details, PurchasePricePerUnit as BuyPrice,
                    (SELECT sum(ReceivedQty) FROM tblorderitem WHERE OrderID IN (SELECT id FROM tblorder WHERE orderStatus IN
                    ('Received','PartialReceived')) and productcode=mp.code) AS OrderCount,
                    (SELECT sum(Quantity) FROM tblSalesItem WHERE productcode=mp.code) As SaleCount
                    FROM tblmasterproducts mp) ORDER BY stock desc";

        public const string sqlSaleByCode = @"SELECT s.SaleDate, S.TechnicianName, si.quantity, si.saleprice 
                                            FROM tblSales s
                                            INNER JOIN tblsalesitem si on s.id = si.saleid WHERE ProductCode='{0}'";

        public const string sqlOrderByCode = @"SELECT o.Date, o.SupplierName, oi.ReceivedQty, Oi.PurchasedPrice 
                                            FROM tblOrder o
                                            INNER JOIN tblOrderItem oi on o.id = oi.OrderID
                                            WHERE ProductCode='{0}' AND o.orderStatus in ('Received','PartialReceived')";
    }

}