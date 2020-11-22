using CoreEssentials.ToastNotify.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEssentials.ToastNotify.Services
{
    public interface INotifyService
    {
        void Success(string message = null);
        void Error(string message = null);
        void Information(string message = null);
        void Warning(string message = null);
        void Custom(string message = null);
        IEnumerable<Notification> GetNotifications();
        IEnumerable<Notification> ReadAllNotifications();
        void RemoveAll();
    }
}
