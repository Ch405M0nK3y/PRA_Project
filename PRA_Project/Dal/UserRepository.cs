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
    internal class UserRepository : IRepository
    {
 
        private const string DATA = $"data.txt";
        private const char DEL= '|';
        
        public UserRepository() => CreateFilesIfNonExistent();


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
                if (User.isAdmin(line))
                {
                    Administrator admin = new Administrator().ParseFromFileLine(line,DEL);
                    dictionary.Add(admin.Id,admin);
                }

                Lecturer lecturer = new Lecturer().ParseFromFileLine(line, DEL);
                dictionary.Add(lecturer.Id, lecturer);

            }

            return dictionary;

        }

        public void Save(IDictionary<int, object> dictionary)
        {
            string[] fileContent = new string[dictionary.Count];
            int index = 0;

            foreach (User user in dictionary.Values)
            {
                string line = user.ToString();
                fileContent[index++] = line;
            }

            File.WriteAllLines(DATA, fileContent);
        }
    }
}
