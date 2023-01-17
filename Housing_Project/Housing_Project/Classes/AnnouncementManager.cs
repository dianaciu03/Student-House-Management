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

        public AnnouncementManager? LoadRecruiter(string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                XmlDictionaryReader reader
                    = XmlDictionaryReader.CreateTextReader(stream,
                                                new XmlDictionaryReaderQuotas());

                Type mainType = typeof(AnnouncementManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(Announcement) };
                DataContractSerializer serializer
                    = new DataContractSerializer(mainType, auxiliaryTypes);


                return (AnnouncementManager?)serializer.ReadObject(reader);

            }
            catch (FileNotFoundException)
            {
                return new AnnouncementManager();
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }
    }
}
