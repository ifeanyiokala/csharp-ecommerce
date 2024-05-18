using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kalashop.Dto.Product
{
    public class ProductDto
    {
        public int Id { get; set; }
        
        public float Price { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Seller { get; set; } = string.Empty;
    }
}

