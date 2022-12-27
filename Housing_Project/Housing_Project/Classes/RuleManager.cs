using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Formats.Asn1;
using System.Xml;

namespace Housing_Project.Classes
{
    [DataContract]
    public class RuleManager
    {
        [DataMember] private int ruleIdSeeder = 1;
        [DataMember] private List<Rule> rules = new List<Rule>();
        private const string filePath = @"..\..\..\..\Data\ruleData.txt";

        public void AddRuleToList(string title, string message, Supervisor sender)
        {
            rules.Add(new Rule(ruleIdSeeder, title, message, sender));
            ruleIdSeeder++;
        }

        public Rule[] GetRules()
        {
            return rules.ToArray();
        }

        public Rule GetRule(int index)
        {
            return rules[index];
        }

        public RuleManager LoadData()
        {
            try
            {
                RuleManager savedData = new RuleManager();

                using (FileStream fs = new(filePath, FileMode.Open, FileAccess.Read))
                {
                    Type typeToSerialize = typeof(RuleManager);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Rule),
                    };

                    DataContractSerializer dcs = new(typeToSerialize, auxiliaryTypes);
                    XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());

                    savedData = (RuleManager)dcs.ReadObject(reader, true);
                    return savedData;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void WriteData(RuleManager data) //Param is data that needs to be saved
        {
            try
            {
                using (FileStream ClearFile = new(filePath, FileMode.Truncate, FileAccess.Write)) ;
                using (FileStream fs = new(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    Type typeToSerialize = typeof(RuleManager);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Rule),
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
