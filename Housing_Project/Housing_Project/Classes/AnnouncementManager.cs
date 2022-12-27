using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Housing_Project.Classes
{
    [DataContract]
    public class AnnouncementManager
    {
        [DataMember] List<Announcement> announcements = new List<Announcement>();
        private const string filePath = @"..\..\..\..\Data\announcementData.txt";

        public void AddAnnouncementToList(Announcement announcement)
        {
            announcements.Add(announcement);
        }

        public void RemoveAnnouncementToList(Announcement announcement)
        {
            announcements.Remove(announcement);
        }

        public List<Announcement> GetAnnouncements()
        {
            return announcements;
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

        public AnnouncementManager LoadData()
        {
            try
            {
                AnnouncementManager savedData = new AnnouncementManager();

                using (FileStream fs = new(filePath, FileMode.Open, FileAccess.Read))
                {
                    Type typeToSerialize = typeof(AnnouncementManager);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Announcement),
                    };

                    DataContractSerializer dcs = new(typeToSerialize, auxiliaryTypes);
                    XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());

                    savedData = (AnnouncementManager)dcs.ReadObject(reader, true);
                    return savedData;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void WriteData(AnnouncementManager data) //Param is data that needs to be saved
        {
            try
            {
                using (FileStream ClearFile = new(filePath, FileMode.Truncate, FileAccess.Write)) ;
                using (FileStream fs = new(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    Type typeToSerialize = typeof(AnnouncementManager);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Announcement),
                    };

                    DataContractSerializer dcs = new(typeToSerialize);
                    dcs.WriteObject(fs, data);
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
