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
        private static int id= 1;

        SubjectRepository subjectRepository = RepositoryFactory.GetSubjectRepository();
        IDictionary<int, Subject> subjectDictionary = new Dictionary<int, Subject>();

        UserRepository userRepository = RepositoryFactory.GetUserRepository();
        IDictionary<int, User> userDictionary = new Dictionary<int, User>();

        public Notification(string title, Subject subject, string description, User publisher, DateTime datePublished, bool isDeleted)
        {
            Id = id++;
            Title = title;
            Subject = subject;
            Description = description;
            Publisher = publisher;
            DatePublished = datePublished;
            IsDeleted = false;
        }

        public Notification() { Id = id++; }
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
        public bool IsDeleted { get; set; }

        

       

        public static void ResetID() => id = 1;
        public void Delete() => IsDeleted = true;
        public override string ToString() => $"{Title}, {Subject}, {Publisher.FirstName} {Publisher.LastName}, {DatePublished}";

        public string ParseForFileLine() =>$"{id}|{Title}|{Subject}|{Description}|{Publisher.Email}|{DatePublished}|{IsDeleted}";

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
