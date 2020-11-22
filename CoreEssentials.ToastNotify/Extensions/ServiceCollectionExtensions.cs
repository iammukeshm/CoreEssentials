using CoreEssentials.ToastNotify.Containers;
using CoreEssentials.ToastNotify.Helpers;
using CoreEssentials.ToastNotify.Models;
using CoreEssentials.ToastNotify.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreEssentials.ToastNotify.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddToastNotify(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            #region Framework Services
            //Check if a TempDataProvider is already registered.
            var tempDataProvider = services.FirstOrDefault(d => d.ServiceType == typeof(ITempDataProvider));
            if (tempDataProvider == null)
            {
                //Add a tempdata provider when one is not already registered
                services.AddSingleton<ITempDataProvider, CookieTempDataProvider>();
            }
            //check if IHttpContextAccessor implementation is not registered. Add one if not.
            var httpContextAccessor = services.FirstOrDefault(d => d.ServiceType == typeof(IHttpContextAccessor));
            if (httpContextAccessor == null)
            {
                services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            }

            #endregion
            //Add TempDataWrapper for accessing and adding values to tempdata.
            services.AddSingleton<ITempDataService, TempDataService>();
            services.AddSingleton<INotificationContainer<Notification>, NotificationContainer<Notification>>();

            //Add the ToastNotification implementation
            services.AddScoped<INotifyService, NotifyService>();
        }
    }
}
