using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Components
{
    public class CategoryViewComponent : ViewComponent
    {

        public CategoryViewComponent()
        {

        }
        public IViewComponentResult Invoke(string id)
        {
            List<string> categories = null;
            switch (id)
            {
                case "tv1":
                    categories = new List<string>
                    { 
                        "4К Телевизоры",
                        "Смарт-телевизоры",
                        "FULL HD-телевизоры"
                    };
                    break;

                default:
                    break;
            }
            return View(categories);
        }
    }
}
