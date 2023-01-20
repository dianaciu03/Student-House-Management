using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Housing_Project.Classes
{
    [DataContract]
    public class ReportManager
    {
        [DataMember] private List<Report> reports = new List<Report>();
        //private const string filePath = @"..\..\..\..\Data\reportData.txt";

        public void AddReportToList(Report report)
        {
            reports.Add(report);
        }

        public void RemoveReportFromList(Report report)
        {
            reports.Remove(report);
        }

        public Report[] GetReports()
        {
            return reports.ToArray();
        }

        public void SaveReport(ReportManager reportManager, string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

                Type mainType = typeof(ReportManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(Report), typeof(Tenant) };
                DataContractSerializer serializer
                    = new DataContractSerializer(mainType, auxiliaryTypes);

                serializer.WriteObject(stream, reportManager);
                stream.Flush();
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }
        public ReportManager? LoadReport(string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                XmlReader reader
                    = XmlDictionaryReader.CreateTextReader(stream,
                        new XmlDictionaryReaderQuotas());

                Type mainType = typeof(ReportManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(Report), typeof(Tenant) };
                DataContractSerializer serializer
                    = new DataContractSerializer(mainType, auxiliaryTypes);


                return (ReportManager?)serializer.ReadObject(reader);

            }
            catch (Exception)
            {
                return new ReportManager();
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }
    }
}
