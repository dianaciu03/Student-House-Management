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
        private int _agreementId = 0;
        private string _description;
        private List<Tenant> _tenantsApproved;
        private List<Tenant> _tenantsRejected;
        private DateTime _date;


        public Agreement(int id, string title, string description, DateTime date)
        {
            this._agreementId = id;
            this._title = title;
            this._description = description;
            this._date = date;
        }

        public string Title {get { return _title; } }

        public int AgreementId 
        {
            get { return _agreementId; } 
            set { _agreementId = value; }
        }

        public string Description {get { return _description; } }

        public List<Tenant> TenantsApproved { get { return _tenantsApproved; } }

        public List<Tenant> TenantsRejected {get { return _tenantsRejected; } }

        public DateTime Date { get { return _date; } }

        public string GetInfoAgreement()
        {
            return $"{this._title}\n\n{this._description}\n\n{this._date}";
        }

        public string GetInfoAgreementDisplay()
        {
            return $"{this.AgreementId}. {this._title} - {this._date}";
        }

        public override string ToString()
        {
            return GetInfoAgreementDisplay(); 
        }

    }
}
