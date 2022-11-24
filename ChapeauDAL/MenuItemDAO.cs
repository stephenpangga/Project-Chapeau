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
    public class MenuItemDAO : Base
    {
        //Get all MenuItems from the database
        public List<MenuItem> GetAllMenuItemsDB()
        {
            string query = "SELECT I.id AS ItemId, I.name AS ItemName, price, stock, C.id AS CatId, C.name AS CatName, vat FROM MENU_ITEM AS I JOIN MENU_CATEGORY AS C ON I.category = C.id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Get a MenuItem from database by id
        public MenuItem GetMenuItemByIdDB(int id)
        {
            string query = "SELECT I.id AS ItemId, I.name AS ItemName, price, stock, C.id AS CatId, C.name AS CatName, vat FROM MENU_ITEM AS I JOIN MENU_CATEGORY AS C ON I.category = C.id WHERE id = @id";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        //Get MenuItems from database by category
        public List<MenuItem> GetMenuItemsByCategory(MenuCategory category)
        {
            string query = "SELECT I.id AS ItemId, I.name AS ItemName, price, stock, C.id AS CatId, C.name AS CatName, vat FROM MENU_ITEM AS I JOIN MENU_CATEGORY AS C ON I.category = C.id WHERE category = @category";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@category", category.Id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Change stock of MenuItem in the database
        public void ChangeStockDB(MenuItem menuItem)
        {
            //Somecode

            //////int reducedStock;

            //////string query = "UPDATE MENU_ITEM SET id = {id}, WHERE id = @id";

        }

        //Convert MenuItem information to MenuItem Objects
        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem((int)dr["ItemId"], (string)dr["ItemName"], (decimal)dr["price"], (int)dr["stock"], new MenuCategory((string)dr["CatId"], (string)dr["CatName"], (decimal)dr["vat"]));
                menuItems.Add(menuItem);
            }
            return menuItems;
        }
    }
}
