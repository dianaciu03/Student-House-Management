using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes
{
    public class Report
    {
        private string _title;
        private string _description; 
        private string _adressedPerson;
        public Report(string title, string description, string adressedPerson)
        {
            _title = title;
            _description = description;
            _adressedPerson = adressedPerson;
        }   
        public string GetTitle()
        {

            return this._title;
        }
        public string GetDescription()
        {
            return this._description;
        }
        public string GetAdressedPerson()
        {
            return this._adressedPerson;
        }
        public string GetInfo()
        {
            return $"Title:{this.GetTitle()},Description:{this.GetDescription()},Adressed to:{this.GetAdressedPerson()}";
        }
    }
}
