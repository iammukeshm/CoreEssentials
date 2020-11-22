using CoreEssentials.ToastNotify.Constants;
using CoreEssentials.ToastNotify.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEssentials.ToastNotify.Services
{
    public interface IToastNotifyService
    {
        void Success(string message, int? durationInSeconds = null);
        void Error(string message, int? durationInSeconds = null);
        void Information(string message, int? durationInSeconds = null);
        void Warning(string message , int? durationInSeconds = null);
        void Custom(string message, int? durationInSeconds = null, string backgroundColor = "black", string iconClassName = "home");
        IEnumerable<Notification> GetNotifications();
        IEnumerable<Notification> ReadAllNotifications();
        void RemoveAll();
    }
}
