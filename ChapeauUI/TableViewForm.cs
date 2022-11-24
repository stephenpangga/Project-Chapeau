using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;

namespace ChapeauUI
{
    public partial class TableViewForm : BaseForm
    {
        //"constant" colors of the table
        Color FREE_COLOR = Color.FromArgb(51, 255, 119); // Green
        Color OCCUPIED_COLOR = Color.FromArgb(0, 102, 153); // Blue
        Color RESERVED_COLOR = Color.FromArgb(255, 102, 102); // Red

        //"constant" colors of the notification buttons
        //Color NOTIFICATION_COLOR = Color.FromArgb(255, 102, 102);
        //Color NO_NOTIFICATION_COLOR = Color.LightGray;


        //constant tablebutton size
        const int SIZE = 150;

        //a List variable that stores the "current list of tables", used to check if the tables have changed in anyway
        List<DiningTable> currentTables = new List<DiningTable>();

        List<Order> currentBarOrders = new List<Order>();
        List<Order> currentKitchenOrders = new List<Order>();

        //Creation of service objects used to communicated with the database
        DiningTableService diningTableDB = new DiningTableService();
        OrderService orderDB = new OrderService();
        OrderMenuItemService orderMenuItemDB = new OrderMenuItemService();

        //Save what notification panel is active, so only that panel gets displayed
        string activePanel = "";

        public TableViewForm(Employee LoggedUser, LoginForm loginForm)
        {
            InitializeComponent();

            //Saving the user that is logged in and passing the login form, have it's reference
            LoggedInEmployee = LoggedUser;
            this.loginForm = loginForm;            
        }

        private void TableViewForm_Load(object sender, EventArgs e)
        {
            // Assign the right colors to the table legend
            lbl_FreeColor.BackColor = FREE_COLOR;
            lbl_OccupiedColor.BackColor = OCCUPIED_COLOR;
            lbl_ReservedColor.BackColor = RESERVED_COLOR;

            //Hide and disable features in notifications panel
            pnl_Notifications.Hide();
            lst_OrderContentWaiter.Enabled = false;
            pic_NotificationBar.Hide();
            pic_NotificationKitchen.Hide();

            //Get the current tables and orders
            currentTables = diningTableDB.GetDiningTables();

            currentBarOrders = orderDB.GetBarReadyToServeOrders();
            currentBarOrders.AddRange(orderDB.GetBarBeingPreparedOrders());

            currentKitchenOrders = orderDB.GetKitchenReadyToServeOrders();
            currentKitchenOrders.AddRange(orderDB.GetKitchenBeingPreparedOrders());

            //Run code to display tables
            DisplayTables();

            //Check notifications
            CheckBarNotification();
            CheckKitchenNotification();


            //
        }

        public void RefreshTable()
        {
            DisplayTables();
        }

        private void DisplayTables()
        {

            flpnl_DiningTables.Controls.Clear();

            // Used loop to fill the flow panel with buttons for all the tables
            foreach (DiningTable table in currentTables)
            {
                BaseButton button = new BaseButton
                {
                    Size = new Size(SIZE, SIZE),
                    Font = new Font("Arial", 40, FontStyle.Bold),
                    Text = table.Id.ToString(),
                    BackColor = DetermineTableColor(table),
                    Tag = table
                };

                button.Click += new EventHandler(Table_Click);
                flpnl_DiningTables.Controls.Add(button);
            }         
        }

        //Method for filling the Orders listview
        private void DisplayOrders(List<Order> orders)
        {
            lst_OrdersWaiter.Clear();
            lst_OrderContentWaiter.Clear();

            lst_OrdersWaiter.GridLines = true;
            lst_OrdersWaiter.View = View.Details;
            lst_OrdersWaiter.FullRowSelect = true;

            lst_OrdersWaiter.Columns.Add("Table", 80);
            lst_OrdersWaiter.Columns.Add("Status",200);
            lst_OrdersWaiter.Columns.Add("# Items", 100);
            lst_OrdersWaiter.Columns.Add("Time ordered",120);

            foreach (Order order in orders)
            {
                ListViewItem li = new ListViewItem(order.Table.Id.ToString());
                li.Tag = order;
                if (order.content[0].Status == OrderStatus.ReadyToServe)
                {
                    li.ForeColor = Color.Green;
                } else
                {
                    li.ForeColor = Color.Red;
                }
                //Getting first item in the list to get extra information
                OrderMenuItem item = order.content[0];

                li.SubItems.Add(item.Status.ToString());
                li.SubItems.Add(order.content.Count().ToString());
                li.SubItems.Add(item.TimeStamp.ToString("HH:mm:ss"));

                lst_OrdersWaiter.Items.Add(li);
            }
        }

        //Show bar orders in the listview
        private void DisplayBarOrders()
        {
            DisplayOrders(currentBarOrders);
        }

        //show kitchen orders in the listview
        private void DisplayKitchenOrders()
        {
            DisplayOrders(currentKitchenOrders);
        }

        //Display content of selected order
        private void DisplayOrderContent(Order order)
        {
            lst_OrderContentWaiter.Clear();

            lst_OrderContentWaiter.GridLines = true;
            lst_OrderContentWaiter.View = View.Details;
            lst_OrderContentWaiter.FullRowSelect = true;

            lst_OrderContentWaiter.Columns.Add("Name", 200);
            lst_OrderContentWaiter.Columns.Add("Quantity", 110);

            foreach (OrderMenuItem menuItem in order.content)
            {
                ListViewItem li = new ListViewItem(menuItem.GetMenuItem().Name);
                li.Tag = menuItem;

                li.SubItems.Add(menuItem.Quantity.ToString());
                lst_OrderContentWaiter.Items.Add(li);
            }
        }

        //Method to check if tables have changed (separated for better readability)
        private bool AreTablesChanged()
        {
            List<DiningTable> tablesInDatabase = diningTableDB.GetDiningTables();

            foreach(DiningTable table in currentTables)
            {
                if(table.Status != tablesInDatabase[currentTables.IndexOf(table)].Status)
                {
                    currentTables = tablesInDatabase;
                    return true;
                }
            }

            return false;
        }

        //Checking if bar order status has changed
        private bool AreBarOrdersChanged()
        {
            List<Order> barInDatabase = orderDB.GetBarReadyToServeOrders();
            barInDatabase.AddRange(orderDB.GetBarBeingPreparedOrders());

            if (barInDatabase.Count != currentBarOrders.Count)
            {
                currentBarOrders = barInDatabase;
                return true;
            }

            foreach (Order order in currentBarOrders)
            {
                if (order.content[0].Status != barInDatabase[currentBarOrders.IndexOf(order)].content[0].Status)
                {
                    currentBarOrders = barInDatabase;
                    return true;
                }
            }

            return false;
        }

        //Checking if kitchenorder status has changed
        private bool AreKitchenOrdersChanged()
        {
            List<Order> kitchenInDatabase = orderDB.GetKitchenReadyToServeOrders();
            kitchenInDatabase.AddRange(orderDB.GetKitchenBeingPreparedOrders());

            if (kitchenInDatabase.Count != currentKitchenOrders.Count)
            {
                currentKitchenOrders = kitchenInDatabase;
                return true;
            }

            foreach (Order order in currentKitchenOrders)
            {
                if (order.content[0].Status != kitchenInDatabase[currentKitchenOrders.IndexOf(order)].content[0].Status)
                {
                    currentKitchenOrders = kitchenInDatabase;
                    return true;
                }
            }
            return false;
        }



        // Method do determing the color of the table, fitting the table status
        private Color DetermineTableColor(DiningTable table)
        {
            switch (table.Status)
            {
                case TableStatus.Free:
                    return FREE_COLOR; // Green
                case TableStatus.Occupied:
                    return OCCUPIED_COLOR; // Blue
                case TableStatus.Reserved:
                    return RESERVED_COLOR; // Red                  
                default:
                    throw new Exception("Incorrect table status input");                    
            }
        }

        //Method that is called when a table is clicked
        private void Table_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            DiningTable table = (DiningTable)button.Tag;

            switch (table.Status)
            {
                case TableStatus.Free:
                    //Brings waiter to the table view
                    OrderForm orderForm = new OrderForm(LoggedInEmployee, loginForm, this, table);
                    orderForm.Show();
                    Hide();
                    break;
                case TableStatus.Occupied:
                    //Will change to current order overview eventually
                    OrderOptionForm optionForm = new OrderOptionForm(LoggedInEmployee, loginForm, orderDB.GetCompleteActiveOrderByTable(table), this);
                    optionForm.Show();
                    Hide();
                    break;
                case TableStatus.Reserved:
                    MessageBox.Show("Table is reserved has the right guest arrived?"); // Some other code
                    OrderForm orderForm1 = new OrderForm(LoggedInEmployee, loginForm, this, table);
                    orderForm1.Show();
                    break;                 
                default:
                    throw new Exception("Incorrect table status input");
            }
        }

        private void flpnl_DiningTables_Paint(object sender, PaintEventArgs e)
        {

        }

        // Reload TableView flow panel on every tick
        private void tableViewRefresher_Tick(object sender, EventArgs e)
        {
            if (AreTablesChanged())
            {
                DisplayTables();
            }
        }

        //Method that checks the order status with every tick
        private void ordersWaiterRefresher_Tick(object sender, EventArgs e)
        {

            if (AreBarOrdersChanged() && activePanel == "Bar"){
                DisplayBarOrders();
            }

            if (AreKitchenOrdersChanged() && activePanel == "Kitchen")
            {
                DisplayKitchenOrders();
            }

            CheckBarNotification();
            CheckKitchenNotification();
        }

        //Checks if the bar has something that is ready to serve
        private void CheckBarNotification()
        {
            bool checker = false;

            foreach (Order order in currentBarOrders)
            {
                if(order.content[0].Status == OrderStatus.ReadyToServe)
                {
                    checker = true;
                    pic_NotificationBar.Show();
                }
            }
            if (!checker)
            {
                pic_NotificationBar.Hide();
            }
        }

        //Checks if the kitchen has something that is ready to serve
        private void CheckKitchenNotification()
        {
            bool checker = false;

            foreach (Order order in currentKitchenOrders)
            {
                if (order.content[0].Status == OrderStatus.ReadyToServe)
                {
                    checker = true;
                    pic_NotificationKitchen.Show();
                }
            }
            if (!checker)
            {
                pic_NotificationKitchen.Hide();
            }
        }

        private void btn_hidePanel_Click(object sender, EventArgs e)
        {
            pnl_Notifications.Hide();
            activePanel = "";
            lst_OrderContentWaiter.Clear();
        }


        //Clicking bar button show the panel and fills the list view
        private void btn_BarNotifications_Click(object sender, EventArgs e)
        {
            DisplayBarOrders();
            activePanel = "Bar";
            pnl_Notifications.Show();
        }
        
        //Clicking kitchen button show the panel and fills the list view
        private void btn_KitchenNotifications_Click(object sender, EventArgs e)
        {
            DisplayKitchenOrders();
            activePanel = "Kitchen";
            pnl_Notifications.Show();
        }

        //Event handler for selecting and order, the order content will be visable
        private void lst_OrdersWaiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_OrdersWaiter.SelectedItems.Count == 0)
            {
                return;
            }

            Order order = (Order)lst_OrdersWaiter.SelectedItems[0].Tag;
            DisplayOrderContent(order);
        }

        private void btn_Served_Click(object sender, EventArgs e)
        {
            orderMenuItemDB.ChangeOrderMenuItemStatus(((Order)lst_OrdersWaiter.SelectedItems[0].Tag).content, OrderStatus.Served);

            CheckBarNotification();
            CheckKitchenNotification();
        }
    }
}
