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
    public class CleaningTaskManager
    {
        [DataMember] List<CleaningTask> cleaningTasks = new List<CleaningTask>();
        private const string filePath = @"..\..\..\..\Data\cleaningTaskData.txt";

        public void AddCleaningTaskToList(CleaningTask cleaningTask)
        {
            cleaningTasks.Add(cleaningTask);
        }

        public List<CleaningTask> GetCleaningTasks()
        {
            return cleaningTasks;
        }

        public List<CleaningTask> GetAnnouncementsOnDate(DateTime date)
        {
            List<CleaningTask> cleaningTasksOnDate = new List<CleaningTask>();

            foreach (CleaningTask ct in cleaningTasks)
            {
                if (ct.Date.Day == date.Day && ct.Date.Month == date.Month && ct.Date.Year == date.Year)
                {
                    cleaningTasksOnDate.Add(ct);
                }
            }
            return cleaningTasksOnDate;
        }

        public CleaningTaskManager? LoadRecruiter(string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                XmlDictionaryReader reader
                    = XmlDictionaryReader.CreateTextReader(stream,
                                                new XmlDictionaryReaderQuotas());

                Type mainType = typeof(CleaningTaskManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(CleaningTask) };
                DataContractSerializer serializer
                    = new DataContractSerializer(mainType, auxiliaryTypes);


                return (CleaningTaskManager?)serializer.ReadObject(reader);

            }
            catch (FileNotFoundException)
            {
                return new CleaningTaskManager();
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }
        public void SaveRecruiter(CleaningTaskManager cleaningTaskManager, string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

                Type mainType = typeof(CleaningTaskManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(CleaningTask) };
                DataContractSerializer serializer
                    = new DataContractSerializer(mainType, auxiliaryTypes);

                serializer.WriteObject(stream, cleaningTaskManager);
                stream.Flush();
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }
    }
}
