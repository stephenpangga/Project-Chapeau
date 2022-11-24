using System;
using ChapeauModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class MenuCategoryDAO : Base
    {
        //Get all Categories from the database
        public List<MenuCategory> GetAllMenuCategoriesDB()
        {
            string query = "SELECT id, name, vat FROM MENU_CATEGORY";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Get category from database by id
        public MenuCategory GetMenuCategoryByIdDB(string id)
        {
            string query = "SELECT id, name, vat FROM MENU_CATEGORY WHERE id = @id";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        //Get all the categories that are part of Drinks
        public List<MenuCategory> GetDrinkCategoriesDB()
        {
            string query = "SELECT id, name, vat FROM MENU_CATEGORY WHERE id LIKE 'Dr%'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Get all the categories that are part of Lunch
        public List<MenuCategory> GetLunchCategoriesDB()
        {
            string query = "SELECT id, name, vat FROM MENU_CATEGORY WHERE id LIKE 'Lu%'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Get all the categories that are part of Diner
        public List<MenuCategory> GetDinnerCategoriesDB()
        {
            string query = "SELECT id, name, vat FROM MENU_CATEGORY WHERE id LIKE 'Di%'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Convert category information from database to category object
        private List<MenuCategory> ReadTables (DataTable dataTable)
        {
            List<MenuCategory> menuCategories = new List<MenuCategory>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuCategory menuCategory = new MenuCategory((string)dr["id"], (string)dr["name"], (decimal)dr["vat"]);
                menuCategories.Add(menuCategory);
            }
            return menuCategories; 
        }
    }
}
