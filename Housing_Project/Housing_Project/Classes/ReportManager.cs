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
        private const string filePath = @"..\..\..\..\Data\reportData.txt";

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

        public ReportManager LoadReportManagerData()
        {
            try
            {
                ReportManager reportManager = new ReportManager();

                using (FileStream fs = new(filePath, FileMode.Open, FileAccess.Read))
                {
                    Type typeToSerialize = typeof(ReportManager);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Report),
                        typeof(Tenant)
                    };

                    DataContractSerializer dcs = new(typeToSerialize, auxiliaryTypes);
                    XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
                    reportManager = (ReportManager)dcs.ReadObject(reader, true);

                    return reportManager;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void WriteReportManagerData(ReportManager data)
        {
            try
            {
                using (FileStream ClearFile = new(filePath, FileMode.Truncate, FileAccess.Write)) ;
                using (FileStream fs = new(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    Type typeToSerialize = typeof(ReportManager);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Report),
                        typeof(Tenant)
                    };

                    DataContractSerializer dcs = new(typeToSerialize);
                    dcs.WriteObject(fs, data);
                }
            }
            catch (Exception) { }
        }
    }
}
