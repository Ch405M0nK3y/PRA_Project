using PRA_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA_Project.Dal
{
    public class SubjectRepository
    {

        private const string DIR = @"C:\PRA\Txt_Files";
        private const string SUBJECT_FILE = @$"{DIR}\subjects.txt";
        private const char DEL = '|';

        public SubjectRepository() => CreateFilesIfNonExistent();


        private void CreateFilesIfNonExistent()
        {
            Directory.CreateDirectory(DIR);
            if (!File.Exists(SUBJECT_FILE))
            {
                File.Create(SUBJECT_FILE).Close();
            }
        }

        public IDictionary<int, Subject> Load()
        {
            Subject.ResetID();
            string[] lines = File.ReadAllLines(SUBJECT_FILE);
            IDictionary<int, Subject> dictionary = new Dictionary<int, Subject>();

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

        public void Save(IDictionary<int, Subject> dictionary)
        {
            string[] fileContent = new string[dictionary.Count];
            int index = 0;

            foreach (Subject o in dictionary.Values)
            {
                Subject subject = o as Subject;
                string line = subject.ParseForFileLine();
                fileContent[index++] = line;
            }

            File.WriteAllLines(SUBJECT_FILE, fileContent);
        }   
    }
}
