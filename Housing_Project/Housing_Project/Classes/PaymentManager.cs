﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Housing_Project.Classes
{
    [Serializable]
    public  class PaymentManager
    {
        private static int _paymentIdSeeder = 1;
        private static double _pricePerPerson;

        //private static List<Tenant> _tenantsPaid = new List<Tenant>();
        //private static List<Tenant> _tenantsNotPaid = new List<Tenant>();
        private static List<Payment> _payments = new List<Payment>();


        public static void CalculatePricePerPerson(Payment payment)
        {
            _pricePerPerson = (double)payment.TotalPrice / 7; //dummy data
            //Manager.GetTenants().Count()
        }

        public static double PricePerPerson { get { return _pricePerPerson; } }

        public static void AddPaymentToList(List<string> list, Tenant Tenant, double totalPrice)
        {
            _payments.Add(new Payment(_paymentIdSeeder, list, Tenant, totalPrice));
            _paymentIdSeeder++;
        }

        public static Payment[] GetPayments()
        {
            return _payments.ToArray();
        }

        public static Payment GetPayment(int index)
        {
            return _payments[index];
        }
    }
}
