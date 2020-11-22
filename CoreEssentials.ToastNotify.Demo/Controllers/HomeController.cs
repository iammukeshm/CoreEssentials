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

        public INotifyService _notifyService { get; }

        public HomeController(ILogger<HomeController> logger, INotifyService notifyService)
        {
            _logger = logger;
            _notifyService = notifyService;
        }

        public IActionResult Index()
        {
            _notifyService.Success("Mukesh Rules");
            _notifyService.Error("Mukesh Rules");
            _notifyService.Warning("Mukesh Rules");
            _notifyService.Information("Mukesh Rules");
            _notifyService.Custom("Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "orange", "fa fa-gear");
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
