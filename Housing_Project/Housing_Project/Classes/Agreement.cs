using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes
{
    [DataContract]
    public class Agreement
    {
        [DataMember] string title;
        [DataMember] int agreementID = 0;
        [DataMember] string description;
        [DataMember] public bool completion;
        [DataMember] public int agreeVotes;
        [DataMember] public int disagreeVotes;
        [DataMember] public List<Vote> Votes { get; set; }
        [DataMember] List<Tenant> tenantsApproved = new List<Tenant>();
        [DataMember] List<Tenant> tenantsRejected = new List<Tenant>();
        [DataMember] List<Tenant> tenantsNotAnswered = new List<Tenant>();
        [DataMember] DateTime date;

        public Agreement(int id, string title, string description, DateTime date)
        {
            this.agreementID = id;
            this.title = title;
            this.description = description;
            this.date = date;
            this.Votes = new List<Vote>();
        }

        public Agreement(int id, string title, string description, DateTime date, List<Vote> submisions) : this(id, title, description, date)
        {
            this.Votes = submisions;
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
        public List<Tenant> GetAllTenantsWhoVoted()
        {
            List<Tenant> list = new List<Tenant>();
            foreach(Tenant tenat in TenantsApproved)
            {
                list.Add(tenat);
            }
            foreach(Tenant tenant in tenantsRejected)
            {
                list.Add(tenant);
            }
            return list;
        }
        public int GetNumAgreeVotes()
        {
            return tenantsApproved.Count();
        }
        public int GetNumDisagreeVotes()
        {
            return tenantsRejected.Count();
        }
        public override string ToString()
        {
            return GetInfoAgreementDisplay();
        }
        public void TaskCompletion(ListBox source, ListBox destination)
        {
            ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
            foreach (var item in sourceItems)
            {
                destination.Items.Add(item);
            }
            while (source.SelectedItems.Count > 0)
            {
                source.Items.Remove(source.SelectedItems[0]);
            }
        }

        public void TenantVoteAgree(Tenant tenant) 
        { 
            tenantsApproved.Add(tenant); 
            if(tenantsApproved.Count() >= 3)
            {
                completion = true;
            }
        }
        public bool TenantVoteDisagree(Tenant tenant) 
        { 
            tenantsRejected.Add(tenant); 
            if(tenantsRejected.Count() >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
