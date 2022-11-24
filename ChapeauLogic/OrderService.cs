using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;



namespace ChapeauLogic
{
    public class OrderService
    {
        OrderDAO orderDB = new OrderDAO();

        //to get all the items ordered  from for the table
        OrderMenuItemDAO orderMenuItemDB = new OrderMenuItemDAO();

        public List<Order> GetAllOrders()
        {
            return orderDB.GetAllOrdersDB();
        }

        public Order GetOrderById(int id)
        {
            return orderDB.GetOrderByIdDB(id);
        }
        
        //get all the order for a table selected
        public Order GetCompleteActiveOrderByTable(DiningTable diningTable)
        {
            Order order = orderDB.GetActiveOrderByTableDB(diningTable);
            return order;
        }

        public List<Order> GetAllBarOrdersByOccupation()
        {
            return orderDB.GetAllBarOrdersByOccupationDB();
        }

        public List<Order> GetAllKitchenOrdersByOccupation()
        {
            return orderDB.GetAllKitchenOrdersByOccupationDB();
        }

        public List<Order> GetAllBarOrdersByDateTime(DateTime time)
        {
            return orderDB.GetAllBarOrdersByDateTimeDB(time);
        }

        public List<Order> GetAllKitchenOrdersByDateTime(DateTime time)
        {
            return orderDB.GetAllKitchenOrdersByDateTimeDB(time);
        }

        public List<Order> GetKitchenBeingPreparedOrders()
        {
            return orderDB.GetKitchenBeingPreparedOrdersDB();
        }

        public List<Order> GetKitchenReadyToServeOrders()
        {
            return orderDB.GetKitchenReadyToServeOrdersDB();
        }

        public List<Order> GetKitchenServedOrders()
        {
            return orderDB.GetKitchenServedOrdersDB();
        }
        


        public List<Order> GetBarBeingPreparedOrders()
        {
            return orderDB.GetBarBeingPreparedOrdersDB();
        }

        public List<Order> GetBarReadyToServeOrders()
        {
            return orderDB.GetBarReadyToServeOrdersDB();
        }

        public List<Order> GetBarServedOrders()
        {
            return orderDB.GetBarServedOrdersDB();
        }

        public List<DateTime> GetKitchenBeingPreparedOrdersGroupedByDateTime()
        {
            return orderDB.GetKitchenBeingPreparedOrdersGroupedByDateTimeDB();
        }
        public List<DateTime> GetKitchenReadyToServeOrdersGroupedByDateTime()
        {
            return orderDB.GetKitchenReadyToServeOrdersGroupedByDateTimeDB();
        }

        public List<DateTime> GetKitchenReadyToServeOrdersGroupedByDateTimeDesc()
        {
            return orderDB.GetKitchenReadyToServeOrdersGroupedByDateTimeDescDB();
        }

        public List<DateTime> GetKitchenServedOrdersGroupedByDateTime()
        {
            return orderDB.GetKitchenServedOrdersGroupedByDateTimeDB();
        }

        public List<DateTime> GetKitchenServedOrdersGroupedByDateTimeDesc()
        {
            return orderDB.GetKitchenServedOrdersGroupedByDateTimeDescDB();
        }

        public List<DateTime> GetBarBeingPreparedOrdersGroupedByDateTime()
        {
            return orderDB.GetBarBeingPreparedOrdersGroupedByDateTimeDB();
        }
        public List<DateTime> GetBarReadyToServeOrdersGroupedByDateTime()
        {
            return orderDB.GetBarReadyToServeOrdersGroupedByDateTimeDB();
        }

        public List<DateTime> GetBarReadyToServeOrdersGroupedByDateTimeDesc()
        {
            return orderDB.GetBarReadyToServeOrdersGroupedByDateTimeDescDB();
        }

        public List<DateTime> GetBarServedOrdersGroupedByDateTime()
        {
            return orderDB.GetBarServedOrdersGroupedByDateTimeDB();
        }

        public List<DateTime> GetBarServedOrdersGroupedByDateTimeDesc()
        {
            return orderDB.GetBarServedOrdersGroupedByDateTimeDescDB();
        }

        public List<Order> GetKitchenBeingPreparedSpecialOrders(DateTime time, int orderid)
        {
            return orderDB.GetKitchenBeingPreparedSpecialOrdersDB(time, orderid);
        }

        public List<Order> GetBarBeingPreparedSpecialOrders(DateTime time, int orderid)
        {
            return orderDB.GetBarBeingPreparedSpecialOrdersDB(time, orderid);
        }

        public void UpdateBarStatus(DateTime time)
        {
            orderDB.UpdateBarStatusDB(time);
        }

        public void UpdateKitchenStatus(DateTime time)
        {
            orderDB.UpdateKitchenStatusDB(time);
        }

        public void InsertOrder(Order order)
        {
            orderDB.InsertOrderDB(order);
        }
    }
}
