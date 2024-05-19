using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kalashop.Models;
using kalashop.ViewModels;

namespace kalashop.Interfaces
{
    public interface IProductService 
    {
         Task<Product> GetProductByIdAsync(int id);
        //Task<NewProductDropdownsVM> GetNewProductDropdownsValuesAsync();
        Task AddNewProductAsync(NewProductVM newProduct);

        Task UpdateProductAsync(NewProductVM data);
    }
}