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
        //private const string filePathRuleData = @"..\..\..\..\Data\ruleData.txt";

        public void AddRuleToList(string message, Supervisor sender)
        {
            rules.Add(new Rule(ruleIdSeeder, message, sender));
            ruleIdSeeder++;
        }

        public Rule[] GetRules()
        {
            return rules.ToArray();
        }

        public RuleManager LoadRuleManagerData(string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                XmlReader reader
                    = XmlDictionaryReader.CreateTextReader(stream,
                        new XmlDictionaryReaderQuotas());

                Type mainType = typeof(RuleManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(Rule), typeof(Supervisor) };
                DataContractSerializer serializer
                    = new DataContractSerializer(mainType, auxiliaryTypes);


                return (RuleManager?)serializer.ReadObject(reader);

            }
            catch (Exception)
            {
                return new RuleManager();
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }

        public void WriteRuleManagerData(RuleManager ruleManager, string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

                Type mainType = typeof(RuleManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(Rule), typeof(Supervisor) };
                DataContractSerializer serializer
                    = new DataContractSerializer(mainType, auxiliaryTypes);

                serializer.WriteObject(stream, ruleManager);
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
