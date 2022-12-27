using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Housing_Project.Classes
{
    [DataContract]
    public class UserManager
    {
        [DataMember] private List<Tenant> tenants = new List<Tenant>();
        [DataMember] private List<Supervisor> supervisors = new List<Supervisor>();
        private const string filePath = @"..\..\..\..\Data\userData.txt";

        public List<Tenant> Tenants { get { return tenants; } }

        public List<Supervisor> Supervisors { get { return supervisors; } }

        public void AddTenantToList(Tenant tenant)
        {
            tenants.Add(tenant);
        }

        public void AddSupervisorToList(Supervisor supervisor)
        {
            supervisors.Add(supervisor);
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

        public UserManager LoadData()
        {
            try
            {
                UserManager savedData = new UserManager();

                using (FileStream fs = new(filePath, FileMode.Open, FileAccess.Read))
                {
                    Type typeToSerialize = typeof(UserManager);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Supervisor),
                        typeof(Tenant),
                    };

                    DataContractSerializer dcs = new(typeToSerialize, auxiliaryTypes);
                    XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());

                    savedData = (UserManager)dcs.ReadObject(reader, true);
                    return savedData;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void WriteData(UserManager data) //Param is data that needs to be saved
        {
            try
            {
                using (FileStream ClearFile = new(filePath, FileMode.Truncate, FileAccess.Write));
                using (FileStream fs = new(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    Type typeToSerialize = typeof(UserManager);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Supervisor),
                        typeof(Tenant),
                    };

                    DataContractSerializer dcs = new(typeToSerialize);
                    dcs.WriteObject(fs, data);
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
