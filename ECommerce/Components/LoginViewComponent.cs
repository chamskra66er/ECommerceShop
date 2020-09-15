using ECommerce.Areas.Identity.Pages.Account;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using static ECommerce.Areas.Identity.Pages.Account.LoginModel;

namespace ECommerce.Components
{
    public class LoginViewComponent :ViewComponent
    {
        public LoginModel _model;
        public LoginViewComponent()
        {
            _model = new LoginModel();
        }
        public IViewComponentResult Invoke()
        {
            return View(_model);
        }
    }
}
