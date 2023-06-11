using PRA_Project.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA_Project.Model
{
    public class Administrator : User
    {
        public Administrator(string firstName, string lastName, string email, bool admin, string password) : base( firstName, lastName, email, admin, password)
        {
            
        }

        public Administrator() { }

        public Administrator CreateDefaultAdmin()
        {
            Administrator administator = new Administrator()
            {
                FirstName = "admin",
                LastName = "admin",
                Email = "a",
                Admin = true,
                Password = "a"
                
            };
            return administator;
        }
        public string ParseForFileLine()=> $"{Id}|{FirstName}|{LastName}|{Email}|{Admin}|{Password}";
        public Administrator ParseFromFileLine(string line,char DEL)
        {
            string[] details = line.Split(DEL);
            
                return new Administrator(
                    FirstName = details[1],
                    LastName = details[2],
                    Email = details[3],
                    Admin = bool.Parse(details[4]),
                    Password = details[5]
                    );
            
        }

        public override bool Equals(object? obj)
        {
            return obj is Administrator administrator &&
                   base.Equals(obj) &&
                   FirstName == administrator.FirstName &&
                   LastName == administrator.LastName &&
                   Id == administrator.Id &&
                   Admin == administrator.Admin;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), FirstName, LastName, Id, Admin);
        }
    }
}
