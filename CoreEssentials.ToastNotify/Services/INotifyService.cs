using CoreEssentials.ToastNotify.Constants;
using CoreEssentials.ToastNotify.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEssentials.ToastNotify.Services
{
    public interface INotifyService
    {
        void Success(string message, int durationInSeconds = NotificationConstants.DefaultDuration);
        void Error(string message, int durationInSeconds = NotificationConstants.DefaultDuration);
        void Information(string message, int durationInSeconds = NotificationConstants.DefaultDuration);
        void Warning(string message , int durationInSeconds = NotificationConstants.DefaultDuration);
        void Custom(string message, string backgroundColor = "black", string iconClassName = "home", int durationInSeconds = NotificationConstants.DefaultDuration);
        IEnumerable<Notification> GetNotifications();
        IEnumerable<Notification> ReadAllNotifications();
        void RemoveAll();
    }
}
