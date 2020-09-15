using ECommerce.Areas.Identity.Pages.Account;
using ECommerce.Models.Account;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Components
{
    public class LoginViewComponent :ViewComponent
    {
        public LoginViewModel _model;
        public LoginViewComponent()
        {
            _model = new LoginViewModel();
        }
        public IViewComponentResult Invoke()
        {
            return View(_model);
        }
    }
}
