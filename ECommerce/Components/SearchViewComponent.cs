using ECommerce.Models.Home;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Components
{
    public class SearchViewComponent : ViewComponent
    {
        private SearchModel _model;
        public SearchViewComponent()
        {
            _model = new SearchModel();
        }
        public IViewComponentResult Invoke()
        {
            return View(_model);
        }
    }
}
