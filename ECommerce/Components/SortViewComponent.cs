using Microsoft.AspNetCore.Mvc;
using ECommerce.Models.Home;

namespace ECommerce.Components
{
    public class SortViewComponent : ViewComponent
    {
        private readonly SortModel _sortModel;
        public SortViewComponent()
        {
            _sortModel = new SortModel();
        }
        public IViewComponentResult Invoke(int id)
        {
            _sortModel.CategoryId = id;
            return View(_sortModel);
        }
    }
}
