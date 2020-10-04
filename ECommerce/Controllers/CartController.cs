using ECommerce.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using ECommerce.Services;

namespace ECommerce.Controllers
{
    public class CartController : Controller
    {
        private readonly Cart _cart;
        private readonly IProduct _productService;

        public CartController(Cart cart, IProduct productService)
        {
            _cart = cart;
            _productService = productService;
        }

        public IActionResult AddToCart(int id)
        {
            var product = _productService.GetProductById(id);
            if (product != null)
            {
                _cart.AddItem(product, 1);
            }
            return Redirect("/Blazor/CartBaseView");
        }
    }
}
