using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PRA_Project.Model
{
    public class Subject : IComparable<Subject>
    {
        private static int id;
        public int Id { get;}
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public Subject(string name, bool isDeleted)
        {
            Id = id++;
            Name = name;
            IsDeleted = isDeleted;
        }

        public Subject() 
        {
            Id = id++;
        }

        public static void ResetID() => id = 0;
        public void Delete() => IsDeleted=true;

        public override string ToString() => $"{Name}";

        public string ParseForFileLine() => $"{Id}|{Name}|{IsDeleted}";

        public override bool Equals(object? obj)
        {
            return obj is Subject subject &&
                   Name == subject.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public int CompareTo(Subject? other)
        {
            return this.Id.CompareTo(other.Id);
        }

        public Subject ParseFromFileLine(string line, char DEL)
        {
            string[] details = line.Split(DEL);

            return new Subject
            {
                Name = details[1]
            };
                
                
        }

        
    }
}
