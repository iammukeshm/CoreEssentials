using CoreEssentials.ToastNotify.Constants;
using CoreEssentials.ToastNotify.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEssentials.ToastNotify.Models
{
    public class Notification
    {
        public Notification(NotificationType type, string message, int durationInSeconds)
        {
            Message = message;
            Type = type;
            Duration = durationInSeconds * 1000;
        }
        public string Message { get; set; }
        public string BackgroundColor { get; set; }
        public string Icon { get; set; }
        public NotificationType Type { get; set; }
        public int Duration { get; set; } = NotificationConstants.DefaultDuration * 1000;
    }
}
