using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA_Project.Model
{
    public class Notification : IComparable<Notification>
    {
        private static int id;

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

        public int Id { get;}
        public string Title { get; set; }
        public Subject Subject { get; set; }
        public string Description { get; set; }

        public override string ToString() => $"{id}|{Title}|{Subject}|{Description}";

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
