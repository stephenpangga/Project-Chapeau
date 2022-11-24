using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;


namespace ChapeauLogic
{
    public class OrderMenuItemService
    {
        OrderMenuItemDAO orderMenuItemDB = new OrderMenuItemDAO();

        public List<OrderMenuItem> GetAllOrderMenuItem()
        {
            try
            {
                return orderMenuItemDB.GetAllOrderMenuItemsDB();
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }

        public List<OrderMenuItem> GetOrderMenuItemsByOrder(int orderId)
        {
            try
            {
                return orderMenuItemDB.GetOrderMenuItemsByOrderIdDB(orderId);
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }

        public void InsertOrderMenuItem(List<OrderMenuItem> orderMenuItem, Order order)
        {
            try
            {
                orderMenuItemDB.InsertOrderMenuItemsForOrderDB(orderMenuItem, order);
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }

        public void ChangeOrderMenuItemStatus(List<OrderMenuItem> orderMenuItems, OrderStatus status)
        {
            try
            {
                orderMenuItemDB.ChangeOrderMenuItemStatusDB(orderMenuItems, status);
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }

        public void EditQuantityItem(OrderMenuItem orderMenuItem, int quantity)
        {
            try
            {
                orderMenuItemDB.RemoveOrderMenuItemDB(orderMenuItem, quantity);
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }

    }
}
