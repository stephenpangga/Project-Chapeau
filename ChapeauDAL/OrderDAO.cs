using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class OrderDAO : Base
    {
        //Create EmployeeDAO, DiningTableDAO and OrderMenuItemDAO objects
        EmployeeDAO employeeDB = new EmployeeDAO();
        DiningTableDAO diningTableDB = new DiningTableDAO();
        OrderMenuItemDAO orderMenuItemDB = new OrderMenuItemDAO();

        //NEW
        //Get all Orders from the database
        public List<Order> GetAllOrdersDB()
        {
            string query = "SELECT O.id AS OrderId, E.id AS EmpId, E.name AS EmpName, position, D.id AS TableId, status FROM [ORDER] AS O JOIN EMPLOYEE AS E ON O.handled_by = E.id JOIN DINING_TABLE AS D ON O.[table] = D.id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //NEW
        //Get an Order from database by id
        public Order GetOrderByIdDB(int id)
        {
            string query = "SELECT O.id AS OrderId, E.id AS EmpId, E.name AS EmpName, position, D.id AS TableId, status FROM [ORDER] AS O JOIN EMPLOYEE AS E ON O.handled_by = E.id JOIN DINING_TABLE AS D ON O.[table] = D.id WHERE O.id = @id";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        //NEW
        //Get active Order from the database by table
        public Order GetActiveOrderByTableDB(DiningTable table)
        {
            string query = "SELECT O.id AS OrderId, E.id AS EmpId, E.name AS EmpName, position, D.id AS TableId, status FROM [ORDER] AS O JOIN EMPLOYEE AS E ON O.handled_by = E.id JOIN DINING_TABLE AS D ON O.[table] = D.id WHERE D.id = @table AND O.id NOT IN (SELECT order_id FROM PAYMENT)";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@table", table.Id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }



        //generic method to get all orders from the database depending on occupation
        public List<Order> BaseGetAllOrdersByOccupationDB(string type)
        {
            string query;

            switch (type)
            {
                case "bar":
                    query = "SELECT O.id AS OrderId, C.date_time as [DateTime], handled_by, [table], C.id AS ContentId FROM[ORDER] AS O JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN MENU_ITEM AS M ON M.id = C.item_id WHERE M.category LIKE 'Dr%' ORDER BY C.date_time DESC";
                    break;
                case "kitchen":
                    query = "SELECT O.id AS OrderId, C.date_time as [DateTime], handled_by, [table], C.id AS ContentId FROM[ORDER] AS O JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN MENU_ITEM AS M ON M.id = C.item_id WHERE (M.category LIKE 'Lu%' OR M.category LIKE 'Di%') ORDER BY C.date_time DESC";
                    break;
                default:
                    throw new Exception("incorrect input for type");
            }
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTableData(ExecuteSelectQuery(query, sqlParameters));
        }



        //methods to get bar orders from the database depending on occupation
        public List<Order> GetAllBarOrdersByOccupationDB()
        {
            return BaseGetAllOrdersByOccupationDB("bar");
        }

        public List<Order> GetAllKitchenOrdersByOccupationDB()
        {
            return BaseGetAllOrdersByOccupationDB("kitchen");
        }



        //NEW NEW
        //Generic method to get orders from the database depending on datetime
        public List<Order> BaseGetAllOrdersByDateTimeDB(string type, DateTime time)
        {
            string query;

            switch (type)
            {
                case "bar":
                    query = "SELECT O.id AS OrderId, E.id AS EmpId, E.name AS EmpName, position, D.id AS TableId, D.status AS TableStatus, C.id AS ContentId FROM [ORDER] AS O JOIN EMPLOYEE AS E ON O.handled_by = E.id JOIN DINING_TABLE AS D ON O.[table] = D.id JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN MENU_ITEM AS M ON C.item_id = M.id WHERE M.category LIKE 'Dr%' AND C.[status] = @status ORDER BY C.date_time";
                    break;
                case "kitchen":
                    query = "SELECT O.id AS OrderId, E.id AS EmpId, E.name AS EmpName, position, D.id AS TableId, D.status AS TableStatus, C.id AS ContentId FROM [ORDER] AS O JOIN EMPLOYEE AS E ON O.handled_by = E.id JOIN DINING_TABLE AS D ON O.[table] = D.id JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN MENU_ITEM AS M ON C.item_id = M.id WHERE (M.category LIKE 'Lu%' OR M.category LIKE 'Di%') AND C.[status] = @status ORDER BY C.date_time";
                    break;
                default:
                    throw new Exception("incorrect input for type");
            }

            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@time", time)
            });

            return ReadTableData(ExecuteSelectQuery(query, sqlParameters));
        }


        //methods to get bar orders from the database depending on datetime
        public List<Order> GetAllBarOrdersByDateTimeDB(DateTime time)
        {
            return BaseGetAllOrdersByDateTimeDB("bar", time);
        }

        public List<Order> GetAllKitchenOrdersByDateTimeDB(DateTime time)
        {
            return BaseGetAllOrdersByDateTimeDB("kitchen", time);
        }


        //NEW
        // Generic method to get orders from the database depending on the status
        public List<Order> BaseGetOrderByStatus(string type, string status)
        {
            string query;

            switch (type)
            {
                case "bar":
                    query = "SELECT O.id AS OrderId, E.id AS EmpId, E.name AS EmpName, position, D.id AS TableId, D.status AS TableStatus, C.id AS ContentId FROM [ORDER] AS O JOIN EMPLOYEE AS E ON O.handled_by = E.id JOIN DINING_TABLE AS D ON O.[table] = D.id JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN MENU_ITEM AS M ON C.item_id = M.id WHERE M.category LIKE 'Dr%' AND C.[status] = @status ORDER BY C.date_time";
                    break;
                case "kitchen":
                    query = "SELECT O.id AS OrderId, E.id AS EmpId, E.name AS EmpName, position, D.id AS TableId, D.status AS TableStatus, C.id AS ContentId FROM [ORDER] AS O JOIN EMPLOYEE AS E ON O.handled_by = E.id JOIN DINING_TABLE AS D ON O.[table] = D.id JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN MENU_ITEM AS M ON C.item_id = M.id WHERE (M.category LIKE 'Lu%' OR M.category LIKE 'Di%') AND C.[status] = @status ORDER BY C.date_time";
                    break;
                default:
                    throw new Exception("incorrect input for type");
            }

            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@status", status)
            });

            return ReadTablesByOrderStatus(ExecuteSelectQuery(query, sqlParameters));
        }
    



        // methods to get kitchen orders from the database depending on status
        public List<Order> GetKitchenBeingPreparedOrdersDB()
        {
            return BaseGetOrderByStatus("kitchen", "BeingPrepared");
        }


        public List<Order> GetKitchenReadyToServeOrdersDB()
        {
            return BaseGetOrderByStatus("kitchen", "ReadyToServe");
        }


        public List<Order> GetKitchenServedOrdersDB()
        {
            return BaseGetOrderByStatus("kitchen", "Served");
        }



        // methods to get bar orders from the database depending on status
        public List<Order> GetBarBeingPreparedOrdersDB()
        {
            return BaseGetOrderByStatus("bar", "BeingPrepared");
        }


        public List<Order> GetBarReadyToServeOrdersDB()
        {
            return BaseGetOrderByStatus("bar", "ReadyToServe");
        }


        public List<Order> GetBarServedOrdersDB()
        {
            return BaseGetOrderByStatus("bar", "Served");
        }



        //generic method to get orders from the database depending on the status grouped by datetime
        public List<DateTime> BaseGetOrderByStatusGroupedByDateTimeDB(string type, string status, string orderby)
        {
            string query;

            switch (type)
            {
                case "bar":
                    query = $"SELECT C.date_time FROM ORDER_CONTENT AS C JOIN MENU_ITEM AS M ON M.id = C.item_id WHERE M.category LIKE 'Dr%' AND C.[status] = @status GROUP BY date_time ORDER BY date_time {orderby}";
                    break;
                case "kitchen":
                    query = $"SELECT C.date_time FROM ORDER_CONTENT AS C JOIN MENU_ITEM AS M ON M.id = C.item_id WHERE (M.category LIKE 'Lu%' OR M.category LIKE 'Di%') AND C.[status] = @status GROUP BY date_time ORDER BY date_time {orderby}";
                    break;
                default:
                    throw new Exception("incorrect input for type");
            }

            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@status", status),
            });

            return ReadDateTime(ExecuteSelectQuery(query, sqlParameters));
        }


        // methods to get kitchen orders from the database depending on status grouped by datetime
        public List<DateTime> GetKitchenBeingPreparedOrdersGroupedByDateTimeDB()
        {
            return BaseGetOrderByStatusGroupedByDateTimeDB("kitchen", "BeingPrepared", "ASC");
        }


        public List<DateTime> GetKitchenReadyToServeOrdersGroupedByDateTimeDB()
        {
            return BaseGetOrderByStatusGroupedByDateTimeDB("kitchen", "ReadyToServe", "ASC");
        }


        public List<DateTime> GetKitchenReadyToServeOrdersGroupedByDateTimeDescDB()
        {
            return BaseGetOrderByStatusGroupedByDateTimeDB("kitchen", "ReadyToServe", "DESC");
        }


        public List<DateTime> GetKitchenServedOrdersGroupedByDateTimeDB()
        {
            return BaseGetOrderByStatusGroupedByDateTimeDB("kitchen", "Served", "ASC");
        }


        public List<DateTime> GetKitchenServedOrdersGroupedByDateTimeDescDB()
        {
            return BaseGetOrderByStatusGroupedByDateTimeDB("kitchen", "Served", "DESC");
        }





        // methods to get bar orders from the database depending on status grouped by datetime
        public List<DateTime> GetBarBeingPreparedOrdersGroupedByDateTimeDB()
        {
            return BaseGetOrderByStatusGroupedByDateTimeDB("bar", "BeingPrepared", "ASC");
        }


        public List<DateTime> GetBarReadyToServeOrdersGroupedByDateTimeDB()
        {
            return BaseGetOrderByStatusGroupedByDateTimeDB("bar", "ReadyToServe", "ASC");
        }

        public List<DateTime> GetBarReadyToServeOrdersGroupedByDateTimeDescDB()
        {
            return BaseGetOrderByStatusGroupedByDateTimeDB("bar", "ReadyToServe", "DESC");
        }


        public List<DateTime> GetBarServedOrdersGroupedByDateTimeDB()
        {
            return BaseGetOrderByStatusGroupedByDateTimeDB("bar", "Served", "ASC");
        }

        public List<DateTime> GetBarServedOrdersGroupedByDateTimeDescDB()
        {
            return BaseGetOrderByStatusGroupedByDateTimeDB("bar", "Served", "DESC");
        }



        //method to create a special search request from the database based on datetime and ordernumber
        public List<Order> GetKitchenBeingPreparedSpecialOrdersDB(DateTime time, int orderid)
        {
            string query = "SELECT O.id AS OrderId, C.date_time as [DateTime], handled_by, [table], C.id AS ContentId FROM[ORDER] AS O JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN MENU_ITEM AS M ON M.id = C.item_id WHERE(M.category LIKE 'Lu%' OR M.category LIKE 'Di%') AND C.order_id = @orderid AND C.date_time = @datetime";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@orderid", orderid),
                new SqlParameter("@datetime", time)
            });

            return ReadTableData(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> GetBarBeingPreparedSpecialOrdersDB(DateTime time, int orderid)
        {
            string query = "SELECT O.id AS OrderId, C.date_time as [DateTime], handled_by, [table], C.id AS ContentId FROM[ORDER] AS O JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN MENU_ITEM AS M ON M.id = C.item_id WHERE M.category LIKE 'Dr%' AND C.order_id = @orderid AND C.date_time = @datetime";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@orderid", orderid),
                new SqlParameter("@datetime", time)
            });

            return ReadTableData(ExecuteSelectQuery(query, sqlParameters));
        }

        
            //Create new Order in the database
            public void InsertOrderDB (Order order)
        {
            string query = "INSERT INTO [ORDER] VALUES (@handled_by, @table)" +     // Don't touch this please
                "SELECT SCOPE_IDENTITY();";

            //string query = "INSERT INTO [ORDER] VALUES (@id, @handled_by, @table)" +
            // "SELECT SCOPE_IDENTITY();";                                                   //This is the exact sequence of the order colunms  
                                                                                            
                                                                        
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", order.Id ),
                new SqlParameter("@handled_by", order.HandledBy.Id),
                new SqlParameter("@table", order.Table.Id)
            });

            //Execute query and store the ID
            int identityId = ExecuteIdentityEditQuery(query, sqlParameters);

            string query2 = "";

            foreach(OrderMenuItem item in order.GetOrderMenuItems())
            {
                query2 += $"INSERT INTO [ORDER_CONTENT] VALUES (@order_id, {item.GetMenuItem().Id}, {item.Quantity}, @date_time, '{item.Status.ToString()}', '{item.Comment}') ";
            }


            SqlParameter[] sqlParameters2 = (new[]
            {
                    new SqlParameter("@order_id", identityId ),
                    new SqlParameter("@date_time", DateTime.Now),
            });

            ExecuteEditQuery(query2, sqlParameters2);
        }


        
        //generic method to alter status in the database based on datetime
        public void BaseUpdateStatusDB(string type, DateTime time)
        {
            string query;

            switch (type)
            {
                case "bar":
                    query = "UPDATE ORDER_CONTENT SET [status] = 'ReadyToServe' FROM ORDER_CONTENT AS OC JOIN MENU_ITEM AS MI ON MI.id = OC.item_id WHERE date_time = @time AND MI.category LIKE 'Dr%'";
                    break;
                case "kitchen":
                    query = "UPDATE ORDER_CONTENT SET [status] = 'ReadyToServe' FROM ORDER_CONTENT AS OC JOIN MENU_ITEM AS MI ON MI.id = OC.item_id WHERE date_time = @time AND (MI.category LIKE 'Lu%' OR MI.category LIKE 'Di%')";
                    break;
                default:
                    throw new Exception("incorrect input for type");
            }

            SqlParameter[] sqlParameters = (new[]
{
                new SqlParameter("@time", time)
            });

            ExecuteEditQuery(query, sqlParameters);
        }


        //methods to alter status in the database based on datetime
        public void UpdateBarStatusDB(DateTime time)
        {
            BaseUpdateStatusDB("bar", time);
        }

        public void UpdateKitchenStatusDB(DateTime time)
        {
            BaseUpdateStatusDB("kitchen", time);
        }


        //NEW
        public void RunningOrdersWaiterForBarDB()
        {
         //   string query = "SELECT O.id AS OrderId, E.id AS EmpId, E.name AS EmpName, position, D.id AS TableId, status FROM [ORDER] AS O JOIN EMPLOYEE AS E ON O.handled_by = E.id JOIN DINING_TABLE AS D ON O.table = D.id JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN";
        }

        public void RunningOrdersWaiterForKitchenDB()
        {

        }


              //  case "bar":
                   // query = "SELECT O.id AS OrderId, C.date_time as [DateTime], handled_by, [table], C.id AS ContentId FROM[ORDER] AS O JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN MENU_ITEM AS M ON M.id = C.item_id WHERE M.category LIKE 'Dr%' AND C.[status] = @status ORDER BY C.date_time";

               // case "kitchen":
                   // query = "SELECT O.id AS OrderId, C.date_time as [DateTime], handled_by, [table], C.id AS ContentId FROM[ORDER] AS O JOIN ORDER_CONTENT AS C ON O.id = C.order_id JOIN MENU_ITEM AS M ON M.id = C.item_id WHERE (M.category LIKE 'Lu%' OR M.category LIKE 'Di%') AND C.[status] = @status ORDER BY C.date_time";


    //NEW
    //Convert Order information from database to Order objects
    private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order((int)dr["OrderId"], new Employee((string)dr["EmpId"], (string)dr["EmpName"], (string)dr["position"]), new DiningTable((int)dr["TableId"], (string)dr["status"]));
                order.AddOrderItems(orderMenuItemDB.GetOrderMenuItemsByOrderIdDB((int)dr["OrderId"]));
                orders.Add(order);
            }
            return orders;
        }

        //makes list of datetimes sent by query
        private List<DateTime> ReadDateTime(DataTable dataTable)
        {
            List<DateTime> datetimes = new List<DateTime>();

            foreach (DataRow dr in dataTable.Rows)
            {
                datetimes.Add((DateTime)dr["date_time"]);
            }
            return datetimes;
        }

        // NEW
        //To check order status, a very different query is used, and thus a different read table
        private List<Order> ReadTablesByOrderStatus(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            List<int> orderTracker = new List<int>();

            foreach (DataRow dr in dataTable.Rows)
            {
                if (!orderTracker.Contains((int)dr["OrderId"]))
                {
                    orderTracker.Add((int)dr["OrderId"]);
                    Order order = new Order((int)dr["OrderId"], new Employee((string)dr["EmpId"], (string)dr["EmpName"], (string)dr["position"]), new DiningTable((int)dr["TableId"], (string)dr["TableStatus"]));
                    orders.Add(order);
                }

                foreach (Order order in orders)
                {
                    if(order.Id == (int)dr["OrderId"])
                    {
                        order.AddOrderItem(orderMenuItemDB.GetOrderMenuItemByIdentityDB((int)dr["ContentId"]));
                        break;
                    }
                }              
            }
            return orders;
        }

        //OLD
        private List<Order> ReadTableData(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            List<int> orderTracker = new List<int>();

            foreach (DataRow dr in dataTable.Rows)
            {
                if (!orderTracker.Contains((int)dr["OrderId"]))
                {
                    orderTracker.Add((int)dr["OrderID"]);
                    Order order = new Order((int)dr["OrderId"], employeeDB.GetEmployeeByIdDB((string)dr["handled_by"]), diningTableDB.GetDiningTableByIdDB((int)dr["table"]));
                    orders.Add(order);
                }

                foreach (Order order in orders)
                {
                    if (order.Id == (int)dr["OrderId"])
                    {
                        order.AddOrderItem(orderMenuItemDB.GetOrderMenuItemByIdentityDB((int)dr["ContentId"]));
                        break;
                    }
                }
            }

            return orders;
        }
    }
}
