using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;

namespace Housing_Project.Classes
{
    public class AnnouncementManager
    {
        [JsonInclude]
        public List<Announcement> announcements = new List<Announcement>();
        private const string filePath = @"..\..\..\..\Data\announcementData.txt";

        public void AddAnnouncementToList(Announcement announcement)
        {
            announcements.Add(announcement);
        }

        public void RemoveAnnouncementToList(Announcement announcement)
        {
            announcements.Remove(announcement);
        }

        public Announcement GetAnnouncement(int index)
        {
            try
            {
                return announcements[index];
            }
            catch (Exception)
            {
                throw;
            }

        }
        public List<Announcement> GetAnnouncemens()
        {
            try
            {
                return announcements;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Announcement> GetAnnouncementsOnDate(DateTime date)
        {
            List<Announcement> announcementsOnDate = new List<Announcement>();

            foreach (Announcement a in announcements)
            {
                if (a.Date.Day == date.Day && a.Date.Month == date.Month && a.Date.Year == date.Year)
                {
                    announcementsOnDate.Add(a);
                }
            }
            return announcementsOnDate;
        }
        public void SaveAnnouncement(AnnouncementManager announcementManager)
        {
            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
            };
            string jsonstring = JsonSerializer.Serialize(announcementManager, options);
            File.WriteAllText(filePath, jsonstring);
        }
        public AnnouncementManager? LoadAnnouncement()
        {
            string jsonString = File.ReadAllText(filePath);
            AnnouncementManager announcementManager = JsonSerializer.Deserialize<AnnouncementManager>(jsonString)!;
            return announcementManager;
        }
    }
}
