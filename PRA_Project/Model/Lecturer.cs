namespace PRA_Project.Model
{
    public class Lecturer : User, IPublisher
    {
        public Lecturer(string firstName, string lastName, bool admin) : base(firstName, lastName, admin)
        {
            admin = false;
        }

        public Lecturer() { }

        public Subject Subject { get; set; }

        public string Email { get; set; }

        public Notification CreateNotification()
        {
            throw new NotImplementedException();
        }

        public void DeleteNotification()
        {
            throw new NotImplementedException();
        }

        public Notification GetNotification()
        {
            throw new NotImplementedException();
        }

        public void UpdateNotification()
        {
            throw new NotImplementedException();
        }

        public Lecturer ParseFromFileLine(string line,char DEL)
        {
            string[] details = line.Split(DEL);

            return new Lecturer(
                FirstName = details[1],
                LastName = details[2],
                Admin = bool.Parse(details[3])
                );
        }
    }
}