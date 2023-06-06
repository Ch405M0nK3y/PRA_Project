using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA_Project.Model
{
    public interface IPublisher
    {
        Notification CreateNotification();
        void UpdateNotification();
        Notification GetNotification();
        void DeleteNotification();

    }
}
