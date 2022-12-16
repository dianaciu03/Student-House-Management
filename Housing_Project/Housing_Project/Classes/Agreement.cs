using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes
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
            _agreementId = id;
            _title = title;
            _description = description;
            _date = date;
        }

        public string Title { get { return _title; } }

        public int AgreementId
        {
            get { return _agreementId; }
            set { _agreementId = value; }
        }

        public string Description { get { return _description; } }

        public List<Tenant> TenantsApproved { get { return _tenantsApproved; } }

        public List<Tenant> TenantsRejected { get { return _tenantsRejected; } }

        public DateTime Date { get { return _date; } }

        public string GetInfoAgreement()
        {
            return $"{_title}\n\n{_description}\n\n{_date}";
        }

        public string GetInfoAgreementDisplay()
        {
            return $"{AgreementId}. {_title} - {_date}";
        }

        public override string ToString()
        {
            return GetInfoAgreementDisplay();
        }

    }
}
