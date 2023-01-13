using Housing_Project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Housing_Project
{
    public class FileManagerAnnouncement
    {
        public void SaveRecruiter(AnnouncementManager announcementManager, string fileName)
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
