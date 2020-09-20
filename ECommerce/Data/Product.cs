using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public virtual Image Image { get; set; }
        public double Price { get; set; }
        public int Rait { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public string Size { get; set; }
        public int SubCatalogId { get; set; }
        public string Category { get; set; }
    }
}
