using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Models.Account;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Components
{
    public class CatalogViewComponent : ViewComponent
    {
        public LoginViewModel _model;
        public CatalogViewComponent()
        {
            _model = new LoginViewModel();
        }
        public IViewComponentResult Invoke()
        {
            return View(_model);
        }
    }
}
