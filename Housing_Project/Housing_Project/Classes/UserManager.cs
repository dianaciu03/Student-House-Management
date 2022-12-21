using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes
{
    public class UserManager
    {
        private List<Tenant> tenants = new List<Tenant>();
        private List<Supervisor> supervisors = new List<Supervisor>();

        public List<Tenant> Tenants { get { return tenants; } }

        public List<Supervisor> Supervisors { get { return supervisors; } }

        public void AddTenantToList (Tenant tenant)
        {
            tenants.Add(tenant);
        }

        public void AddSupervisorToList(Supervisor supervisor)
        {
            supervisors.Add(supervisor);
        }

        public void AddWarningToTenantList(Tenant tenant, Warning warning)
        {
            tenant.Warnings.Add(warning);
        }

        public int NumberOfTenants()
        {
            return tenants.Count;
        }

        public Tenant[] GetTenants()
        {
            return tenants.ToArray();
        }

        public Supervisor[] GetSupervisors()
        {
            return supervisors.ToArray();
        }
    }
}
