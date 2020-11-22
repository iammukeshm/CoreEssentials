using CoreEssentials.ToastNotify.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEssentials.ToastNotify.Views.Shared.Components.ToastNotify
{
    public class ToastNotifyViewModel
    {
        public string Configuration { get; set; }
        public IEnumerable<Notification> Notifications { get; set; }
    }
}
