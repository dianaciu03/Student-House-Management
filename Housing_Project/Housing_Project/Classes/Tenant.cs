using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Housing_Project.Classes
{
    public class Tenant
    {
        private string _name;
        private string _email;
        private string _password;
        private string _phoneNumber;
        private int _roomNumber;

        static List<Tenant> tenants = new List<Tenant>();

        public Tenant(string name, string email, string phoneNumber, int roomNumber)
        {
            this._name = name;
            this._email = email;
            this._phoneNumber = phoneNumber;
            this._roomNumber = roomNumber;
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this._phoneNumber;
            }
            set
            {
                this._phoneNumber = value;
            }
        }

        public int RoomNumber
        {
            get
            {
                return this._roomNumber;
            }
            set
            {
                this._roomNumber = value;
            }
        }

        static public void AddTenant(TextBox nameBox, TextBox emailBox, TextBox phoneNumberBox,TextBox roomNumberBox)
        {
            if (nameBox.Text != "" && emailBox.Text != "" && phoneNumberBox.Text != "" && roomNumberBox.Text != "")
            {
                try
                {
                    Tenant newtenant = new Tenant(nameBox.Text, emailBox.Text, phoneNumberBox.Text, int.Parse(roomNumberBox.Text));
                    tenants.Add(newtenant);
                    nameBox.Text = "";
                    emailBox.Text = "";
                    phoneNumberBox.Text = "";
                    roomNumberBox.Text = "";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Invalid details");
                }
            }
            else
            {
                MessageBox.Show("Box is empty");
            }
        }

        static public void PushChanges(TextBox IndexboxTenants, TextBox tbTenantName, TextBox tbTenantEmail, TextBox tbTenantPhone,TextBox tbRoomNumber)
        {
            try
            {
                tenants[int.Parse(IndexboxTenants.Text) - 1].Name = tbTenantName.Text;
                tenants[int.Parse(IndexboxTenants.Text) - 1].Email = tbTenantEmail.Text;
                tenants[int.Parse(IndexboxTenants.Text) - 1].PhoneNumber = tbTenantPhone.Text;
                tenants[int.Parse(IndexboxTenants.Text) - 1].RoomNumber = int.Parse(tbRoomNumber.Text);

                MessageBox.Show("Success");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid details");
                throw;
            }
        }

        public string GetInfo()
        {
            return $"Name: {Name} || Email: {Email} || Phone Number: {PhoneNumber} || Room Number: {RoomNumber}";
        }
        //static public void DisplayFullInfo(ListBox listOfRules)
        //{
        //    MessageBox.Show($"{rules[listOfRules.SelectedIndex].GetInfo("long")}");
        //}
        static public List<Tenant> GetTenants()
        {
            return tenants;
        }
    }


}

