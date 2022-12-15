using Housing_Project.Classes.Agreements_Problems;
using Housing_Project.Classes.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project
{
    public static class AgreementManager
    {
        private static int _agreementIdSeeder = 1;
        private static List<Agreement> _agreements = new List<Agreement>();
        //private static List<Tenant> _tenantsAgreed = new List<Tenant>();
        //private static List<Tenant> _tenantsDisagreed = new List<Tenant>();

        public static void AddAgreementToList(string title, string description, DateTime date)
        {
            _agreements.Add(new Agreement(_agreementIdSeeder, title, description, date));
            _agreementIdSeeder++;
        }

        public static Agreement[] GetAgreements()
        {
            return _agreements.ToArray();
        }

        public static Agreement GetAgreement(int index)
        {
            return _agreements[index];
        }
    }
}
