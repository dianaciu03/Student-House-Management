using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes
{
    public class Announcement
    {
        private string title;
        private string description;
        private string date;
        public Announcement(string title, string description,string date)
        {
            this.title = title;
            this.description = description;
            this.date = date;   
        }
        public string GetAnnouncementInfo()
        {
            return $"Title:{title},Description:{description},Date:{date}";
        }
    }
}
