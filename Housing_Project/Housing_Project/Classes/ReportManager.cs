﻿using System;
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


        public ReportManager LoadData()
        {
            try
            {
                ReportManager savedData = new ReportManager();

                using (FileStream fs = new(filePath, FileMode.Open, FileAccess.Read))
                {
                    Type typeToSerialize = typeof(ReportManager);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Report),
                    };

                    DataContractSerializer dcs = new(typeToSerialize, auxiliaryTypes);
                    XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());

                    savedData = (ReportManager)dcs.ReadObject(reader, true);
                    return savedData;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void WriteData(ReportManager data) //Param is data that needs to be saved
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
