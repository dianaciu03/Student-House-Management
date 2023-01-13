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

        public WarningManager? LoadRecruiter(string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                XmlDictionaryReader reader
                    = XmlDictionaryReader.CreateTextReader(stream,
                                                new XmlDictionaryReaderQuotas());

                Type mainType = typeof(WarningManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(Warning) };
                DataContractSerializer serializer
                    = new DataContractSerializer(mainType, auxiliaryTypes);


                return (WarningManager?)serializer.ReadObject(reader);

            }
            catch (FileNotFoundException)
            {
                return new WarningManager();
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }

        public void SaveRecruiter(WarningManager warningManager, string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

                Type mainType = typeof(WarningManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(Warning) };
                DataContractSerializer serializer
                    = new DataContractSerializer(mainType, auxiliaryTypes);

                serializer.WriteObject(stream, warningManager);
                stream.Flush();
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }
    }
}
