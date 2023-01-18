using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;

namespace Housing_Project.Classes
{
    [Serializable]
    public class WarningManager
    {
        [JsonInclude]
        public List<Warning> Warnings { get; set; }
        const string filePath = @"..\..\..\..\Data\warningData.txt";

        public WarningManager() 
        {
            Warnings = new List<Warning>();
        }
        public void AddWarningToList(Warning warning)
        {
            Warnings.Add(warning);
        }

        public void RemoveWarningFromList(Warning warning)
        {
            Warnings.Remove(warning);
        }

        public List<Warning> GetWarningsTenant(Tenant tenant)
        {
            List<Warning> warningsTenant = new List<Warning>();

            foreach (Warning w in Warnings)
            {
                if (w.PersonAdressed.Email == tenant.Email)
                    warningsTenant.Add(w);
            }
            return warningsTenant;
        }

        public WarningManager? LoadWarnings()
        {

            string jsonString = File.ReadAllText(filePath);
            WarningManager warningManager = JsonSerializer.Deserialize<WarningManager>(jsonString)!;
            return warningManager;
        }

        public void SaveWarnings(WarningManager warningManager)
        {
            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
            };
            string jsonstring = JsonSerializer.Serialize(warningManager, options);
            File.WriteAllText(filePath, jsonstring);
        }  
          
    }
}
