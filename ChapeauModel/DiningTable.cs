using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class DiningTable
    {
        public int Id { get; set; }
        public TableStatus Status { get; set; }

        public DiningTable(int id, TableStatus status)
        {
            Id = id;
            Status = status;
        }

        public DiningTable(int id, string status)
        {
            Id = id;

            switch (status)
            {
                case "Free":
                    Status = TableStatus.Free;
                    break;
                case "Occupied":
                    Status = TableStatus.Occupied;
                    break;
                case "Reserved":
                    Status = TableStatus.Reserved;
                    break;
                default:
                    throw new Exception("Wrong string input for table status");
            }
        }
    }
}
