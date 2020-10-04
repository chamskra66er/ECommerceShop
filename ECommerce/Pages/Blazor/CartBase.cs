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
        [Inject]
        public ECommerce.Data.Cart _cart { get; set; }

        [Inject]
        public IProduct _productService { get; set; }

        public IEnumerable<CartLine> _cartLines;

        protected override Task OnInitializedAsync()
        {
            _cartLines = _cart.Lines;
            return base.OnInitializedAsync();
        }
        protected void AddToCart(int id)
        {
            var product = _productService.GetProductById(id);
            if (product != null)
            {
                _cart.AddItem(product, 1);
            }
        }

        protected void RemoveFromCart(int id)
        {
            var product = _productService.GetProductById(id);
            if (product != null)
            {
                _cart.SubItem(product, 1);
            }
        }

        protected void DeleteCartItem(int id)
        {
            var product = _productService.GetProductById(id);
            if (product != null)
            {
                _cart.RemoveLine(product);
            }
        }

    }
}
