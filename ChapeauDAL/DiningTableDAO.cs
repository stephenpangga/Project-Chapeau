using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;//added this to use the model library -stephen
using System.Data;// to use the datable
using System.Data.SqlClient;// for the query

namespace ChapeauDAL
{
    public class DiningTableDAO : Base
    {
        //Get all DiningTables from the database
        public List<DiningTable> GetAllDiningTablesDB()
        {
            string query = "SELECT id, status FROM DINING_TABLE ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Get DiningTable from database by id
        public DiningTable GetDiningTableByIdDB(int id)
        {
            string query = "SELECT id, status FROM DINING_TABLE WHERE id = @id";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        //Change the status of a table
        public void ChangeDiningTableStatusDB(DiningTable diningTable)
        {
            // SOME CODEE
            string query = "UPDATE DINING_TABLE SET [status] = @status WHERE id = @id ";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@status", diningTable.Status.ToString()),//the ToString is to convert the enum to a word and store as a word not number.
                new SqlParameter("@id", diningTable.Id)
            });
            ExecuteEditQuery(query, sqlParameters);
        }


        //Convert DiningTable information from the database to DiningTable objects
        private List<DiningTable> ReadTables (DataTable dataTable)
        {
            List<DiningTable> Tables = new List<DiningTable>();

            foreach (DataRow dr in dataTable.Rows)
            {
                DiningTable DiningTable = new DiningTable((int)dr["id"], (string)dr["status"]);
                Tables.Add(DiningTable);
            }

            return Tables;
        }
    }
}
