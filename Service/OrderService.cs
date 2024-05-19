using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kalashop.Data;
using kalashop.Interfaces;
using kalashop.Models;
using Microsoft.EntityFrameworkCore;

namespace kalashop.Service
{
    public class OrderService
    {
         public class OrdersService : IOrderService
    {
        private readonly ApplicationDBContext _context;
        public OrdersService(ApplicationDBContext context)
        {
            _context = context;
        } 
        
        public async Task<List<Order>> GetOrderByUserIdAndRoleAsync(string userId, string userRole)
        {
            var orders = await _context.Orders.Include(o => o.Orderitems).ThenInclude(m => m.Order)
                .Include(o => o.UserName).ToListAsync();

            if(userRole is not "Admin")
            {
                orders = orders.Where(u => u.UserId == userId).ToList();
            }
            return orders;

        }

        public async Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress)
        {
            var order = new Order()
            {
                UserId = userId,
                Email = userEmailAddress
            };

            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            foreach (var item in items)
            {
                var orderItem = new Orderitem()
                {
                    Price = item.Price,
                    //Product = item.Product,
                    OrderId = order.Id,
                    //Price = item.Price,
                
                };
                await _context.OrderItems.AddAsync(orderItem);
            }
            await _context.SaveChangesAsync();
        }
    }
}
    }
