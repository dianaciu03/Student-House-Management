using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project
{
    public class Tenant
    {
        private string name;
        private string email;
        private string nr_apartment;
        public Tenant(string name, string email, string nr_apartment)
        {
            this.name = name;
            this.email = email;
            this.nr_apartment = nr_apartment;
        }
        public string GetTenant()
        {
            return this.name;
        }
        public string Getemail()
        {
            return this.email;
        }
    }
}
