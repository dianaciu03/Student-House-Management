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


        public static void CalculatePricePerPerson(Payment payment)
        {
             return (double)payment.TotalPrice / numberTenants;
        }

        public static double PricePerPerson { get { return _pricePerPerson; } }

        public static void AddPaymentToList(List<string> list, Tenant Tenant, double totalPrice)
        {
            _payments.Add(new Payment(_paymentIdSeeder, list, buyer, totalPrice));
            _paymentIdSeeder++;
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

