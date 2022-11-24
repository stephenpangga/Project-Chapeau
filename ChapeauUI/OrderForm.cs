 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;

namespace ChapeauUI
{
    public partial class OrderForm : BaseForm
    {
        const int SIZE = 110;

        DiningTable table;

        ChapeauLogic.OrderService orderDB = new ChapeauLogic.OrderService();
        DiningTableService tableDB = new DiningTableService();

        MenuCategoryService menuCategoryDB = new MenuCategoryService();
        MenuItemService menuItemDB = new MenuItemService();


        public OrderForm(Employee LoggedUser, LoginForm loginForm, TableViewForm tableView, DiningTable diningTable)
        {
            InitializeComponent();

            //Saving the user that is logged in and passing the login form, have it's reference
            LoggedInEmployee = LoggedUser;
            this.loginForm = loginForm;
            this.tableView = tableView;

            table = diningTable;
            DisplayMainCatagories();
        }


        private void OrderForm_Load(object sender, EventArgs e)
        {
            lbl_Comment.Hide();
            rtxt_CommentOrder.Hide();
            btn_ConfirmComment.Hide();

            lst_NewOrderItems.Clear();
            
            //Creating list view for NewOrderItems
            lst_NewOrderItems.GridLines = true;

            lst_NewOrderItems.View = View.Details;
            lst_NewOrderItems.Columns.Add("name", 240, HorizontalAlignment.Left);
            lst_NewOrderItems.Columns.Add("price", 72, HorizontalAlignment.Left);
            lst_NewOrderItems.Columns.Add("stock", 72, HorizontalAlignment.Left);
        

        }

        private void lst_NewOrderItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      


        private void flpnl_MainCatagories_Paint(object sender, PaintEventArgs e)
        {

        }


        //Creating MainCatagory buttons
        private void DisplayMainCatagories()
        {
            //Refreshing the flpnl_mainCatagory
            flpnl_MainCatagories.Controls.Clear();   

            List<string> mainCatagories = new List<string>();

            mainCatagories.Add("Lunch");
            mainCatagories.Add("Diner");
            mainCatagories.Add("Drinks");
 
            foreach (string catagory in mainCatagories)
            {
                BaseButton button = new BaseButton
                {
                    Size = new Size((int)(1.1 * SIZE), (int)(0.6 * SIZE)),
                    Text = catagory,
                    BackColor = Color.FromArgb(157, 105, 163),
                    Tag = catagory
                };
                button.Click += new EventHandler(Catagory_Click);
                flpnl_MainCatagories.Controls.Add(button);
            }
         
        }

        //Creating SubCatagory buttons

        private void DisplaySubCategories(string mainCategory)
        {
            flpnl_SubCatagories.Controls.Clear();

            List<MenuCategory> menuCategories = new List<MenuCategory>();

            switch (mainCategory)
            {
                case "Lunch":
                    menuCategories = menuCategoryDB.GetLunchCategories();
                    break;

                case "Diner":
                    menuCategories = menuCategoryDB.GetDinnerCategories();
                    break;

                case "Drinks":
                    menuCategories = menuCategoryDB.GetDrinkCategories();
                    break;
                default:
                    break;

            }

            //Button for SubCatagories items
            foreach (MenuCategory menuCategory in menuCategories)
            {
                BaseButton btn_LunchItems = new BaseButton
                {
                    Size = new Size((int)(1.1 * SIZE), (int)(0.6 * SIZE)),
                    Text = menuCategory.Name,
                    //BackColor = Color.FromArgb(157, 105, 163),
                    BackColor = Color.FromArgb(255, 127, 0),
                    Tag = menuCategory
                };
                btn_LunchItems.Click += new EventHandler(SubCatagory_Click);
                flpnl_SubCatagories.Controls.Add(btn_LunchItems);
            }



        }

        //subcatagory event handler
        private void Catagory_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string catagory = (string)button.Tag;

            DisplaySubCategories(catagory);

        }

        private void SubCatagory_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MenuCategory Subcatagory = (MenuCategory)button.Tag;

            DisplaySubCatogoriesItems(Subcatagory);
        }

        private void DisplaySubCatogoriesItems(MenuCategory menuCategory)
        {
            flpnl_SubCatagoryItems.Controls.Clear();
            List<ChapeauModel.MenuItem> menuItems = new List<ChapeauModel.MenuItem>();

            //....
            menuItems = menuItemDB.GetMenuItemsByCategory(menuCategory);

            foreach (ChapeauModel.MenuItem menuItem in menuItems)
            {
                BaseButton btn_menuItems = new BaseButton
                {
                    Size = new Size((int)(1 * SIZE), (int)(0.4 * SIZE)),
                    Text = menuItem.Name,
                    BackColor = Color.FromArgb(144, 238, 144),
                    Tag = menuItem
                };
                btn_menuItems.Click += new EventHandler(btn_menuItem_Click);
                flpnl_SubCatagoryItems.Controls.Add(btn_menuItems);
            }

        }


        private void btn_menuItem_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ChapeauModel.MenuItem menuItem = (ChapeauModel.MenuItem)button.Tag;

            ListViewItem li = new ListViewItem(menuItem.Name);//needs to fix this because stock quantity is taken rather than order quantity

            OrderMenuItem orderMenuItem = new OrderMenuItem(menuItem);

            li.Tag = orderMenuItem;  //linking menuItem to the entry of the list

            li.SubItems.Add(menuItem.Price.ToString("0.00"));
            li.SubItems.Add(menuItem.Stock.ToString());
            li.SubItems.Add(menuItem.Category .ToString());
            lst_NewOrderItems.Items.Add(li);
        }

        private void btn_LunchBiteItems_Click(object sender, EventArgs e)
        {
        }
        private void btn_LunchSpecialItems_Click(object sender, EventArgs e)
        {
        }
     
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }


        private void btn_ConfirmOrder_Click(object sender, EventArgs e)
        {
           
                List<ChapeauModel.MenuItem> itemsAdded = new List<ChapeauModel.MenuItem>();

                Order order = new Order(LoggedInEmployee, table);

                foreach(ListViewItem li in lst_NewOrderItems.Items)
                {
                    OrderMenuItem item = (OrderMenuItem)li.Tag;

                    if (itemsAdded.Contains(item.GetMenuItem()))
                    {
                        order.IncrementQuantityMenuItem(item.GetMenuItem());
                    } else
                    {
                        itemsAdded.Add(item.GetMenuItem());
                        item.Quantity = 1;
                        item.Status = OrderStatus.BeingPrepared;
                        item.TimeStamp = DateTime.Now;
                        order.content.Add(item);
                }
                    order.content.Add(item);
                }
                orderDB.InsertOrder(order);
            table.Status = TableStatus.Occupied;

            tableDB.ChangeDiningTableStatus(table);
            tableView.RefreshTable();
            tableView.Show();
            Close();

        }



        private void flpnl_SubCatagories_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_CommentOrder_Click(object sender, EventArgs e)
        {
            btn_ConfirmComment.Show();
            lbl_Comment.Show();
            rtxt_CommentOrder.Show();
        }

        private void btn_NewOrderItemDelete_Click(object sender, EventArgs e)
        {
            lst_NewOrderItems.SelectedItems[0].Remove();
        }

        private void btn_NewOrderClearItems_Click(object sender, EventArgs e)
        {
            rtxt_CommentOrder.ResetText();

            lst_NewOrderItems.Items.Clear();

        }

        private void btn_NewOrderBack_Click(object sender, EventArgs e)
        {
            tableView.Show();
            Dispose();
        }

        private void rtxt_CommentOrder_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ConfirmComment_Click(object sender, EventArgs e)
        {
            OrderMenuItem item = (OrderMenuItem)lst_NewOrderItems.SelectedItems[0].Tag;
            item.Comment = rtxt_CommentOrder.Text;
            lst_NewOrderItems.SelectedItems[0].Tag = item;

            btn_ConfirmComment.Hide();
            lbl_Comment.Hide();
            rtxt_CommentOrder.Hide();


        }
    }
}
