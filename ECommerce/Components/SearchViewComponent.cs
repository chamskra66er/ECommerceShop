using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Components
{
    public class SearchViewComponent : ViewComponent
    {

        public SearchViewComponent()
        {
        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
