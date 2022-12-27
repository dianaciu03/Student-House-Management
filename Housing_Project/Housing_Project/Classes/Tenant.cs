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
    [DataContract]
    public class Tenant
    {
        [DataMember] private string name;
        [DataMember] private string email;
        [DataMember] private string password;
        [DataMember] private string phoneNumber;
        [DataMember] private int roomNumber;

        public Tenant(string name, string email, string phoneNumber)
        {
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }
       public Tenant(string name, string phoneNumber ,string email, string password)
       {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.email = email;
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

