using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Data
{
    public class SubCatalog
    {
        public int Id { get; set; }
        public int CatalogId { get; set; }
        public string SubName { get; set; }
        public string ImgUrl { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
