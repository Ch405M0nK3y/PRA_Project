using PRA_Project.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PRA_Project.Model
{
    public class Notification : IComparable<Notification>
    {
        private static int id;

        SubjectRepository subjectRepository = RepositoryFactory.GetSubjectRepository();
        IDictionary<int, Subject> subjectDictionary = new Dictionary<int, Subject>();

        UserRepository userRepository = RepositoryFactory.GetUserRepository();
        IDictionary<int, User> userDictionary = new Dictionary<int, User>();

        public Notification(string title, Subject subject, string description)
        {
            Id = id++;
            Title = title;
            Subject = subject;
            Description = description;
        }

        public Notification()
        {
            Id = id++;
        }
        public void LoadSubjectsAndUsers()
        {
            subjectDictionary = subjectRepository.Load();
            userDictionary = userRepository.Load();
        }
        
        public int Id { get;}
        public string Title { get; set; }
        public Subject Subject { get; set; }
        public string Description { get; set; }
        public User Publisher { get; set; }
        public DateTime DatePublished { get; set; }

        public Notification ParseFromFileLine(string line, char DEL)
        {
            LoadSubjectsAndUsers();
            string[] details = line.Split(DEL);


            return new Notification
            {
                Title = details[1],
                Subject = subjectDictionary.Values.SingleOrDefault(x => x.Name.Equals(details[2])),
                Description = details[3],
                Publisher = userDictionary.Values.SingleOrDefault(x=> x.Email.Equals(details[4])),
                //DatePublished = DateTime.Parse(details[5])
            };
        }
        

        public override string ToString() => $"{Title}, {Subject}, {Description}, {Publisher.FirstName} {Publisher.LastName}, {DatePublished}";

        public string ParseForFileLine() =>$"{id}|{Title}|{Subject}|{Description}|{Publisher.Email}|{DatePublished}";

        public int CompareTo(Notification? other)
        {
            return this.Id.CompareTo(other.Id);
        }

        public override bool Equals(object? obj)
        {
            return obj is Notification notification &&
                   Id == notification.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
