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
using ECommerce.Models.ProductModel;
using ECommerce.Models.Home;

namespace ECommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICatalog _catalogContext;
        private readonly IProduct _productService;

        public HomeController(ILogger<HomeController> logger, ICatalog catalogs, IProduct product)
        {
            _logger = logger;
            _catalogContext = catalogs;
            _productService = product;
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
                    var model = _catalogContext.GetSubCatalogsByCatalogId(2);
                    ViewData["Message"] = "Категории";
                    return View("TVMain", model);
                case "tv0":
                    //subid = 1
                    var model0 = _productService.GetProductsBySubCatalogId(1);

                    var prod0 = new ProductViewModel
                    {
                        Products = model0,
                        id = "tv0"
                    };

                    ViewData["Message"] = "Телевизоры";
                    return View(prod0);
                case "tv1":
                    //subid = 2
                    var model1 = _productService.GetProductsBySubCatalogId(2);
                    var prod1 = new ProductViewModel
                    {
                        Products = model1,
                        id = "tv1"
                    };
                    ViewData["Message"] = "Цифровое ТВ";
                    return View(prod1);
                case "tv2":
                    //subid = 3
                    var model2 = _productService.GetProductsBySubCatalogId(3);
                    var prod2 = new ProductViewModel
                    {
                        Products = model2,
                        id = id
                    };
                    ViewData["Message"] = "Домашний кинотеатр";
                    return View(prod2);
                default:
                    break;
            }
            return View();
        }

        public IActionResult CatDetail(int id)
        {
            var model = _productService.GetProductByCategoryId(id);
            ViewData["Message"] = model.FirstOrDefault().Category;
            return View(model);
        }

        //[HttpPost]
        //public JsonResult SortAlphabet(string dataToSend)
        //{
        //    return Json(
        //        new { redirectTo = Url.Action("Index", "Home") }
        //        );
        //}
        [HttpGet]
        public IActionResult SortAlphabet(int id)
        {
            var model = _productService.GetProductByCategoryId(id).OrderBy(x => x.Name);
            ViewData["Message"] = model.FirstOrDefault().Category;
            return View("CatDetail", model);
        }

        [HttpGet]
        public IActionResult SortRait(int id)
        {
            var model = _productService.GetProductByCategoryId(id).OrderBy(x => x.Rait);
            ViewData["Message"] = model.FirstOrDefault().Category;
            return View("CatDetail", model);
        }

        [HttpGet]
        public IActionResult SortPrice(int id)
        {
            var model = _productService.GetProductByCategoryId(id).OrderBy(x => x.Price);
            ViewData["Message"] = model.FirstOrDefault().Category;
            return View("CatDetail", model);
        }

        [HttpPost]
        public IActionResult Filter(FilterModel filterModel)
        {
            int cateId = filterModel.CategoryId;
            var model = _productService.GetProductByCategoryId(cateId).Where(x => x.Price >= filterModel.PriceDown
            && x.Price <= filterModel.PriceUp);

            foreach (var item in filterModel.Brands)
            {
                model.Where(x=>x.Brand == item);
            }
            return View(model);
        }
    }
}
