using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes
{
    [DataContract]
    public class Warning
    {
        [DataMember] private string title;
        [DataMember] private string message;
        [DataMember] private Tenant personAdressed;
        [DataMember] private Supervisor sender;

        public Warning(string title, string message, Tenant personAdressed, Supervisor sender)
        {
            this.title = title;
            this.message = message;
            this.personAdressed = personAdressed;
            this.sender = sender;
        }

        public string Title { get { return title; } }

        public string Message { get { return message; } }

        public Tenant PersonAdressed { get { return personAdressed; } }

        public Supervisor Sender { get { return sender; } }

        public string GetInfoWarningDisplay()
        {
            return $"{this.title} - Sent by {this.sender}";
        }

        public string GetInfoWarning()
        {
            return $"{this.title}\n\n{this.message}\n\nSent by {this.sender}";
        }

        public override string ToString()
        {
            return GetInfoWarningDisplay();
        }
    }
}
