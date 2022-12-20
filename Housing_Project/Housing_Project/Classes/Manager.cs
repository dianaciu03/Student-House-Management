using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes
{
    [Serializable]
    public class Manager
    {
        private static List<Tenant> tenants = new List<Tenant>();

        public static List<Tenant> GetTenants()
        {
            return tenants;
        }
    }
}
