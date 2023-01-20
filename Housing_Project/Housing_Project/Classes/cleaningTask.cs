using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Housing_Project.Classes
{
    [DataContract]
    public  class CleaningTask
    {
        [DataMember] private Tenant assignedPerson;
        [DataMember] private DateTime SelectedDate;
        [DataMember] private List<string> content;
        public CleaningTask() { }
        
        public CleaningTask(Tenant assignedPerson, DateTime selectedDate, List<string> content)
        {
            this.assignedPerson = assignedPerson;
            this.SelectedDate = selectedDate;
            this.content = content;
        }

        public List<string> Content { get { return content; } }

        public Tenant AssignedPerson 
        { 
            get { return assignedPerson; }
            set { assignedPerson = value; }
        }

        public DateTime Date
        {
            get { return SelectedDate; }
            set { SelectedDate = value; }
        }

        public string GetInfo()
        {
            return $"Date: {SelectedDate}, Person: {this.assignedPerson}";
        }
    }
}
