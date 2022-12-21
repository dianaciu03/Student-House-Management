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
        public Announcement(string title, string description)
        {
            this.title = title;
            this.description = description;
        }
        public string GetAnnouncementInfo()
        {
            return $"Title:{title},Description:{description}";
        }
    }
}
