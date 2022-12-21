using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes
{
    [Serializable]
    public  class cleaningTask
    {
        //remove underscores from variables
        //use properties
        private string _room;
        private Tenant _assignedPerson;
        private string SelectedDate;
        public cleaningTask(string _room, Tenant _assignedPerson, string selectedDate)
        {
            this._room = _room;
            this._assignedPerson = _assignedPerson;
           this.SelectedDate = selectedDate;
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
            return $"{this._room},{this._assignedPerson}";
        }
    }
}
