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

        public CleaningTaskManager LoadData()
        {
            try
            {
                CleaningTaskManager savedData = new CleaningTaskManager();

                using (FileStream fs = new(filePath, FileMode.Open, FileAccess.Read))
                {
                    Type typeToSerialize = typeof(CleaningTaskManager);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(CleaningTask),
                    };

                    DataContractSerializer dcs = new(typeToSerialize, auxiliaryTypes);
                    XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());

                    savedData = (CleaningTaskManager)dcs.ReadObject(reader, true);
                    return savedData;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void WriteData(CleaningTaskManager data) //Param is data that needs to be saved
        {
            try
            {
                using (FileStream ClearFile = new(filePath, FileMode.Truncate, FileAccess.Write)) ;
                using (FileStream fs = new(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    Type typeToSerialize = typeof(CleaningTaskManager);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(CleaningTask),
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
