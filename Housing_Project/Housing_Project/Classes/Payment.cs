using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes
{
    [DataContract]
    public class Payment
    {
        [DataMember] private List<string> items = new List<string>();
        [DataMember] private Tenant buyer;
        [DataMember] private double totalPrice;

        public Payment(List<string> list, Tenant buyer, double totalPrice)
        {
            this.items = list;
            this.buyer = buyer;
            this.totalPrice = totalPrice;
        }

        public double TotalPrice { get { return totalPrice; } }


        public string GetInfoPayment(double pricePerPerson)
        {
            string info = $"{buyer} bought: ";
            foreach (string item in items)
                info += item + ", ";
            info += $"\nTotal price: {totalPrice}, Price per person: {pricePerPerson:f2}";
            return info;
        }

        public string GetInfoPaymentDisplay()
        {
            return $"{buyer} bought supplies worth {totalPrice} euros.";
        }

        public override string ToString()
        {
            return GetInfoPaymentDisplay();
        }
    }
}
