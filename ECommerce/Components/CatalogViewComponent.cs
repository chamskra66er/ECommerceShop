using ECommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Components
{
    public class CatalogViewComponent : ViewComponent
    {
        private readonly ICatalog _catalog;

        public CatalogViewComponent(ICatalog catalog)
        {
            _catalog = catalog;
        }
        public IViewComponentResult Invoke()
        {
            return View(_catalog.GetCatalogs());
        }
    }
}
