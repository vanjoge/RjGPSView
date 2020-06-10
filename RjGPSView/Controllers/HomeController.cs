using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RjGPSView.Models;
using SQ.Base;

namespace RjGPSView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string GpsText(string id)
        {
            if (Public.Instance.Data.TryGetValue(id, out var model))
            {
                return model.Txt;
            }
            return "";
        }
        public string GpsInfo(string id)
        {
            if (Public.Instance.Data.TryGetValue(id, out var model))
            {
                return model.ToJson();
            }
            return "false";
        }

        public int RpGps(string data)
        {
            Public.Instance.Data.TryFill(data);
            return 1;
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
