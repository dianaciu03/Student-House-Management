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
    [DataContract]
    public class AnnouncementManager
    {
        //[JsonInclude]
        [DataMember]
        public List<Announcement> announcements = new List<Announcement>();
        //private const string filePath = @"..\..\..\..\Data\announcementData.txt";

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
        public void SaveAnnouncement(AnnouncementManager announcementManager, string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

                Type mainType = typeof(AnnouncementManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(Announcement) };
                DataContractSerializer serializer
                    = new DataContractSerializer(mainType, auxiliaryTypes);

                serializer.WriteObject(stream, announcementManager);
                stream.Flush();
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }
        public AnnouncementManager? LoadAnnouncement(string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                XmlReader reader
                    = XmlDictionaryReader.CreateTextReader(stream,
                        new XmlDictionaryReaderQuotas());

                Type mainType = typeof(AnnouncementManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(Announcement) };
                DataContractSerializer serializer
                    = new DataContractSerializer(mainType, auxiliaryTypes);


                return (AnnouncementManager?)serializer.ReadObject(reader);

            }
            catch (Exception)
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
