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
        private const char DEL = '|';
        private const string DIR = @"C:\PRA\Txt_Files";
        private const string NOTIFICATION_FILE = @$"{DIR}\notifications.txt";

        public NotificationRepository() => CreateFilesIfNonExistent();


        private void CreateFilesIfNonExistent()
        {
            Directory.CreateDirectory(DIR);
            if (!File.Exists(NOTIFICATION_FILE))
            {
                File.Create(NOTIFICATION_FILE).Close();
            }
        }

        public IDictionary<int, Notification> Load()
        {
            string[] lines = File.ReadAllLines(NOTIFICATION_FILE);
            IDictionary<int, Notification> dictionary = new Dictionary<int, Notification>();

            foreach (string line in lines)
            {
                
                Notification notification = new Notification().ParseFromFileLine(line, DEL);

                dictionary.Add(notification.Id, notification);

            }

            return dictionary;

        }

        public void Save(IDictionary<int, Notification> dictionary)
        {
            string[] fileContent = new string[dictionary.Count];
            int index = 0;

            foreach (object o in dictionary.Values)
            {
                Notification notification = o as Notification;
                string line = notification.ToString();
                fileContent[index++] = line;
            }

            File.WriteAllLines(NOTIFICATION_FILE, fileContent);
        }

       

        
    }
}

