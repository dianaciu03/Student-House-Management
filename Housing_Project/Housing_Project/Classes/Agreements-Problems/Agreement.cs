using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes.Agreements_Problems
{
    public class Agreement
    {
        private string _title;
        private string _description;
        private List<Tenant> _tenantsApproved;
        private List<Tenant> _tenantsRejected;
        private DateTime _date;

        public Agreement(string title, string description, List<Tenant> tenantsApproved, List<Tenant> tenantsRejected, DateTime date)
        {
            this._title = title;
            this._description = description;
            this._tenantsApproved = tenantsApproved;
            this._tenantsRejected = tenantsRejected;
            this._date = date;
        }

        public string Title {get { return _title; } }

        public string Description {get { return _description; } }

        public List<Tenant> TenantsApproved { get { return _tenantsApproved; } }

        public List<Tenant> TenantsRejected {get { return _tenantsRejected; } }

        public DateTime Date { get { return _date; } }

    }
}
