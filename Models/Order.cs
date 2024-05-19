using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kalashop.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string Email { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        
        public string UserName { get; set; } = string.Empty;

        public List<Orderitem> Orderitems { get; set; } 
    }
}