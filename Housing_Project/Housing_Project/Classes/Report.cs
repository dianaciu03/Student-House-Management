using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes
{
    [DataContract]
    public class Report
    {
        [DataMember] private string title;
        [DataMember] private string message;
        [DataMember] private Tenant adressedPerson;

        public Report(string title, string description, Tenant adressedPerson)
        {
            this.title = title;
            this.message = description;
            this.adressedPerson = adressedPerson;
        }

        public Report(string title, string description)
        {
            this.title = title;
            this.message = description;
        }

        public string GetInfoReportDisplay()
        {
            return $"Title: {this.title} || Adressed to: {this.adressedPerson}";
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
