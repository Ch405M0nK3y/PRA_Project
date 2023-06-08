using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA_Project.Dal
{
    public class RepositoryFactory
    {

        public static UserRepository GetUserRepository() => new UserRepository();
        public static NotificationRepository GetNotificationRepository() => new NotificationRepository();
        public static SubjectRepository GetSubjectRepository() => new SubjectRepository();

    }
}
