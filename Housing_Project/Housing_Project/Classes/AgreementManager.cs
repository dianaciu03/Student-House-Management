
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml;

namespace Housing_Project.Classes
{
    [DataContract]
    public class AgreementManager
    {
        Tenant sessionTenant;
        private List<Agreement> completedAgreements = new List<Agreement>();
        private List<Agreement> noncompletedAgreements = new List<Agreement>();
        [DataMember] private int agreementIdSeeder = 1;
        [DataMember] private List<Agreement> agreements = new List<Agreement>();
        private const string filePath = @"..\..\..\..\Data\agreementData.txt";

        public void SetSessionTenant(Tenant tenant)
        {
            sessionTenant= tenant;
        }
        public void AddAgreementToList(string title, string description, DateTime date)
        {
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
        public Agreement[] GetCompletedAgreements()
        {
            SortAgreements();
            return completedAgreements.ToArray();
        }
        public Agreement[] GetNoncompletedAgreements()
        {
            SortAgreements();
            return noncompletedAgreements.ToArray();
        }

        private void SortAgreements()
        {
            completedAgreements = new List<Agreement>();
            noncompletedAgreements= new List<Agreement>();
            foreach (Agreement agreement in agreements)
            {
                if(agreement.completion == true)
                {
                    completedAgreements.Add(agreement);
                }
                else
                {
                    noncompletedAgreements.Add(agreement);
                }
            }
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
        public int[] GetAgreementVotesByID(int id)
        {
            for (int i = 0; i < agreements.Count(); i++)
            {
                if (i == id)
                {
                    int[] ints = {agreements[i].GetNumAgreeVotes(), agreements[i].GetNumDisagreeVotes() };
                    return ints;
                }
            }
            return null;
        }
        
        public void CompleteAgreementById(int id)
        {
            for (int i = 0; i < agreements.Count(); i++)
            {
                if (i == id)
                {
                    agreements[i].completion= true;
                }
            }
        }

        public void AgreeToAgreement(int id)
        {
            for (int i = 0; i < agreements.Count(); i++)
            {
                if (i == id)
                {
                    agreements[i].agreeVotes += 1;
                    agreements[i].TenantVoteAgree(sessionTenant);

                }
            }
        }

        public void DisagreeToAgreement(int id)
        {
            bool votedAgainst;
            for (int i = 0; i < agreements.Count(); i++)
            {
                if (i == id)
                {
                    agreements[i].disagreeVotes += 1;
                    votedAgainst = agreements[i].TenantVoteDisagree(sessionTenant);
                    if(votedAgainst)
                    {
                        agreements.RemoveAt(i);
                    }
                }
            }
        }
        public bool HasTenantVotedForAgreementByID(int id)
        {
            bool tenantFound = false;
            for (int i = 0; i < agreements.Count(); i++)
            {
                if (i == id)
                {
                    foreach(Tenant tenant in agreements[i].GetAllTenantsWhoVoted())
                    {
                        if(tenant == sessionTenant)
                        {
                            tenantFound =  true;
                        }
                    }
                }
            }
            return tenantFound;
        }
        public AgreementManager LoadData()
        {
            try
            {
                AgreementManager savedData = new AgreementManager();

                using (FileStream fs = new(filePath, FileMode.Open, FileAccess.Read))
                {
                    Type typeToSerialize = typeof(AnnouncementManager);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Agreement),
                        typeof(Tenant)
                    };

                    DataContractSerializer dcs = new(typeToSerialize, auxiliaryTypes);
                    XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());

                    savedData = (AgreementManager)dcs.ReadObject(reader, true);
                    return savedData;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

       
        
    }
}
