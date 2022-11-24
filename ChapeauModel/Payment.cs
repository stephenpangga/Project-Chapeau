using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Payment
    {
        public Order Order { get; set; }
        public decimal Total { get; set; }
        public decimal Tip { get; set; }
        public decimal AmountPaid { get; set; }
        public PaymentMethod Method { get; set; }
        public string Feedback { get; set; }

        public Payment(Order order, decimal total, decimal tip, decimal amountPaid, PaymentMethod method,string feedback)
        {
            Order = order;
            Total = total;
            Tip = tip;
            AmountPaid = amountPaid;
            Method = method;
            Order.Table.Status = TableStatus.Free;
            Feedback = feedback;
        }

        public Payment(Order order, decimal total, decimal tip, decimal amountPaid, string method,string feedback)
        {
            Order = order;
            Total = total;
            Tip = tip;
            AmountPaid = amountPaid;
            Order.Table.Status = TableStatus.Free;
            Feedback = feedback;

            switch (method)
            {
                case "Cash":
                    Method = PaymentMethod.Cash;
                    break;
                case "Pin":
                    Method = PaymentMethod.Pin;
                    break;
                case "CreditCard":
                    Method = PaymentMethod.CreditCard;
                    break;
                default:
                    throw new Exception("Wrong string input for payment method");
            }
        }
    }
}
