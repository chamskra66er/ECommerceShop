﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Data
{
    public class Catalog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AwesomeIcon { get; set; }
        public IEnumerable<SubCatalog> SubCatalogs { get; set; }
    }
}
