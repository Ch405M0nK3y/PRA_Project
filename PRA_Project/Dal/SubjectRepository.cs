using PRA_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA_Project.Dal
{
    internal class SubjectRepository : IRepository
    {

        private const string DATA = $"subject.txt";
        private const char DEL = '|';

        public SubjectRepository() => CreateFilesIfNonExistent();


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

                dictionary.Add(int.Parse(details[0]), new Subject
                {
                    Name = details[1]
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
                Subject subject = o as Subject;
                string line = subject.ToString();
                fileContent[index++] = line;
            }

            File.WriteAllLines(DATA, fileContent);
        }   
    }
}
