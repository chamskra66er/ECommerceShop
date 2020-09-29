using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using ECommerce.Data;

namespace ECommerce.Controllers
{
    public class FavoriteController : Controller
    {
        private readonly IFavorite _favoriteService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IProduct _productService;

        public FavoriteController(IFavorite favoriteService, UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager, IProduct productService)
        {
            _favoriteService = favoriteService;
            _userManager = userManager;
            _signInManager = signInManager;
            _productService = productService;
        }

        public IActionResult Index()
        {
            if(!_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Login", "Account");
            }

            var userId = _userManager.GetUserId(User);
            var favorites = _favoriteService.GetByUserId(userId); 

            return View(favorites);
        }

        public async Task<IActionResult> AddFavorite(int id)
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Login", "Account");
            }

            var userId = _userManager.GetUserId(User);
            var model = _favoriteService.GetByUserIdAndProductId(userId, id);

            if(model !=null)
            {
                return RedirectToAction("Index");
            }

            var product = _productService.GetProductById(id);
            var favorite = new Favorite()
            {
                ProductId = product.Id,
                ProductName = product.Name,
                //ImgUrl = product.Image.Img1,
                UserId = userId
            };
            await _favoriteService.AddFavorite(favorite);

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Delete(int id)
        {
            //var favorite = _favoriteService
            return RedirectToAction("Index");
        }

    }
}
