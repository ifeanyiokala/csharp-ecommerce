using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kalashop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace kalashop.Data
{
    public class ApplicationDBContext : IdentityDbContext<User>
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {
            
        }

        //public DbSet<User> User {get; set;}
        public DbSet<Product> Product {get; set;}

        public DbSet<Category> Category {get; set;}

        public DbSet<ShoppingCartItem> ShoppingCartItems {get; set;}
        public DbSet<Order> Orders { get; set; }
        public DbSet<Orderitem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                            new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER"

                },

            };
            builder.Entity<IdentityRole>().HasData(roles);

}
    }
}