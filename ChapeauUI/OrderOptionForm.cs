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
    public partial class OrderOptionForm : BaseForm
    {
        ChapeauLogic.OrderService payment = new ChapeauLogic.OrderService();
        ChapeauLogic.MenuItemService menuItemDB = new ChapeauLogic.MenuItemService();
        //EmployeeService EmployeeDB = new EmployeeService();


        Order order;

        public OrderOptionForm(Employee LoggedUser, LoginForm loginForm, Order order, TableViewForm tableView)
        {
            InitializeComponent();

            //Saving the user that is logged in and passing the login form, have it's reference
            LoggedInEmployee = LoggedUser;
            this.loginForm = loginForm;
            this.tableView = tableView;

            //Passing the order along that will be payed
            this.order = order;

        }

        private void lstview_CurrentOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void OrderOptionForm_Load(object sender, EventArgs e)
        {
            ListViewDesignOrderOption();

            FillListView();
            
            //to the show some information such as price and table number
            lbl_price.Text= order.CalculateTotalPrice().ToString("0.00");
            lbl_TableNr.Text = order.Table.Id.ToString();
        }

        private void ListViewDesignOrderOption()
        {
            //the list view design
            lst_CurrentOrder.GridLines = true;
            lst_CurrentOrder.View = View.Details;
            lst_CurrentOrder.FullRowSelect = true;
            lst_CurrentOrder.Columns.Add("Menu Number", 160, HorizontalAlignment.Left);
            lst_CurrentOrder.Columns.Add("Name", 170, HorizontalAlignment.Left);
            lst_CurrentOrder.Columns.Add("Quantity", 160, HorizontalAlignment.Left);
        }

        private void FillListView()
        {
            foreach (ChapeauModel.OrderMenuItem m in order.GetOrderMenuItems())
            {
                ListViewItem li = new ListViewItem(m.GetMenuItem().Id.ToString());
                li.SubItems.Add(m.GetMenuItem().Name);
                li.SubItems.Add(m.Quantity.ToString());
                lst_CurrentOrder.Items.Add(li);
                li.Tag = m;
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (lst_CurrentOrder.SelectedItems.Count == 0)
                {
                    return;
                }

                OrderMenuItem food = (OrderMenuItem)lst_CurrentOrder.SelectedItems[0].Tag;

                ChapeauLogic.OrderMenuItemService Insert_Values = new ChapeauLogic.OrderMenuItemService();
                Insert_Values.EditQuantityItem(food, int.Parse(txt_EditQuantity.Text));

                lst_CurrentOrder.Clear();
                ListViewDesignOrderOption();
                FillListView();//to update the listview when quantity change..                 
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            tableView.Show();
            Close();//close the form
        }

        private void Btn_Payment_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm(LoggedInEmployee,this.loginForm,order, tableView);
            paymentForm.ShowDialog();
            Close();
        }

        private void lst_CurrentOrder_MouseClick(object sender, MouseEventArgs e)
        {
            txt_menuItemName.Text = lst_CurrentOrder.SelectedItems[0].SubItems[1].Text;//this is for the name of the menu
            txt_menuItemName.Enabled = false;
            txt_EditQuantity.Text = lst_CurrentOrder.SelectedItems[0].SubItems[2].Text;//quantity of the menu
        }

        private void Btn_NewOrder_Click(object sender, EventArgs e)
        {            
            OrderForm orderForm = new OrderForm(LoggedInEmployee, this.loginForm, tableView, order.Table);
            orderForm.ShowDialog();
            Close();
        }
    }
}
