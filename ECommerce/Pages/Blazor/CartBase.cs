using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ECommerce.Services;
using ECommerce.Data;

namespace ECommerce.Pages.Blazor
{
    public class CartBase : ComponentBase
    {
        private readonly ECommerce.Data.Cart _cart;

        private readonly IProduct _productService;

        private IEnumerable<CartLine> _cartLines;

        public CartBase(ECommerce.Data.Cart cart, IProduct productService)
        {
            _cart = cart;
            _productService = productService;
        }

        protected override async Task OnInitializedAsync()
        {
            _cartLines = _cart.Lines;
        }
        private void AddToCart(int id)
        {
            var product = _productService.GetProductById(id);
            if (product != null)
            {
                _cart.AddItem(product, 1);
            }
        }

        private void RemoveFromCart(int id)
        {
            var product = _productService.GetProductById(id);
            if (product != null)
            {
                _cart.SubItem(product, 1);
            }
        }

        private void DeleteCartItem(int id)
        {
            var product = _productService.GetProductById(id);
            if (product != null)
            {
                _cart.RemoveLine(product);
            }
        }

    }
}
