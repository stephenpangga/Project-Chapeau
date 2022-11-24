using System;
using ChapeauModel;
using ChapeauLogic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            OrderService orderService = new OrderService();

            List<Order> bar = orderService.GetBarBeingPreparedOrders();
            Console.WriteLine("Orders for Bar Being prepared");
            foreach(Order order in bar)
            {
                Console.WriteLine($"ID:{order.Id}, Table {order.Table}");
                foreach(OrderMenuItem item in order.content)
                {
                    Console.WriteLine($"{item.GetMenuItem().Name}, {item.Quantity}, {nameof(item.Status)}, {item.TimeStamp}");
                }
                Console.WriteLine();

            }

            List<Order> kitchen = orderService.GetKitchenServedOrders();
            Console.WriteLine("Orders for Kitchen Served");
            Console.WriteLine($"");
            foreach (Order order in kitchen)
            {
                Console.WriteLine($"ID:{order.Id}, Table {order.Table}");
                foreach (OrderMenuItem item in order.content)
                {
                    Console.WriteLine($"{item.GetMenuItem().Name}, {item.Quantity}, {nameof(item.Status)}, {item.TimeStamp}");
                }
                Console.WriteLine();

            }

            Console.ReadKey();

        }
        //to check for payment data...
        void Start2()
        {
            OrderService orderService = new OrderService();
            // MenuItemService menuItemDB = new MenuItemService();

            Order order = orderService.GetCompleteActiveOrderByTable(new DiningTable(1, TableStatus.Occupied));

            foreach (OrderMenuItem m in order.content)
            {
                Console.WriteLine($"{m.GetMenuItem().Name}");
                Console.WriteLine(m.calcTotalForEachItem.ToString("0.0"));
                
            }
            Console.WriteLine(order.CalculateTotalPrice().ToString("0.00"));
            
            //Console.WriteLine(order.content[0].calcTotalForEachItem.ToString("0.0"));

            Console.ReadKey();

        }
    }
}
