using ECommerce.Models.Home;
using ECommerce.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ECommerce.Components
{
    public class FilterViewComponent : ViewComponent
    {
        private readonly FilterModel _filterModel;
        private readonly IProduct _productService;

        public FilterViewComponent(IProduct productService)
        {
            _filterModel = new FilterModel();
            _productService = productService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var model = _productService.GetProductByCategoryId(id);
            var modelBrands = model.Select(x => x.Brand).Distinct().ToList();
            double priceDown = model.Select(x => x.Price).Min();
            double priceUp = model.Select(x => x.Price).Max();

            _filterModel.Brands = modelBrands;
            _filterModel.PriceDown = priceDown;
            _filterModel.PriceUp = priceUp;
            _filterModel.CategoryId = id;

            return View(_filterModel);
        }
    }
}
