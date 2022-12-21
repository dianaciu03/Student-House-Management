using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Housing_Project.Classes
{
    [Serializable]
    public  class cleaningTask
    {
        //remove underscores from variables
        //use properties
        
        private string assignedPerson;
        private string SelectedDate;
        private List<string> tasks;   
        public cleaningTask( string assignedPerson, string selectedDate)
        {
            this.assignedPerson = assignedPerson;
            this.SelectedDate = selectedDate;
        }
        public List<string> tasks1
        {
            get { return tasks; }
            set { this.tasks = value; }
        }
       
        public void SetDate(string selectedDate)
        {
            this.SelectedDate = selectedDate;
        }
        public string GetDate()
        {
            return this.SelectedDate;
        }
        public string GetInfo()
        {
            return $"Date:{SelectedDate},Person:{this.assignedPerson}";
        }
    }
}
