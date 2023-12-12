using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Notifications;

namespace ChatApp
{
    class WhatsAppNotification : INotification
    {
        public string Title { get; set; }

        public string Send()
        {
            return Title + " Send You Message To WhatsApp";
        }
    }
}
