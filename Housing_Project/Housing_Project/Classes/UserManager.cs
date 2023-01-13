using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.VisualBasic.ApplicationServices;

namespace Housing_Project.Classes
{
    [DataContract]
    public class UserManager
    {
        [DataMember] private List<Tenant> tenants = new List<Tenant>();
        [DataMember] private List<Supervisor> supervisors = new List<Supervisor>();

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

        public UserManager? LoadRecruiter(string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                XmlReader reader
                    = XmlDictionaryReader.CreateTextReader(stream,
                                                new XmlDictionaryReaderQuotas());

                Type mainType = typeof(UserManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(Tenant), typeof(Supervisor) };
                DataContractSerializer serializer
                    = new DataContractSerializer(mainType, auxiliaryTypes);


                return (UserManager?)serializer.ReadObject(reader);

            }
            catch (FileNotFoundException)
            {
                return new UserManager();
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }

        public void SaveRecruiter(UserManager userManager, string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

                Type mainType = typeof(UserManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(Tenant), typeof(Supervisor) };
                DataContractSerializer serializer
                    = new DataContractSerializer(mainType, auxiliaryTypes);

                serializer.WriteObject(stream, userManager);
                stream.Flush();
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }
    }
}
