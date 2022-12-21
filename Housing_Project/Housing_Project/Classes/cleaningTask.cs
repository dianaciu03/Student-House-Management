using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Housing_Project.Classes
{
    [Serializable]
    public  class cleaningTask
    {
        //remove underscores from variables
        //use properties
        private string room;
        private Tenant assignedPerson;
        private DateTime SelectedDate;
        private List<Task> tasks;   
        public cleaningTask(string room, Tenant assignedPerson, DateTime selectedDate)
        {
            this.room = room;
            this.assignedPerson = assignedPerson;
           this.SelectedDate = selectedDate;
        }
        public void AddTaskToList(string room, Tenant assignedPerson, string selectedDate)
        {
            //tasks.Add(new cleaningTask( room,  assignedPerson,  selectedDate);
        }
        public List<Task> GetEmailList()
        {
            return tasks.ToList();
        }
        public void SetDate(DateTime selectedDate)
        {
            this.SelectedDate = selectedDate;
        }
        public DateTime GetDate()
        {
            return this.SelectedDate;
        }
        public string GetInfo()
        {
            return $"{this.room},{this.assignedPerson}";
        }
    }
}
