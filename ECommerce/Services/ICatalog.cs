using ECommerce.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    public interface ICatalog
    {
       IEnumerable<Catalog> GetCatalogs();
        IEnumerable<SubCatalog> GetSubCatalogs();
    }
}
