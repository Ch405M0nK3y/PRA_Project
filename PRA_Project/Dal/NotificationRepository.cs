using PRA_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA_Project.Dal
{
    public class NotificationRepository 
    {
        private const string DATA = $"notifications.txt";
        private const char DEL = '|';

        public NotificationRepository() => CreateFilesIfNonExistent();


        private void CreateFilesIfNonExistent()
        {
            if (!File.Exists(DATA))
            {
                File.Create(DATA).Close();
            }
        }

        public IDictionary<int, object> Load()
        {
            string[] lines = File.ReadAllLines(DATA);
            IDictionary<int, object> dictionary = new Dictionary<int, object>();

            foreach (string line in lines)
            {
                string[] details = line.Split(DEL);
                
                dictionary.Add(int.Parse(details[0]), new Notification
                {
                    Title = details[1],
                    Subject = new Subject().ParseFromFileLine(details[2], DEL),
                    Description = details[3]
                });

            }

            return dictionary;

        }

        public void Save(IDictionary<int, object> dictionary)
        {
            string[] fileContent = new string[dictionary.Count];
            int index = 0;

            foreach (object o in dictionary.Values)
            {
                Notification notification = o as Notification;
                string line = notification.ToString();
                fileContent[index++] = line;
            }

            File.WriteAllLines(DATA, fileContent);
        }

       

        
    }
}

