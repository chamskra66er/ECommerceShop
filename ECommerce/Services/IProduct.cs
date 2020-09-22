using ECommerce.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    public interface IProduct
    {
        IEnumerable<Product> GetProductsBySubCatalogId(int? id);
        IEnumerable<Product> GetProductsBySubCatalogIds(int? id1, int? id2, int? id3);
        IEnumerable<Product> Search(string query);
        IEnumerable<Product> GetProductByCategoryId(int? id);
    }
}
