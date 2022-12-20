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
        private int _paymentID = 0;

        private List<string> _items = new List<string>();
        private Tenant tenant;
        private double _totalPrice;

        public Payment(int id, List<string> list, Tenant Tenant, double totalPrice)
        {
            _paymentID = id;
            _items = list;
            tenant = Tenant;
            _totalPrice = totalPrice;
        }
        public Payment(List<string>list, string buyer, double totalPrice)
        {
            _items = list;
            _buyer = buyer;
            _totalPrice = totalPrice;
        }

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
