using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;
using System.Collections.ObjectModel;


namespace ChapeauLogic
{
    public class PaymentService
    {
        PaymentDAO paymentDB = new PaymentDAO();
        DiningTableDAO tableDB = new DiningTableDAO();

        public List<Payment> GetAllPayments()
        {
            try
            {
                return paymentDB.GetAllPaymentsDB();
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }            
        }

        public Payment GetPaymentByOrder(Order order)
        {
            try
            {
                return paymentDB.GetPaymentByOrder(order);
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }

        public void InsertPayment(Payment payment)
        {
            try
            {
                paymentDB.InsertPaymentDB(payment);
                tableDB.ChangeDiningTableStatusDB(payment.Order.Table);
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }            
        }
    }
}
