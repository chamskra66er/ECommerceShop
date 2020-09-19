using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ECommerce.Models;
using ECommerce.Data;
using ECommerce.Services;

namespace ECommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICatalog _catalogContext;

        public HomeController(ILogger<HomeController> logger, ICatalog catalogs)
        {
            _logger = logger;
            _catalogContext = catalogs;
        }

        public IActionResult Index()
        {
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
        public IActionResult TVShow(string id)
        {
            //IEnumerable<Product> _products;
            string viewName = null;

            switch (id)
            {
                case "tv":
                    //var model = _catalogContext.GetSubCatalogs().Where(x=>x.SubName==id)
                    break;
                default:
                    break;
            }
            return View();
        }
    }
}
