using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kalashop.Data;
using kalashop.Interfaces;
using kalashop.Models;
using kalashop.ViewModels;


namespace kalashop.Service
{
    public class ProductService
    {
        public class ProductsService : IProductService
    {
        private readonly ApplicationDBContext _context;
        public ProductsService(ApplicationDBContext dbContext) : base()
        {
            _context = dbContext;
        }

            public Task AddNewProductAsync(NewProductVM newProduct)
            {
                throw new NotImplementedException();
            }

            public Task<Product> GetProductByIdAsync(int id)
            {
                throw new NotImplementedException();
            }

            public Task UpdateProductAsync(NewProductVM data)
            {
                throw new NotImplementedException();
            }
        }
        public async Task AddNewProductAsync(NewProductVM newProduct)
        {
            var product = new Product()
            {
                Id = newProduct.Id,
                Name = newProduct.Name,
                Price = newProduct.Price,
            

            };
        }
    }
}

            //await _context.Products.AddAsync(product);
            //await _context.SaveChangesAsync();

            //Add Movie Actors
            /*
            foreach (var actorId in newProduct.ActorIds)
            {
                var newProduct = new new_Product()
                {
                    ProductId = product.Id,
                
                };

                await _context.new_Product.AddAsync(newProduct);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<Product> GetMovieByIdAsync(int id)
        {
            var productDetails = await _context.Products
                //.Include(c => c.Cinema)
                //.Include(p => p.Producer)
                //.Include(am => am.Actors_Movies).ThenInclude(a => a.Actor)
                //.FirstOrDefaultAsync(n => n.Id == id);
            return productDetails;
        }

        public async Task<NewMProductDropdownsVM> GetNewProductDropdownsValuesAsync()
        {
            var response = new NewProductDropdownsVM()
            {
                //Actors = await _context.Actors.OrderBy(n => n.FullName).ToListAsync(),
                //Cinemas = await _context.Cinemas.OrderBy(n => n.Name).ToListAsync(),
                //Producers = await _context.Producers.OrderBy(n => n.FullName).ToListAsync()
            };

            return response;
        }

        public Task<Product> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateProductAsync(NewProductVM data)
        {
            var dbProduct = await _context.Product.FirstOrDefaultAsync(n => n.Id == data.Id);

            if (dbProduct != null)
            {
                dbProduct.Name = data.Name;
                dbProduct.Id = data.Id;
                dbProduct.Price = data.Price;
                dbProduct.Seller = data.Product;
                await _context.SaveChangesAsync();
            }

            //Remove Existing Actors

            var existingActorsDb = _context.Actors_Movies.Where(n => n.MovieId == data.Id).ToList();
            _context.Actors_Movies.RemoveRange(existingActorsDb);

            await _context.SaveChangesAsync();

            //Add Movie Actors
            foreach (var actorId in data.ActorIds)
            {
                var newActorMovie = new Actor_Movie()
                {
                    MovieId = data.Id,
                    ActorId = actorId,
                };

                await _context.Actors_Movies.AddAsync(newActorMovie);
            }
            await _context.SaveChangesAsync();
        }

        Task<NewProductDropdownsVM> IProductService.GetNewProductDropdownsValuesAsync()
        {
            throw new NotImplementedException();
        }

        Task<Product> IProductService.GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
*/