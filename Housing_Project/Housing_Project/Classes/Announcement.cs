using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Project.Classes
{
    [DataContract]
    public class Announcement
    {
        [DataMember] private string title;
        [DataMember] private string description;
        [DataMember] private DateTime date;

        public Announcement(string title, string description, DateTime date)
        {
            this.title = title;
            this.description = description;
            this.date = date;   
        }

        public string Title { get { return title; } }

        public string Description { get { return description; } }

        public DateTime Date { get { return date; } }

        public string GetAnnouncementInfo()
        {
            return $"Title:{title},Description:{description},Date:{date}";
        }
    }
}
