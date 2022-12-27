using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Housing_Project.Classes
{
    [DataContract]
    public class WarningManager
    {
        [DataMember] List<Warning> warnings = new List<Warning>();
        private const string filePath = @"..\..\..\..\Data\warningData.txt";

        public void AddWarningToList(Warning warning)
        {
            warnings.Add(warning);
        }

        public void RemoveWarningFromList(Warning warning)
        {
            warnings.Remove(warning);
        }

        public List<Warning> GetWarningsTenant(Tenant tenant)
        {
            List<Warning> warningsTenant = new List<Warning>();

            foreach (Warning w in warnings)
            {
                if (w.PersonAdressed == tenant)
                    warningsTenant.Add(w);
            }
            return warningsTenant;
        }

        public WarningManager LoadData()
        {
            try
            {
                WarningManager savedData = new WarningManager();

                using (FileStream fs = new(filePath, FileMode.Open, FileAccess.Read))
                {
                    Type typeToSerialize = typeof(WarningManager);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Warning),
                    };

                    DataContractSerializer dcs = new(typeToSerialize, auxiliaryTypes);
                    XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());

                    savedData = (WarningManager)dcs.ReadObject(reader, true);
                    return savedData;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void WriteData(WarningManager data) //Param is data that needs to be saved
        {
            try
            {
                using (FileStream ClearFile = new(filePath, FileMode.Truncate, FileAccess.Write)) ;
                using (FileStream fs = new(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    Type typeToSerialize = typeof(WarningManager);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Warning),
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
