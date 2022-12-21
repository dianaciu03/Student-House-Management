using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using Microsoft.VisualBasic.ApplicationServices;

namespace Housing_Project.Classes
{
    [Serializable]
    public class PaymentManager
    {
        private int paymentIdSeeder = 1;
        private List<Payment> payments = new List<Payment>();

        public bool IsPaymentComplete(Payment payment)
        {
            if (payment.TenantsNotPaidCount() == 0)
            {
                payments.Remove(payment);
                return true;
            }
            else
                return false;
        }

        public double CalculatePricePerPerson(Payment payment, int numberTenants)
        {
            return (double)payment.TotalPrice / numberTenants;
        }

        public void AddPaymentToList(List<string> list, Tenant buyer, double totalPrice)
        {
            payments.Add(new Payment(paymentIdSeeder, list, buyer, totalPrice));
            paymentIdSeeder++;
        }

        public Payment[] GetPayments()
        {
            return payments.ToArray();
        }

        public Payment GetPayment(int index)
        {
            return payments[index];
        }
    }
}

