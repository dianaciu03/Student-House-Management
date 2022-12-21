using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Housing_Project.Classes
{
    [Serializable]
    public class Tenant
    {
        private int tenantID;
        private string name;
        private string email;
        private string password;
        private string phoneNumber;
        private int roomNumber;
        private List<Warning> warnings = new List<Warning>();

        public Tenant(int tenantID, string name, string email, string phoneNumber)
        {
            this.tenantID = tenantID;
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        public int TenantID { get { return tenantID; } }

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

        public int RoomNumber
        {
            get { return roomNumber; }
            set { this.roomNumber = value; }
        }

        public string Password 
        { 
            get { return password; }
            set { password = value; }
        }

        public List<Warning> Warnings { get { return warnings; } }

        public string GetInfo()
        {
            return $"Name: {Name} || Email: {Email} || Phone Number: {PhoneNumber} || Room Number: {RoomNumber}";
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}

