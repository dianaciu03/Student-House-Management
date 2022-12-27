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
        [DataMember] private string subject;
        [DataMember] private string message;
        [DataMember] private Supervisor sender;
        
        public Rule(int ruleID, string subject, string message, Supervisor sender)
        {
            this.ruleID = ruleID;
            this.subject = subject;
            this.message = message;
            this.sender = sender;
        }

        public int RuleID { get { return ruleID; } }

        public string Subject 
        {   
            get { return subject; } 
            set { subject = value; }
        }

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
            return $"{this.RuleID}. {this.subject} added by {this.sender}";
        }

        public string GetInfoRule()
        {
            return $"{this.subject}\n\n{this.message}\n\nAdded by {this.sender}";
        }

        public override string ToString()
        {
            return GetInfoRuleDisplay();
        }

    }
}
