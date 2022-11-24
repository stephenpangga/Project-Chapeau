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
    public partial class BaseForm : Form
    {
        public LoginForm loginForm;
        protected Employee LoggedInEmployee;
        public TableViewForm tableView;

        //public static Employee LoggedInEmployee; //just to check the payment

        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            if(LoggedInEmployee != null)
            {
                lbl_LoggedUser.Text = LoggedInEmployee.Name;
            } else
            {
                lbl_LoggedUser.Hide();
                lbl_User.Hide();
            }

        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            //Showing the loginForm again and hiding current form
            loginForm.EmptyUserInput();
            loginForm.Show();

            if (LoggedInEmployee.Position != EmployeePosition.Bartender & LoggedInEmployee.Position != EmployeePosition.Chef)
            {
                tableView.Close();
            }

            LoggedInEmployee = null;
            Close();
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void lbl_LoggedUser_Click(object sender, EventArgs e)
        {

        }

        private void clock_Tick(object sender, EventArgs e)
        {
            lbl_Clock.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
