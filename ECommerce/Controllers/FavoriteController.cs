using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace ECommerce.Controllers
{
    public class FavoriteController : Controller
    {
        private readonly IFavorite _favoriteService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public FavoriteController(IFavorite favoriteService, UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _favoriteService = favoriteService;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            if(!_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Login", "Account");
            }

            var userId = _userManager.GetUserId(User);
            var model = _favoriteService.GetByUserId(userId);
            return View(model);
        }

    }
}
