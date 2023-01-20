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
    public class CleaningTaskManager
    {
        [JsonInclude]
        public List<CleaningTask> cleaningTasks = new List<CleaningTask>();
        //private const string filePath = @"..\..\..\..\Data\cleaningTaskData.txt";

        public void AddCleaningTaskToList(CleaningTask cleaningTask)
        {
            cleaningTasks.Add(cleaningTask);
        }

        public CleaningTask GetCleaningTask(int index)
        {
            try
            {
                return cleaningTasks[index];
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public List<CleaningTask> GetCleaningTasks()
        {
            try
            {
                return cleaningTasks;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<CleaningTask> GetCleaningTaskOnDate(DateTime date)
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
        public void SaveCleaningTask(CleaningTaskManager cleaningTaskManager, string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

                Type mainType = typeof(CleaningTaskManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(CleaningTask), typeof(Tenant) };
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
        public CleaningTaskManager? LoadCleaningTask(string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                XmlReader reader
                    = XmlDictionaryReader.CreateTextReader(stream,
                        new XmlDictionaryReaderQuotas());

                Type mainType = typeof(CleaningTaskManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(CleaningTask), typeof(Tenant) };
                DataContractSerializer serializer
                    = new DataContractSerializer(mainType, auxiliaryTypes);


                return (CleaningTaskManager?)serializer.ReadObject(reader);

            }
            catch (Exception)
            {
                return new CleaningTaskManager();
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }
        //public CleaningTaskManager? LoadTasks()
        //{
        //    string jsonString = File.ReadAllText(filePath);
        //    CleaningTaskManager cleaningTaskManager = JsonSerializer.Deserialize<CleaningTaskManager>(jsonString)!;
        //    return cleaningTaskManager;
        //}
        //public void SaveRecruiter(CleaningTaskManager cleaningTaskManager)
        //{
        //    var options = new JsonSerializerOptions
        //    {
        //        IncludeFields = true,
        //    };
        //    string jsonstring = JsonSerializer.Serialize(cleaningTaskManager, options);
        //    File.WriteAllText(filePath, jsonstring);
        //}
    }
}
