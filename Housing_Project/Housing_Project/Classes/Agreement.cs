using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes
{
    [Serializable]
    public class Agreement
    {
        private string title;
        private int agreementID = 0;
        private string description;
        private List<Tenant> tenantsApproved = new List<Tenant>();
        private List<Tenant> tenantsRejected = new List<Tenant>();
        private List<Tenant> tenantsNotAnswered = new List<Tenant>();
        private DateTime date;

        public Agreement(int id, string title, string description, DateTime date)
        {
            this.agreementID = id;
            this.title = title;
            this.description = description;
            this.date = date;
        }

        public string Title { get { return title; } }

        public int AgreementID { get { return agreementID; } }

        public string Description { get { return description; } }

        public List<Tenant> TenantsApproved { get { return tenantsApproved; } }

        public List<Tenant> TenantsRejected { get { return tenantsRejected; } }

        public List<Tenant> TenantsNotAnswered { get { return tenantsNotAnswered; } }
        public DateTime Date { get { return date; } }

        public void InitializeTenantsNotAnswered(List<Tenant> tenants)
        {
            tenantsNotAnswered = tenants;
        }

        public void AddTenantsApproved(Tenant tenant)
        {
            tenantsApproved.Add(tenant);
            tenantsNotAnswered.Remove(tenant);
        }

        public void AddTenantsRejected(Tenant tenant)
        {
            tenantsRejected.Add(tenant);
            tenantsNotAnswered.Remove(tenant);
        }

        public int TenantsNotAnsweredCount()
        {
            return tenantsNotAnswered.Count;
        }

        public string GetInfoAgreement()
        {
            return $"{agreementID}. {title}\n\n{description}\n\n{date}";
        }

        public string GetInfoAgreementDisplay()
        {
            return $"{agreementID}. {title} - {date}";
        }

        public override string ToString()
        {
            return GetInfoAgreementDisplay();
        }

    }
}
