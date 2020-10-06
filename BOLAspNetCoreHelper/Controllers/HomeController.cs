using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BOLAspNetCoreHelper.Models;
using System.Globalization;

namespace BOLAspNetCoreHelper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BOLHelper _bol;

        public HomeController(ILogger<HomeController> logger, BOLHelper bol)
        {
            _logger = logger;
            _bol = bol;
        }

        public IActionResult Index()
        {
            int c = 0;
            try
            {
                int g = 5 / c;
            }
            catch (Exception ex)
            {
                _bol.Send(ex);
            }
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
