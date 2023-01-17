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
        [DataMember] private int reportIdSeeder = 1;
        [DataMember] private List<Report> reports = new List<Report>();
        private const string filePath = @"..\..\..\..\Data\reportData.txt";

        public void AddReportToList(string title, string message, Tenant personAdressed)
        {
            reports.Add(new Report(reportIdSeeder, title, message, personAdressed));
            reportIdSeeder++;
        }

        public void RemoveReportFromList(Report report)
        {
            reports.Remove(report);
        }

        public Report[] GetReports()
        {
            return reports.ToArray();
        }

        public Report GetReport(int index)
        {
            return reports[index];
        }
        public ReportManager? LoadRecruiter(string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                XmlDictionaryReader reader
                    = XmlDictionaryReader.CreateTextReader(stream,
                                                new XmlDictionaryReaderQuotas());

                Type mainType = typeof(ReportManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(Report) };
                DataContractSerializer serializer
                    = new DataContractSerializer(mainType, auxiliaryTypes);

                return (ReportManager?)serializer.ReadObject(reader);
            }
            catch (FileNotFoundException)
            {
                return new ReportManager();
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }

        public void SaveRecruiter(ReportManager reportManager, string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

                Type mainType = typeof(ReportManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(Report) };
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
    }
}
