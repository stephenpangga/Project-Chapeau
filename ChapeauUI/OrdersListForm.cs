using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Timers;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class OrdersListForm : BaseForm
    {
        //calling required services
        ChapeauLogic.OrderService OrderService = new ChapeauLogic.OrderService();

        //constants
        const int SIZE = 100;

        //fields
        EmployeePosition occupation;
        bool sortbyrunning = true;
        bool defaultsorting = true;
        DateTime time;
        int scrollposition = 0;

        //lists
        List<Image> TableImages;

        public OrdersListForm(Employee LoggedUser, LoginForm loginForm)
        {
            InitializeComponent();

            //Saving the user that is logged in and passing the login form, have it's reference
            LoggedInEmployee = LoggedUser;
            this.loginForm = loginForm;

            //preparation
            occupation = LoggedInEmployee.Position;
            ShowDefaultOrdersButtons();
            TableImages = CreateTableImagesList();
            EmptyAdditionalData();

            //start
            DisplayOrders();
        }

        private void OrdersListForm_Load(object sender, EventArgs e)
        {

        }

        private void DisplayOrders()
        {
            //preparation
            List<DateTime> OrdersTimeList = new List<DateTime>();

            //grabbing list of orders based on type
            if (defaultsorting == true)
            {
                OrdersTimeList = GetDefaultOrders();
            }
            else
            {
                OrdersTimeList = GetServedOrders();
            }

            //adding buttons based on datetime ordering
            AddOrderButtons(OrdersTimeList);

            //dispaying statuses
            timer_OrderListView.Start();
        }

        private List<DateTime> GetDefaultOrders()
        {
            List<DateTime> orderslist = new List<DateTime>();
            List<DateTime> beingpreparedorders = GetBeingPreparedOrdersGroupedByDateTime();
            List<DateTime> readytoserveorders = GetReadyToServeOrdersGroupedByDateTimeDesc();

            if (sortbyrunning == true)
            {
                //adding orders sorted by running
                foreach (DateTime time in beingpreparedorders)
                {
                    orderslist.Add(time);
                }
                foreach (DateTime time in readytoserveorders)
                {
                    orderslist.Add(time);
                }
            }
            else
            {
                //adding orders sorted by ready
                foreach (DateTime time in readytoserveorders)
                {
                    orderslist.Add(time);
                }
                foreach (DateTime time in beingpreparedorders)
                {
                    orderslist.Add(time);
                }
            } return orderslist;
        }

        private List<DateTime> GetServedOrders()
        {
            List<DateTime> servedorders = GetServedOrdersGroupedByDateTimeDesc();
            return servedorders;
        }

        private void AddOrderButtons(List<DateTime> OrdersTimeList)
        {
            List<Order> Orders = GetOrders(OrdersTimeList);

            foreach (Order order in Orders)
            {
                string status = order.content[0].Status.ToString();

                BaseButton button = new BaseButton
                {
                    Size = new Size((int)(SIZE * 2.65), (int)(SIZE * 1)),
                    Image = new Bitmap(TableImages[order.Table.Id], new Size(100, 100)),
                    ImageAlign = ContentAlignment.MiddleLeft,
                    BackColor = ButtonColorPicker(status),
                    Tag = order,
                    Padding = new Padding(0, 0, 25, 0),
                    TextAlign = ContentAlignment.MiddleRight,
                };
                button.Click += new EventHandler(Order_Click);
                flpnl_Orders.Controls.Add(button);
            }
        }

        private void Order_Click(object sender, EventArgs e)
        {
            //grabbing the object tag
            Order order = (Order)((Button)sender).Tag;

            //hiding the mark as ready button if it's ready or served
            string status = order.content[0].Status.ToString();

            if (status == "Served" | status == "ReadyToServe")
            {
                btn_MarkFinished.Hide();
            }
            else
            {
                btn_MarkFinished.Show();
            }

            //displaying all features
            DisplayAdditionalInfo(order);
            DisplayOrderContentList(order);

            //grabbing time for marking order as finished
            time = order.content[0].TimeStamp;
        }

        private void DisplayAdditionalInfo(Order order)
        {
            PicBox_TableNumber.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBox_TableNumber.Image = TableImages[order.Table.Id];
            lbl_OrderTime.Text = "Time Ordered: " + order.content[0].TimeStamp.ToString("HH:mm:ss");
            lbl_OrderStatus.Text = "Status: " + StatusTextConverter(order.content[0].Status.ToString());
            lbl_OrderHandledBy.Text = "Handled by: " + order.HandledBy.Name;
        }

        private void DisplayOrderContentList(Order order)
        {
            //clearing list view
            lst_Orders.Clear();

            //adding columns and items to the list view
            lst_Orders.GridLines = true;
            lst_Orders.View = View.Details;
            lst_Orders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lst_Orders.Columns.Add("Amount", 70, HorizontalAlignment.Left);
            lst_Orders.Columns.Add("Order", 150, HorizontalAlignment.Left);
            lst_Orders.Columns.Add("Comment", 600, HorizontalAlignment.Left);

            foreach (OrderMenuItem item in order.content)
            {
                ListViewItem li = new ListViewItem(item.Quantity.ToString());
                li.SubItems.Add(item.GetMenuItem().Name);
                li.SubItems.Add(item.Comment);
                lst_Orders.Items.Add(li);
            }
        }

        //sort by running click
        private void Btn_SortByRunning_Click(object sender, EventArgs e)
        {
            //prepping the sorting method
            sortbyrunning = true;
            EmptyAdditionalData();

            DisplayOrders();
        }

        //sort by ready click
        private void Btn_SortByFinished_Click(object sender, EventArgs e)
        {
            //setting the sorting method bool
            sortbyrunning = false;
            EmptyAdditionalData();

            DisplayOrders();
        }

        //updating order as ready
        private void Btn_MarkFinished_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus();
            EmptyAdditionalData();

            DisplayOrders();
        }

        //gets the requested orders and returns a list of segmented orders from all orders
        private List<Order> GetOrders(List<DateTime> Time)
        {
            List<Order> allorders = GetAllOrdersByOccupation();
            List<Order> selectedorders = new List<Order>();
            List<OrderMenuItem> menuitems = new List<OrderMenuItem>();

            foreach (DateTime time in Time)
            {
                foreach (ChapeauModel.Order order in allorders)
                {
                    foreach (OrderMenuItem item in order.content)
                    {
                        if (time == item.TimeStamp)
                        {
                            menuitems.Add(item);
                        }
                    }

                    if (menuitems.Any())
                    {
                        selectedorders.Add(new Order(order.Id, order.HandledBy, order.Table));
                        selectedorders[selectedorders.Count - 1].AddOrderItems(menuitems);
                        menuitems.Clear();
                        break;
                    }
                }
            }

            return selectedorders;
        }

        //creates a list of images
        private List<Image> CreateTableImagesList()
        {
            List<Image> images = new List<Image>();

            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_1.PNG"));
            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_1.PNG"));
            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_2.PNG"));
            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_3.PNG"));
            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_4.PNG"));
            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_5.PNG"));
            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_6.PNG"));
            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_7.PNG"));
            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_8.PNG"));
            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_9.PNG"));
            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_10.PNG"));

            return images;
        }

        //returns a color based on the status of an order
        private Color ButtonColorPicker(string status)
        {
            Color color = Color.White;

            switch (status)
            {
                case "BeingPrepared": color = Color.LightGreen; break;
                case "ReadyToServe": color = Color.Cyan; break;
                case "Served": color = Color.LightGray; break;
                default: color = Color.Red; break;
            }

            return color;
        }

        //converts the status for the order list view
        private string StatusTextConverter(string status)
        {
            switch (status)
            {
                case "ReadyToServe": return "Ready"; break;
                case "BeingPrepared": return "Running"; break;
                case "Served": return "Finished"; break;
                default: return "Oopsie"; break;
            }
        }

        //empties additional info data from order list table
        private void EmptyAdditionalData()
        {
            PicBox_TableNumber.Image = null;
            lbl_OrderTime.Text = null;
            lbl_OrderStatus.Text = null;
            lbl_OrderHandledBy.Text = null;
            lst_Orders.Clear();
            btn_MarkFinished.Hide();
        }

        //shows the served orders
        private void Btn_ViewServedList_Click(object sender, EventArgs e)
        {
            ShowServedOrdersButtons();
            defaultsorting = false;

            DisplayOrders();
        }

        //shows the default orders
        private void Btn_ViewDefaultOrders_Click(object sender, EventArgs e)
        {
            ShowDefaultOrdersButtons();
            defaultsorting = true;

            DisplayOrders();
        }

        //shows the served sorting buttons
        private void ShowServedOrdersButtons()
        {
            flpnl_Orders.Controls.Clear();
            EmptyAdditionalData();
            btn_SortByFinished.Hide();
            btn_SortByRunning.Hide();
            lbl_SortBy.Hide();
            btn_ViewServedList.Hide();
            btn_ViewDefaultOrders.Show();
        }

        //shows the default sorting buttons
        private void ShowDefaultOrdersButtons()
        {
            flpnl_Orders.Controls.Clear();
            EmptyAdditionalData();
            btn_SortByFinished.Show();
            btn_SortByRunning.Show();
            lbl_SortBy.Show();
            btn_ViewServedList.Show();
            btn_ViewDefaultOrders.Hide();
        }

        //updating statuses
        private void Timer_OrderListView_Tick(object sender, EventArgs e)
        {
            // 1/2 this is for fixing a bug where the scroll position keeps getting set to 0 for every timer tick
            scrollposition = flpnl_Orders.VerticalScroll.Value;

            DateTime currenttime = DateTime.Now;
            Order order;

            foreach (Control ctrl in flpnl_Orders.Controls)
            {
                order = (Order)ctrl.Tag;
                string status = order.content[0].Status.ToString();

                if (status == "Served" | status == "ReadyToServe")
                {
                    ctrl.Text = StatusTextConverter(status);
                }
                else
                {
                    TimeSpan timedifference = (currenttime - order.content[0].TimeStamp);
                    ctrl.Text = ($"{timedifference.TotalMinutes:00} min\nRunning");
                }
            }

            // 2/2 this is for fixing a bug where the scroll position keeps getting set to 0 for every timer tick
            flpnl_Orders.AutoScrollPosition = new Point(0, scrollposition);
        }

        //methods for getting data from the database depending on current occupation
        private List<DateTime> GetBeingPreparedOrdersGroupedByDateTime()
        {
            if (occupation == EmployeePosition.Bartender)
            {
                return OrderService.GetBarBeingPreparedOrdersGroupedByDateTime();
            }
            else
            {
                return OrderService.GetKitchenBeingPreparedOrdersGroupedByDateTime();
            }
        }

        private List<DateTime> GetReadyToServeOrdersGroupedByDateTimeDesc()
        {
            if (occupation == EmployeePosition.Bartender)
            {
                return OrderService.GetBarReadyToServeOrdersGroupedByDateTimeDesc();
            }
            else
            {
                return OrderService.GetKitchenReadyToServeOrdersGroupedByDateTimeDesc();
            }
        }

        private List<DateTime> GetServedOrdersGroupedByDateTimeDesc()
        {
            if (occupation == EmployeePosition.Bartender)
            {
                return OrderService.GetBarServedOrdersGroupedByDateTimeDesc();
            }
            else
            {
                return OrderService.GetKitchenServedOrdersGroupedByDateTimeDesc();
            }
        }


        private List<Order> GetAllOrdersByOccupation()
        {
            if (occupation == EmployeePosition.Bartender)
            {
                return OrderService.GetAllBarOrdersByOccupation();
            }
            else
            {
                return OrderService.GetAllKitchenOrdersByOccupation();
            }
        }

        private void UpdateOrderStatus()
        {
            if (occupation == EmployeePosition.Bartender)
            {
                OrderService.UpdateBarStatus(time);
            }
            else
            {
                OrderService.UpdateKitchenStatus(time);
            }
        }





        //unused methods
        private void OrdersListForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void flpnl_Orders_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
