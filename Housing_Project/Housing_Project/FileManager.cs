using Housing_Project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Housing_Project
{
    public class FileManager
    {
        public void SaveRecruiter(AgreementManager agreementManager, string fileName)
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
        public AgreementManager? LoadRecruiter(string fileName)
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
            catch (FileNotFoundException)
            {
                return new AgreementManager();
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }

        internal void SaveRecruiter(ReportManager reportManager, string v)
        {
            throw new NotImplementedException();
        }
    }
}
