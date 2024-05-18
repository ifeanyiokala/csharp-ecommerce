using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kalashop.Dto.Product
{
    public class CreateProductRequestDto
    {
        public float Price { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Seller { get; set; } = string.Empty;
    }
}