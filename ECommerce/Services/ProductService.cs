using ECommerce.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Services
{
    public class ProductService : IProduct
    {
        private readonly ApplicationDbContext _context;
        public ProductService() { }

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Image GetImageByProductId(int id) =>
            _context.Images.FirstOrDefault(x=>x.ProductId==id);

        public IEnumerable<Product> GetProductByCategoryId(int? id)=>
            _context.Products.Where(x => x.CategoryId == id).Include(x=>x.Image);

        public Product GetProductById(int id) =>
            //_context.Products.FirstOrDefault(x => x.Id == id);
            _context.Products.Where(x => x.Id == id).Include(p=>p.Image).
            Where(p=>p.Image.ProductId==id).FirstOrDefault();

        public IEnumerable<Product> GetProductsBySubCatalogId(int? id) =>
            _context.Products.Where(x => x.SubCatalogId == id);

        public IEnumerable<Product> GetProductsBySubCatalogIds(int? id1, int? id2, int? id3) =>
            _context.Products.Where(x=>x.SubCatalogId == id1 && 
            x.SubCatalogId==id2 && x.SubCatalogId == id3).Include(l=>l.Image);

        public IEnumerable<Product> Search(string query)=>
            _context.Products.Where(x => x.Name.Contains(query) || x.Brand.Contains(query));

    }
}
