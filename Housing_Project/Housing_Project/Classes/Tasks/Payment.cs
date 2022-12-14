using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes.Tasks
{
    public class Payment
    {
        private List<string> _items= new List<string>();
        private string _buyer;
        private decimal _totalPrice;
        private decimal _pricePerPerson;
        private int _paymentID;

        public Payment(List<string> list, string buyer, decimal totalPrice)
        {
            this._items = list;
            this._buyer = buyer;
            this._totalPrice = totalPrice;
        }

        public List<string> Items { get { return _items; } }

        public string Buyer { get { return _buyer; } }

        public decimal TotalPrice { get { return _totalPrice; } }

        public void AddItem(string item)
        {
            _items.Add(item);
        }

        public void CalculatePricePerPerson()
        {
            _pricePerPerson = _totalPrice / 7;
            //Manager.GetTenants().Count()
        }

        public string GetInfoPayment()
        {
            return $"{this._paymentID}. {this._buyer} bought {this._items}.\n" +
                $"Total price: {this._totalPrice}, Price per person: {this._pricePerPerson}\n" +
                $"----------------------------------";
        }

        public override string ToString()
        {
            return GetInfoPayment();
        }


    }

    
}
