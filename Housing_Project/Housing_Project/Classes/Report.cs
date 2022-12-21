using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes
{
    [Serializable]
    public class Report
    {
        private int reportID;
        private string title;
        private string message; 
        private Tenant adressedPerson;

        public Report(int reportID, string title, string description, Tenant adressedPerson)
        {
            this.reportID = reportID;
            this.title = title;
            this.message = description;
            this.adressedPerson = adressedPerson;
        }
        
        public string Title { get { return title; } }

        public string Description { get { return message; } }

        public Tenant AdressedPerson { get { return adressedPerson; } }

        public string GetInfoReportDisplay()
        {
            return $"{this.reportID}. Title: {this.title} || Adressed to: {this.adressedPerson}";
        }

        public string GetInfoReport()
        {
            return $"Title: {this.title}\n\nDescription: {this.message}\n\nAdressed to: {this.adressedPerson}";
        }

        public override string ToString()
        {
            return GetInfoReportDisplay();
        }
    }
}
