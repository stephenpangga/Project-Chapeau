using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Order
    {
        public int Id { get; set; }
        public Employee HandledBy { get; set; }
        public DiningTable Table { get; set; }

        public List<OrderMenuItem> content;

        
        public Order(int id, Employee employee, DiningTable table)
        {
            Id = id;
            HandledBy = employee;
            Table = table;
            content = new List<OrderMenuItem>();
        }

        //Çonstructor for new orders, because the Id had yet to be generated
        public Order(Employee employee, DiningTable table)
        {
            HandledBy = employee;
            Table = table;
            content = new List<OrderMenuItem>();
        }

        public void AddOrderItem(OrderMenuItem item)
        {
            content.Add(item);
        }

        public void AddOrderItems(List<OrderMenuItem> items)
        {
            foreach (OrderMenuItem item in items)
            {
                this.AddOrderItem(item);
            }
        }

        public List<OrderMenuItem> GetOrderMenuItems()
        {
            return this.content;
        }

        public void IncrementQuantityMenuItem(MenuItem menuItem)
        {
            foreach(OrderMenuItem orderMenuItem in content){
                if (orderMenuItem.GetMenuItem().Id == menuItem.Id)
                {
                    orderMenuItem.Quantity++;
                    break;
                }
            }
        }

        public decimal CalculateTotalPrice()
        {
            decimal totalprice=0;
            foreach (OrderMenuItem item in this.content)
            {
                totalprice += item.calcTotalForEachItem;
            }
            return totalprice;
        }

        public decimal CalculateTotalVAT()
        {
            decimal totalVAT = 0;
            foreach (OrderMenuItem VAT in this.content)
            {
                totalVAT += VAT.calcTotalVATForEachItem;
            }
            return totalVAT;
        }
        public decimal CalculateTotalAmount()
        {
            return CalculateTotalPrice() + CalculateTotalVAT();
        }
    }
}
