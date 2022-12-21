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

        public List<string> Items { get { return items; } }

        public Tenant Tenant { get { return buyer; } }

        public double TotalPrice { get { return totalPrice; } }

        public void InitializeTenantsNotPaid(List<Tenant> tenants)
        {
            this.tenantsNotPaid = tenants;
        }

        public void AddTenantsPaid(Tenant tenant)
        {
            tenantsNotPaid.Remove(tenant);
            tenantsPaid.Add(tenant);
        }

        public void AddItem(string item)
        {
            items.Add(item);
        }

        public int TenantsNotPaidCount()
        {
            return tenantsNotPaid.Count;
        }

        public string GetInfoPayment(double pricePerPerson)
        {
            string info = $"{paymentID}. {buyer} bought: ";
            foreach (string item in items)
                info += item + ", ";
            info += $"\nTotal price: {totalPrice}, Price per person: {pricePerPerson:f2}";
            return info;
        }

        public string GetInfoPaymentDisplay()
        {
            return $"{PaymentID}. {buyer} bought supplies worth {totalPrice} euros.";
        }

        public override string ToString()
        {
            return GetInfoPaymentDisplay();
        }


    }


}
