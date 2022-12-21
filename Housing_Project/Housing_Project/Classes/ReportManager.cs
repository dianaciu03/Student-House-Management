using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes
{
    public class ReportManager
    {
        private int reportIdSeeder = 1;
        private List<Report> reports = new List<Report>();

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
    }
}
