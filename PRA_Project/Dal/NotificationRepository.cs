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


        SubjectRepository subjectRepository = RepositoryFactory.GetSubjectRepository();
        IDictionary<int, Subject> subjectDictionary = new Dictionary<int, Subject>();

        UserRepository userRepository = RepositoryFactory.GetUserRepository();
        IDictionary<int, User> userDictionary = new Dictionary<int, User>();

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
            Notification.ResetID();
            string[] lines = File.ReadAllLines(NOTIFICATION_FILE);
            IDictionary<int, Notification> dictionary = new Dictionary<int, Notification>();

            foreach (string line in lines)
            {
                
                Notification notification = ParseFromFileLine(line, DEL);

                dictionary.Add(notification.Id, notification);

            }

            return dictionary;

        }

        public void LoadSubjectsAndUsers()
        {
            subjectDictionary = subjectRepository.Load();
            userDictionary = userRepository.Load();
        }

        public Notification ParseFromFileLine(string line, char DEL)
        {
            LoadSubjectsAndUsers();
            string[] details = line.Split(DEL);


            return new Notification(details[1], GetSubject(line), details[3], GetUser(line), DateTime.Parse(details[5]), bool.Parse(details[6]));
        }

        private Subject GetSubject(string line)
        {
            string[] details = line.Split('|');
            return subjectDictionary.Values.SingleOrDefault(x => x.Name.Equals(details[2]));

        }

        private User GetUser(string line)
        {
            string[] details = line.Split('|');
            return userDictionary.Values.SingleOrDefault(x => x.Email.Equals(details[4]));

        }

        public void Save(IDictionary<int, Notification> dictionary)
        {
            string[] fileContent = new string[dictionary.Count];
            int index = 0;

            foreach (object o in dictionary.Values)
            {
                Notification notification = o as Notification;
                string line = notification.ParseForFileLine();
                fileContent[index++] = line;
            }

            File.WriteAllLines(NOTIFICATION_FILE, fileContent);
        }

       

        
    }
}

