using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Notifications;

namespace ChatApp
{
    class NotificationDecrator : INotification
    {
        INotification notification;

        public NotificationDecrator(INotification notification)
        {
            this.notification = notification;
        }
        public virtual string Send()
        {
            return notification.Send();
        }
    }
}
