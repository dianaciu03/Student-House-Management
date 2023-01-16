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
        private const string filePathRuleData = @"..\..\..\..\Data\ruleData.txt";

        public void AddRuleToList(string message, Supervisor sender)
        {
            rules.Add(new Rule(ruleIdSeeder, message, sender));
            ruleIdSeeder++;
        }

        public Rule[] GetRules()
        {
            return rules.ToArray();
        }

        public RuleManager LoadRuleManagerData()
        {
            try
            {
                RuleManager ruleManager = new RuleManager();

                using (FileStream fs = new(filePathRuleData, FileMode.Open, FileAccess.Read))
                {
                    Type typeToSerialize = typeof(RuleManager);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Rule),
                        typeof(Supervisor)
                    };

                    DataContractSerializer dcs = new(typeToSerialize, auxiliaryTypes);
                    XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
                    ruleManager = (RuleManager)dcs.ReadObject(reader, true);

                    return ruleManager;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void WriteRuleManagerData(RuleManager data)
        {
            try
            {
                using (FileStream ClearFile = new(filePathRuleData, FileMode.Truncate, FileAccess.Write)) ;
                using (FileStream fs = new(filePathRuleData, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    Type typeToSerialize = typeof(RuleManager);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Rule),
                        typeof(Supervisor)
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
