using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauLogic
{
    public class DiningTableService
    {
        DiningTableDAO diningTableDB = new DiningTableDAO();

        public List<DiningTable> GetDiningTables()
        {
            try
            {
                return diningTableDB.GetAllDiningTablesDB();
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }

        public DiningTable GetDiningTable(int id)
        {
            try
            {
                return diningTableDB.GetDiningTableByIdDB(id);
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }

        public void ChangeDiningTableStatus(DiningTable diningTable)
        {
            try
            {
                diningTableDB.ChangeDiningTableStatusDB(diningTable);
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }
    }
}
