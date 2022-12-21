
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Housing_Project.Classes
{
    public class AgreementManager
    {
        private int agreementIdSeeder = 1;
        private List<Agreement> agreements = new List<Agreement>();

        public void AddAgreementToList(string title, string description, DateTime date)
        {//denitsa
            agreements.Add(new Agreement(agreementIdSeeder, title, description, date));
            agreementIdSeeder++;
        }

        public bool IsAgreementComplete(Agreement agreement)
        {
            if (agreement.TenantsNotAnsweredCount() == 0)
            {
                agreements.Remove(agreement);
                return true;
            }
            else
                return false;
        }

        public Agreement[] GetAgreements()
        {
            return agreements.ToArray();
        }

        public Agreement GetAgreement(int index)
        {
            return agreements[index];
        }

        public List<Agreement> GetAgreementsOnDate(DateTime date)
        {
            List<Agreement> agreementsOnDate = new List<Agreement>();

            foreach (Agreement agreement in agreements)
            {
                if (agreement.Date.Day == date.Day && agreement.Date.Month == date.Month && agreement.Date.Year == date.Year)
                {
                    agreementsOnDate.Add(agreement);
                }
            }
            return agreementsOnDate;
        }
    }
}
