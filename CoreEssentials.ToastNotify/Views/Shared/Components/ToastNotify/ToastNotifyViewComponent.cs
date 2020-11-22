using CoreEssentials.ToastNotify.Helpers;
using CoreEssentials.ToastNotify.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEssentials.ToastNotify.Views.Shared.Components.ToastNotify
{
    [ViewComponent(Name = "ToastNotify")]
    public class ToastNotifyViewComponent : ViewComponent
    {
        private readonly INotifyService _service;

        public ToastNotifyViewComponent(INotifyService service)
        {
            this._service = service;
        }
        public IViewComponentResult Invoke()
        {
            var toastNotifyOptions = new ToastNotifyOptions();
            var model = new ToastNotifyViewModel
            {
                Configuration = toastNotifyOptions.ToJson(),
                Notifications = _service.ReadAllNotifications()
            };
            return View("Default", model);
        }
    }
}
