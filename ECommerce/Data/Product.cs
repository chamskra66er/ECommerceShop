using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Data
{
    public class Product
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Brand { get; set; }
        public Image Image { get; set; }
        public double Price { get; set; }
        public int Rait { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public string Size { get; set; }
    }
}
