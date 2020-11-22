using CoreEssentials.ToastNotify.Constants;
using CoreEssentials.ToastNotify.Containers;
using CoreEssentials.ToastNotify.Enums;
using CoreEssentials.ToastNotify.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEssentials.ToastNotify.Services
{
    public class ToastNotifyService : IToastNotifyService
    {
        private readonly INotificationContainer<Notification> _container;

        public ToastNotifyService(INotificationContainer<Notification> container)
        {
            this._container = container;
        }
        public void Custom(string message, int? durationInSeconds = null, string backgroundColor = "black", string iconClassName = "info")
        {
            var toastMessage = new Notification(Enums.NotificationType.Custom, message, durationInSeconds);
            toastMessage.Icon = iconClassName;
            toastMessage.BackgroundColor = backgroundColor;
            _container.Add(toastMessage);
        }

        public void Error(string message, int? durationInSeconds = null)
        {
            var toastMessage = new Notification(Enums.NotificationType.Error, message, durationInSeconds);
            _container.Add(toastMessage);
        }

        public IEnumerable<Notification> GetNotifications()
        {
            return _container.GetAll();
        }

        public void Information(string message, int? durationInSeconds = null)
        {
            var toastMessage = new Notification(Enums.NotificationType.Information, message, durationInSeconds);
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

        public void Success(string message, int? durationInSeconds = null)
        {
            var toastMessage = new Notification(Enums.NotificationType.Success, message, durationInSeconds);
            _container.Add(toastMessage);
        }

        public void Warning(string message, int? durationInSeconds = null)
        {
            var toastMessage = new Notification(Enums.NotificationType.Warning, message, durationInSeconds);
            _container.Add(toastMessage);
        }
    }
}
