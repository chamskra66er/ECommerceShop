using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Services;
using ECommerce.Models.Home;

namespace ECommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProduct _product;
        public ProductController(IProduct product)
        {
            _product = product;
        }
        [HttpPost]
        public IActionResult Search(SearchModel search)
        {
            var model = _product.Search(search.SearchQuery);
            return View(model);
        }
    }
}
