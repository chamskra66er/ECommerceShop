using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Components
{
    public class FilterViewComponent : ViewComponent
    {
        public FilterViewComponent()
        {

        }

        public IViewComponentResult Invoke(int id)
        {
            return View();
        }
    }
}
