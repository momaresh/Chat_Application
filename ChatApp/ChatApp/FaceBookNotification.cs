using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    class FaceBookNotification : NotificationDecrator
    {
        public FaceBookNotification(INotification notification) : base(notification)
        {
        }

        public override string Send()
        {
            return base.Send() + " And FaceBook";
        }
    }
}
