using ECommerce.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Services
{
    public class CatalogService : ICatalog
    {
        private readonly ApplicationDbContext _context;

        public CatalogService(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Catalog> GetCatalogs()
        { 
            return _context.Catalogs.Include(x=>x.SubCatalogs);
        }
        public IEnumerable<SubCatalog> GetSubCatalogs()
        {
            return _context.SubCatalogs;
        }

        public IEnumerable<SubCatalog> GetSubCatalogsByCatalogId(int? id)
        {
            return _context.SubCatalogs.Where(x => x.CatalogId == id);
        }
    }
}
