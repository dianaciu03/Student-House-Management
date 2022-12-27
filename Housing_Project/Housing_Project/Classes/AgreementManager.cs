
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
        [DataMember] private int agreementIdSeeder = 1;
        [DataMember] private List<Agreement> agreements = new List<Agreement>();
        private const string filePath = @"..\..\..\..\Data\agreementData.txt";

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

        public void WriteData(AgreementManager data) //Param is data that needs to be saved
        {
            try
            {
                using (FileStream ClearFile = new(filePath, FileMode.Truncate, FileAccess.Write));
                using (FileStream fs = new(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    Type typeToSerialize = typeof(AgreementManager);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Agreement),
                    };

                    DataContractSerializer dcs = new(typeToSerialize);
                    dcs.WriteObject(fs, data);
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
