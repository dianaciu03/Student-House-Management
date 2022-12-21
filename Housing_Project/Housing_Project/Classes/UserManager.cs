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
    [Serializable]
    public class UserManager
    {
        private int tenantIdSeeder = 1;
        private int supervisorIdSeeder = 1;


        private List<Tenant> tenants = new List<Tenant>();
        private List<Supervisor> supervisors = new List<Supervisor>();

        public List<Tenant> Tenants { get { return tenants; } }

        public List<Supervisor> Supervisors { get { return supervisors; } }

        public void AddTenantToList (string name, string email, string phoneNumber)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("tenant_info.txt", FileMode.Create, FileAccess.Write);

            tenants.Add(new Tenant(tenantIdSeeder, name, email, phoneNumber));

            formatter.Serialize(stream, tenants);
            stream.Close();

            tenantIdSeeder++;
        }

        public void AddSupervisorToList(Supervisor supervisor)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("supervisor_info.txt", FileMode.Create, FileAccess.Write);

            //supervisors.Add(new Supervisor(supervisorIdSeeder, name, email, phoneNumber));

            formatter.Serialize(stream, tenants);
            stream.Close();

            supervisorIdSeeder++;
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
