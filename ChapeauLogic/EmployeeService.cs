using System;
using ChapeauDAL;
using ChapeauModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauLogic
{
    public class EmployeeService
    {
        EmployeeDAO EmployeeDB = new EmployeeDAO();

        public List<Employee> GetEmployees()
        {
            try
            {
                return EmployeeDB.GetAllEmployeesDB();
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }

        public Employee GetEmployee(string id)
        {
            try
            {
                return EmployeeDB.GetEmployeeByIdDB(id);
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }

        public bool CheckUsername(string id)
        {
            try
            {
                return EmployeeDB.CheckUsernameDB(id);
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }

        }

        public bool CheckPassword(string id, string password)
        {
            try
            {
                return EmployeeDB.CheckPasswordDB(id, password);
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }

        }
    }
}
