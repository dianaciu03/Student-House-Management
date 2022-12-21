using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes
{
    
    public class Supervisor
    {
        private string name;
        private string email;
        private string password;
        private string phoneNumber;
        private List<string> emails;

        public void AddEmailToList()
        {
            emails.Add(email);
        }
        public List<string> GetEmailList()
        {
            return emails.ToList();
        }
        public Supervisor(string name, string email, string phoneNumber)
        {
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        public Supervisor(string name, string phoneNumber, string email, string password)
        {
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.password = password;
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public string Email
        {
            get { return email; }
            set { this.email = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { this.phoneNumber = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string GetInfo()
        {
            return $"Name: {Name} || Email: {Email} || Phone Number: {PhoneNumber} ";
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
