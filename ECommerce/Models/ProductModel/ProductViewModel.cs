using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Data;

namespace ECommerce.Models.ProductModel
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string id { get; set; }
    }
}
