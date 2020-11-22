using CoreEssentials.ToastNotify.Demo.Models;
using CoreEssentials.ToastNotify.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEssentials.ToastNotify.Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IToastNotifyService _notifyService { get; }

        public HomeController(ILogger<HomeController> logger, IToastNotifyService notifyService)
        {
            _logger = logger;
            _notifyService = notifyService;
        }

        public IActionResult Index()
        {
            _notifyService.Success("Sucess Notification - closes in 1 seconds.", 1);
            _notifyService.Error("Error Notification - closes in 2 seconds.", 2);
            _notifyService.Warning("Warning Notification - closes in 3 seconds.", 3);
            _notifyService.Information("Information Notification - closes in 4 seconds.", 4);
            _notifyService.Custom("Custom Notification - closes in 5 seconds.", 5, "#135224", "fa fa-gear");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
