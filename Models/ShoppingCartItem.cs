using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kalashop.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }

        //public int ProductId { get; set; }
        
        public float Price { get; set; }

        public string Product { get; set; } = string.Empty;

        public string ShoppingCartId { get; set; } = string.Empty;
    }
}


