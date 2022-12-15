using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes
{
    public  class cleaningTask
    {
        private string _room;
        private string _assignedPerson;
        private DateTime SelectedDate;
        public cleaningTask(string _room, string _assignedPerson, DateTime selectedDate)
        {
            this._room = _room;
            this._assignedPerson = _assignedPerson;
           this.SelectedDate = selectedDate;
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
            return $"{this._room},{this._assignedPerson}";
        }
    }
}
