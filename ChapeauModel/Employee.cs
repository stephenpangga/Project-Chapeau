using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public EmployeePosition Position { get; set; }

        public Employee()
        {

        }

        public Employee(string id, string name, EmployeePosition employeePosition)
        {
            Id = id;
            Name = name;
            Position = employeePosition;
        }

        public Employee(string id, string name, string employeePosition)
        {
            Id = id;
            Name = name;

            switch (employeePosition)
            {
                case "Bartender":
                    Position = EmployeePosition.Bartender;
                    break;
                case "Waiter":
                    Position = EmployeePosition.Waiter;
                    break;
                case "Chef":
                    Position = EmployeePosition.Chef;
                    break;
                case "Manager":
                    Position = EmployeePosition.Manager;
                    break;
                default:
                    throw new Exception("Wrong string input for employee position");
            }
        }

    }
}
