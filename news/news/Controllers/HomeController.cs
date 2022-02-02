using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using news.Data;
using news.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace news.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        newsContext db;
        public HomeController(ILogger<HomeController> logger, newsContext newsContext)
        {
            _logger = logger;
            db = newsContext;
        }
       
     
        public IActionResult Index()
        {
            var categories = db.categories.ToList();
            return View(categories);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult about()
        {
            return View();
        }
        public IActionResult ContactUs()
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
