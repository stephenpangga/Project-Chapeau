using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;


namespace ChapeauLogic
{
    public class MenuItemService
    {
        MenuItemDAO menuItemDB = new MenuItemDAO();

        public List<MenuItem> GetAllMenuItems()
        {
            try
            {
                return menuItemDB.GetAllMenuItemsDB();
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }

        public MenuItem GetMenuItemById(int id)
        {
            try
            {
                return menuItemDB.GetMenuItemByIdDB(id);
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }

        public List<MenuItem> GetMenuItemsByCategory(MenuCategory category)
        {
            try
            {
                return menuItemDB.GetMenuItemsByCategory(category);
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }

        public void ChangeStock(MenuItem MenuItem)
        {
            try
            {
                menuItemDB.ChangeStockDB(MenuItem);
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }
    }
}
