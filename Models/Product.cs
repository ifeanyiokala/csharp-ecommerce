using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kalashop.Models
{
    public class Product
    {
        public int Id { get; set; }

        //public int ProductId { get; set; }
        
        public float Price { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Seller { get; set; } = string.Empty;

       // public int CategoryID {get; set;}
    }
}

