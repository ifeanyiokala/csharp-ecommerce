using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kalashop.Dto.Product;
using kalashop.Models;

namespace kalashop.Mapper
{
    public static class ProductMappers
    {
        public static ProductDto ToProductDto(this Product productModel)
        {
            return new ProductDto

            {
                Id = productModel.Id,
                Name = productModel.Name,
                Price = productModel.Price,
                Seller = productModel.Seller

            };
        }
    
    }
}