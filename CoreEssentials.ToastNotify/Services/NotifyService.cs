using CoreEssentials.ToastNotify.Containers;
using CoreEssentials.ToastNotify.Enums;
using CoreEssentials.ToastNotify.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEssentials.ToastNotify.Services
{
    public class NotifyService : INotifyService
    {
        private readonly INotificationContainer<Notification> _container;

        public NotifyService(INotificationContainer<Notification> container)
        {
            this._container = container;
        }
        public void Custom(string message = null)
        {
            var toastMessage = new Notification(NotificationType.Success, message);
            _container.Add(toastMessage);
        }

        public void Error(string message = null)
        {
            var toastMessage = new Notification(NotificationType.Error, message);
            _container.Add(toastMessage);
        }

        public IEnumerable<Notification> GetNotifications()
        {
            return _container.GetAll();
        }

        public void Information(string message = null)
        {
            var toastMessage = new Notification(NotificationType.Information, message);
            _container.Add(toastMessage);
        }

        public IEnumerable<Notification> ReadAllNotifications()
        {
            return _container.ReadAll();
        }

        public void RemoveAll()
        {
            _container.RemoveAll();
        }

        public void Success(string message = null)
        {
            var toastMessage = new Notification(NotificationType.Success, message);
            _container.Add(toastMessage);
        }

        public void Warning(string message = null)
        {
            var toastMessage = new Notification(NotificationType.Warning, message);
            _container.Add(toastMessage);
        }
    }
}
