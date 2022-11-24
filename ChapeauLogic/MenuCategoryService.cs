using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class MenuCategoryService
    {
        MenuCategoryDAO menuCategoryDB = new MenuCategoryDAO();

        public List<MenuCategory> GetAllMenuCategories()
        {
            try
            {
                return menuCategoryDB.GetAllMenuCategoriesDB();
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }

        public MenuCategory GetMenuCategoryById(string id)
        {
            try
            {
                return menuCategoryDB.GetMenuCategoryByIdDB(id);
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }

        public List<MenuCategory> GetDrinkCategories()
        {
            try
            {
                return menuCategoryDB.GetDrinkCategoriesDB();
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }

        public List<MenuCategory> GetLunchCategories()
        {
            try
            {
                return menuCategoryDB.GetLunchCategoriesDB();
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }

        public List<MenuCategory> GetDinnerCategories()
        {
            try
            {
                return menuCategoryDB.GetDinnerCategoriesDB();
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }
    }
}
