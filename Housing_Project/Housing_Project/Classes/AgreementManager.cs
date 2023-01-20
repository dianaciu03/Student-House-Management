
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml;
using System.Text.Json;

namespace Housing_Project.Classes
{
    [DataContract]
    public class AgreementManager
    {
        [DataMember] Tenant sessionTenant;
        [DataMember] private List<Agreement> completedAgreements = new List<Agreement>();
        [DataMember] private List<Agreement> noncompletedAgreements = new List<Agreement>();
        [DataMember] private int agreementIdSeeder = 1;
        [DataMember] private List<Agreement> agreements = new List<Agreement>();
        //private const string filePath = @"..\..\..\..\Data\agreementData.txt";

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
        public Agreement[] GetCompletedAgreements(AgreementManager agreementManager)
        {
            SortAgreements(agreementManager);
            return completedAgreements.ToArray();
        }
        public Agreement[] GetNoncompletedAgreements(AgreementManager agreementManager)
        {
            SortAgreements(agreementManager);
            return noncompletedAgreements.ToArray();
        }
        private void SortAgreements(AgreementManager agreementManager)
        {
            completedAgreements = new List<Agreement>();
            noncompletedAgreements= new List<Agreement>();
            foreach (Agreement agreement in agreementManager.GetAgreements())
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
            try
            {
                return agreements[index];
            }
            catch (Exception)
            {
                throw;
            }
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

        public void SaveAgreement(AgreementManager agreementManager, string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

                Type mainType = typeof(AgreementManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(Agreement) };
                DataContractSerializer serializer
                    = new DataContractSerializer(mainType, auxiliaryTypes);

                serializer.WriteObject(stream, agreementManager);
                stream.Flush();
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }
        public AgreementManager? LoadAgreement(string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                XmlReader reader
                    = XmlDictionaryReader.CreateTextReader(stream,
                        new XmlDictionaryReaderQuotas());

                Type mainType = typeof(AgreementManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(Agreement) };
                DataContractSerializer serializer
                    = new DataContractSerializer(mainType, auxiliaryTypes);


                return (AgreementManager?)serializer.ReadObject(reader);

            }
            catch (Exception)
            {
                return new AgreementManager();
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }
    }
}
