using ECommerce.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    public class ProductService : IProduct
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetProductsBySubCatalogId(int? id) =>
            _context.Products.Where(x => x.SubCatalogId == id);

        public IEnumerable<Product> GetProductsBySubCatalogIds(int? id1, int? id2, int? id3) =>
            _context.Products.Where(x=>x.SubCatalogId == id1 && 
            x.SubCatalogId==id2 && x.SubCatalogId == id3);
    }
}
