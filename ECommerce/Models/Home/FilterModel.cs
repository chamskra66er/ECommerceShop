using System.Collections.Generic;

namespace ECommerce.Models.Home
{
    public class FilterModel
    {
        public int CategoryId { get; set; }
        public List<string> Brands { get; set; }
        public double PriceDown { get; set; }
        public double PriceUp { get; set; }
    }
}
