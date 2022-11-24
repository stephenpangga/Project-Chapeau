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
    public partial class PaymentForm : BaseForm
    {
        ChapeauLogic.OrderService payment = new ChapeauLogic.OrderService();
        ChapeauLogic.MenuItemService menuItemDB = new ChapeauLogic.MenuItemService();

        Order order;

        //values of counter
        decimal tip = 0;

        //for the type of payment
        string paymentType;

        public PaymentForm(Employee LoggedUser, LoginForm loginForm, Order order, TableViewForm tableView)
        {
            InitializeComponent();

            //Saving the user that is logged in and passing the login form, have it's reference
            LoggedInEmployee = LoggedUser;
            this.loginForm = loginForm;
            this.tableView = tableView;

            //Passing the order along that will be payed
            this.order = order;

        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            ListViewDesign();

            foreach (ChapeauModel.OrderMenuItem m in order.GetOrderMenuItems())
            {
                ListViewItem li = new ListViewItem(m.GetMenuItem().Id.ToString());
                li.SubItems.Add(m.GetMenuItem().Name);
                li.SubItems.Add(m.Quantity.ToString());
                li.SubItems.Add(m.GetMenuItem().Price.ToString("0.00"));
                lst_Payment.Items.Add(li);
            }

            //the display of the table number
            lbl_numberofT.Text = order.Table.Id.ToString();
            lbl_name.Text = order.HandledBy.Name.ToString();

            //information for the textboxes
            txt_Price.Text = order.CalculateTotalPrice().ToString("0.00");
            txt_TVAT.Text = order.CalculateTotalVAT().ToString("0.00");

            //to avoid input on the text
            txt_Price.Enabled = false;
            txt_TVAT.Enabled = false;
            txt_TotalAmount.Enabled = false;

            //this is for the total amount witout added tip
            txt_TotalAmount.Text = order.CalculateTotalAmount().ToString("0.00");
        }
        private void ListViewDesign()
        {
            //the list view design
            lst_Payment.GridLines = true;
            lst_Payment.View = View.Details;
            lst_Payment.Columns.Add("Menu Number", 150, HorizontalAlignment.Left);
            lst_Payment.Columns.Add("Name", 150, HorizontalAlignment.Left);
            lst_Payment.Columns.Add("Quantity", 100, HorizontalAlignment.Left);
            lst_Payment.Columns.Add("Price", 100, HorizontalAlignment.Left);
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            try
            {
                if (!radBtn_visa.Checked && !radBtn_PIN.Checked && !radBtn_Cash.Checked)
                    throw new Exception("please selecte a payment method");
                decimal tip;
                if (txt_Tip.Text == "")
                {
                    tip = 0;
                }
                else
                {
                    tip = decimal.Parse(txt_Tip.Text);
                }
                ChapeauLogic.PaymentService AddPayment = new ChapeauLogic.PaymentService();
                AddPayment.InsertPayment(new Payment(order, decimal.Parse(txt_Price.Text), tip, decimal.Parse(txt_TotalAmount.Text), paymentType,rtxt_FeedBack.Text));
                DialogResult dialogBox = MessageBox.Show("Payment complete");

                resetTextBox();
                Close();
                tableView.Show();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }

        }
        private void resetTextBox()
        {
            txt_Price.ResetText();
            txt_Tip.ResetText();
            txt_TotalAmount.ResetText();
            txt_TVAT.ResetText();
            rtxt_FeedBack.ResetText();
        }
        //when things are selected.
        private void listView_Payment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderOptionForm optionForm = new OrderOptionForm(LoggedInEmployee, this.loginForm, order, tableView);
            optionForm.ShowDialog();
        }

        private void radBtn_visa_CheckedChanged(object sender, EventArgs e)
        {
            paymentType = "CreditCard";
            Show_TipInfo();
        }

        private void radBtn_Cash_CheckedChanged(object sender, EventArgs e)
        {
            paymentType = "Cash";

            //hide the tip info when cash is clicked
            txt_Tip.Hide();
            lbl_Tip.Hide();
            lbl_euro3.Hide();
        }

        private void radBtn_PIN_CheckedChanged(object sender, EventArgs e)
        {
            paymentType = "Pin";
            Show_TipInfo();
        }

        //to show the tip info
        private void Show_TipInfo()
        {
            txt_Tip.Show();
            lbl_Tip.Show();
            lbl_euro3.Show();
        }

        private void txt_Tip_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txt_Tip.Text != "")
            {
                if (!int.TryParse(txt_Tip.Text, out i))
                {
                    DialogResult errorTip = MessageBox.Show("Wrong Input");
                }
                else
                {
                    //converting input tip to value to add to total amount
                    tip = int.Parse(txt_Tip.Text);

                    txt_TotalAmount.Text = (order.CalculateTotalAmount() + tip).ToString("0.00");
                }
            }
        }

        private void rtxt_FeedBack_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
