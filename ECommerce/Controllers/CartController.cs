using ECommerce.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Services;

namespace ECommerce.Controllers
{
    public class CartController : Controller
    {
        private readonly Cart _cart;
        private readonly IProduct _productService;

        public CartController(Cart cart)
        {
            _cart = cart;
        }

        public IActionResult AddToCart(int id)
        {
            var product = _productService.GetById(id);
            if (product != null)
            {
                _cart.AddItem(product, 1);
            }
            return Redirect("/Blazor/Cart");
        }
    }
}
