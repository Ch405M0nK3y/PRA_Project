using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PRA_Project.Model
{
    public abstract class User : IComparable<User>
    {
        private static int id=0;

        public User(string firstName, string lastName, string email, bool admin, string password)
        {
            Id = id++;
            FirstName = firstName;
            LastName = lastName;
            Admin = admin;
            Password = password;
            Email = email;
        }

        public User() { }
        public static void ResetID() => id = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Id { get;  set; }
        public bool Admin { get; set; }
        public string Password { get; set; }

        public static bool isAdmin(string line) => bool.Parse(line.Split('|')[4]);
        
        public override string ToString() => $"{Id}|{FirstName}|{LastName}|{Email}|{Admin}|{Password}";

        public int CompareTo(User? other)
            => this.Id.CompareTo(other.Id);

        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   Id == user.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

    }
}
