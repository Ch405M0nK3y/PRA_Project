using PRA_Project.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace PRA_Project.Dal
{
    public class UserRepository
    {

        private const string DIR = @"C:\PRA\Txt_Files";
        private const string USER_FILE = @$"{DIR}\users.txt";
        private const char DEL= '|';
        
        public UserRepository() => CreateFileIfNonExistent();


        private void CreateFileIfNonExistent()
        {
            Directory.CreateDirectory(DIR);

            if (!File.Exists(USER_FILE))
            {
                File.Create(USER_FILE).Close();
                Administrator admin = new Administrator().CreateDefaultAdmin();
                File.WriteAllText(USER_FILE, admin.ToString());
            }
        }

        public IDictionary<int, User> Load()
        {
            User.ResetID();
            string[] lines = File.ReadAllLines(USER_FILE);
            IDictionary<int, User> dictionary = new Dictionary<int, User>();

            foreach (string line in lines)
            {
                if (User.isAdmin(line))
                {
                    Administrator admin = new Administrator().ParseFromFileLine(line,DEL);
                    dictionary.Add(admin.Id,admin);
                }
                else
                {
                    Lecturer lecturer = new Lecturer().ParseFromFileLine(line, DEL);
                    dictionary.Add(lecturer.Id, lecturer);
                }

                

            }

            return dictionary;

        }

        public void Save(IDictionary<int, User> dictionary)
        {
            string[] fileContent = new string[dictionary.Count];
            int index = 0;

            foreach (User user in dictionary.Values)
            {
                string line; 
                if (user.Admin)
                {
                    Administrator admin = user as Administrator;
                    line = admin.ParseForFileLine();
                }
                else
                {
                    Lecturer lecturer = user as Lecturer;
                    line = lecturer.ParseForFileLine();
                }
               
                fileContent[index++] = line;
            }

            File.WriteAllLines(USER_FILE, fileContent);
        }
    }
}
