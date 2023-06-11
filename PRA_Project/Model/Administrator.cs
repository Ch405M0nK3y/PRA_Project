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

        /// Subject dictionary      //////////////////////////////////////////////////////////////////////

        private IDictionary<int, object> subjectDictionary;
        private IRepository subjectRepo = RepositoryFactory.GetSubjectRepository();

        public IDictionary<int, object> SubjectDictionary
        {
            get
            {
                if (userDictionary == null)
                {
                    LoadSubjects();

                }
                return new Dictionary<int, object>(subjectDictionary);
            }
        }

        private void LoadSubjects()
        {
            subjectDictionary = new Dictionary<int, object>();
            subjectDictionary = subjectRepo.Load();
        }

        /// Notification dictionary //////////////////////////////////////////////////////////////////////

        private IDictionary<int, object> notificationDictionary;
        private IRepository notificationRepo = RepositoryFactory.GetSubjectRepository();

        public IDictionary<int, object> NotificationDictionary
        {
            get
            {
                if (userDictionary == null)
                {
                    LoadNotifications();

                }
                return new Dictionary<int, object>(notificationDictionary);
            }
        }

        private void LoadNotifications()
        {
            notificationDictionary = new Dictionary<int, object>();
            notificationDictionary = notificationRepo.Load();
        }


        //CRUD subject    //////////////////////////////////////////////////////////////////////

        public Subject CreateSubject(string name)
        {
            return new Subject(name);
        }


        public void DeleteSubject(int id)
        {
            //Dohvati sve nastavnike i kolegije -> nastavnicima koji imaju prop kolegija kojeg se briše se
            //postavlja na null i kolegij se briše



        }

        public void UpdateSubject(int id)
        {

        }

        public void GetSubject(int id)
        {
            //Ispiši podatke o kolegiju i nastavnike vezane na kolegij
        }


        //CRUD lecturer   //////////////////////////////////////////////////////////////////////



        public Lecturer CreateLecturer(string firstName, string lastName) => new(firstName, lastName,false);
        public void UpdateLecturer(int id)
        {
            //TODO
        }

        public Lecturer GetLecturer(int id) { return new Lecturer("","",false); } //TODO



        //CRUD notification   //////////////////////////////////////////////////////////////////////

        public Notification CreateNotification()
        {
            throw new NotImplementedException();
        }

        public void UpdateNotification()
        {
            throw new NotImplementedException();
        }

        public Notification GetNotification()
        {
            throw new NotImplementedException();
        }

        public void DeleteNotification()
        {
            throw new NotImplementedException();
        }




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
