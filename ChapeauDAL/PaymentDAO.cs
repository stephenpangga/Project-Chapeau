using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.ObjectModel;
using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class PaymentDAO : Base
    {
        //Create OrderDAO object
        OrderDAO orderDB = new OrderDAO();

        //Get all Payments from the database
        public List<Payment> GetAllPaymentsDB()
        {
            string query = "SELECT order_id, total, tip, paid_amount, method FROM PAYMENT";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Get a payment from the database by it's order
        public Payment GetPaymentByOrder(Order order)
        {
            string query = "SELECT order_id, total, tip, paid_amount, method FROM PAYMENT";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@id", order.Id)
            });
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        //Create new payment in database
        public void InsertPaymentDB(Payment payment)
        {
            //Somecode
            string query = "INSERT INTO PAYMENT VALUES (@order_id, @total, @tip, @paid_amount, @method, @feedback)";
            SqlParameter[] sqlParameters = (new[]
            {
                new SqlParameter("@order_id",payment.Order.Id),
                new SqlParameter("@total",payment.Total),
                new SqlParameter("@tip", payment.Tip),
                new SqlParameter("@paid_amount", payment.AmountPaid),
                new SqlParameter("@method",payment.Method),
                new SqlParameter("@feedback",payment.Feedback)
            });
            ExecuteEditQuery(query, sqlParameters);
        }

        //Convert Payment information from the database to Payment objects
        private List<Payment> ReadTables(DataTable dataTable)
        {
            List<Payment> payments = new List<Payment>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Payment payment = new Payment(orderDB.GetOrderByIdDB((int)dr["order_id"]), (decimal)dr["total"], (decimal)dr["tip"], (decimal)dr["paid_amount"], (string)dr["method"], (string)dr["comment"]);
                payments.Add(payment);
            }
            return payments;
        }
    }
}
