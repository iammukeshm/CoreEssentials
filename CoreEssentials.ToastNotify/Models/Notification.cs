using CoreEssentials.ToastNotify.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEssentials.ToastNotify.Models
{
    public class Notification
    {
        public Notification(NotificationType type, string message)
        {
            Message = message;
            Type = type;
        }
        public string Message { get; set; }
        public NotificationType Type { get; set; }
    }
}
