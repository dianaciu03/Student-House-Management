using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes
{
    [Serializable]
    public class Warning
    {
        private string title;
        private string message;
        private Tenant personAdressed;
        private Supervisor sender;

        public Warning(string title, string message, Tenant personAdressed, Supervisor sender)
        {
            this.title = title;
            this.message = message;
            this.personAdressed = personAdressed;
            this.sender = sender;
        }
    }
}
