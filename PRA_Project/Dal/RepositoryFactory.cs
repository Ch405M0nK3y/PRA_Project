using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA_Project.Dal
{
    public class RepositoryFactory
    {

        public static IRepository GetUserRepository() => new UserRepository();
        public static IRepository GetNotificationRepository() => new NotificationRepository();
        public static IRepository GetSubjectRepository() => new SubjectRepository();

    }
}
