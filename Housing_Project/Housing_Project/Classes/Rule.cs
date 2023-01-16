using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Housing_Project.Classes
{
    [DataContract]
    public class Rule
    {
        [DataMember] private int ruleID;
        [DataMember] private string message;
        [DataMember] private Supervisor sender;

        public Rule(int ruleID, string message, Supervisor sender)
        {
            this.ruleID = ruleID;
            this.message = message;
            this.sender = sender;
        }

        public int RuleID { get { return ruleID; } }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public Supervisor Sender
        {
            get { return sender; }
            set { sender = value; }
        }

        public string GetInfoRuleDisplay()
        {
            return $"{this.RuleID}. {this.message}";
        }

        public string GetInfoRule()
        {
            return $"{this.message}\n\nAdded by {this.sender}";
        }

        public override string ToString()
        {
            return GetInfoRuleDisplay();
        }

    }
}
