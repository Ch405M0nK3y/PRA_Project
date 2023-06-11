using PRA_Project.Dal;

namespace PRA_Project.Model
{
    public class Lecturer : User
    {
        SubjectRepository subjectRepository = RepositoryFactory.GetSubjectRepository();
        IDictionary<int, Subject> subjectDictionary = new Dictionary<int, Subject>();

        public Lecturer(string firstName, string lastName, string email, bool admin, Subject subject, string password) : base(firstName, lastName, email, admin, password)
        {
            admin = false;
            Subject = subject;
        }

        public Lecturer() {  }

        public Subject Subject { get; set; }


        public string ParseForFileLine()=> $"{Id}|{FirstName}|{LastName}|{Email}|{Admin}|{Subject}|{Password}";

        public override string ToString()=> $"{Id}, {FirstName}, {LastName}, {Email}, {Subject}, {Password}";

        public void LoadSubjects()
        {
            subjectDictionary = subjectRepository.Load();
        }

        public Lecturer ParseFromFileLine(string line,char DEL)
        {
            LoadSubjects();
            string[] details = line.Split(DEL);
            

            return new Lecturer(
                FirstName = details[1],
                LastName = details[2],
                Email = details[3],
                Admin = bool.Parse(details[4]),
                Subject = subjectDictionary.Values.SingleOrDefault(x=> x.Name.Equals(details[5])),
                Password = details[6]
                );
        }

       
    }
}