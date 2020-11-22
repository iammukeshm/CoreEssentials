using CoreEssentials.ToastNotify.Helpers;
using CoreEssentials.ToastNotify.Models;
using CoreEssentials.ToastNotify.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreEssentials.ToastNotify.Views.Shared.Components.ToastNotify
{
    [ViewComponent(Name = "ToastNotify")]
    public class ToastNotifyViewComponent : ViewComponent
    {
        private readonly IToastNotifyService _service;

        public ToastNotifyViewComponent(IToastNotifyService service, ToastNotifyOptions options)
        {
            this._service = service;
            _options = options;
        }

        public ToastNotifyOptions _options { get; }

        public IViewComponentResult Invoke()
        {
            var model = new ToastNotifyViewModel
            {
                Configuration = _options.ToJson(),
                Notifications = _service.ReadAllNotifications()
            };
            return View("Default", model);
        }
    }
}
