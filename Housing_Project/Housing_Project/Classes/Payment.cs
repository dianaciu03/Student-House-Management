using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes
{
    [Serializable]
    public class Payment
    {
        private int paymentID = 0;
        private List<string> items = new List<string>();
        private Tenant buyer;
        private double totalPrice;
        private List<Tenant> tenantsPaid = new List<Tenant>();
        private List<Tenant> tenantsNotPaid = new List<Tenant>();

        public Payment(int id, List<string> list, Tenant buyer, double totalPrice)
        {
            this.paymentID = id;
            this.items = list;
            this.buyer = buyer;
            this.totalPrice = totalPrice;
        }
        public int PaymentID { get { return paymentID; } }

        public int PaymentID { get { return _paymentID; } }

        public List<string> Items { get { return _items; } }

        public Tenant Tenant { get { return tenant; } }

        public double TotalPrice { get { return _totalPrice; } }

        public void AddItem(string item)
        {
            _items.Add(item);
        }

        public string GetInfoPayment()
        {
            string info = $"{_paymentID}. {tenant} bought: ";
            foreach (string item in _items)
                info += item + ", ";
            info += $"\nTotal price: {_totalPrice}, Price per person: {PaymentManager.PricePerPerson:f2}";
            return info;
        }

        public string GetInfoPaymentDisplay()
        {
            return $"{PaymentID}. {tenant} bought supplies worth {_totalPrice} euros.";
        }

    public override string ToString()
    {
        return GetInfoPaymentDisplay();
    }


}


}
