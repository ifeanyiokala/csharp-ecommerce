using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kalashop.Interfaces;
using Microsoft.AspNetCore.Mvc;
using kalashop.Data.Cart;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using kalashop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace kalashop.Controller
{
    public class OrderController
    {
    [Authorize]
    public class OrdersController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ShoppingCart  _shoppingCart;
        private readonly ILogger<OrdersController> _logger;
        private readonly IOrderService _ordersService;

        public OrdersController( IProductService productService, ShoppingCart shoppingCart, ILogger<OrdersController> logger, IOrderService ordersService)
        {
            //_productService = productService;
            _shoppingCart = shoppingCart;
            _logger = logger;
            _ordersService = ordersService;
        }

        /*public async Task<IActionResult> Index()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userRole = User.FindFirstValue(ClaimTypes.Role);
            _logger.LogInformation("I am currently within the index action of the Orders Controller.");

            var orders = await _ordersService.GetOrderByUserIdAndRoleAsync(userId, userRole);
            return View(orders);
        }*/

        public IActionResult ShoppingCart()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.shoppingCartItems = items;

            _logger.LogInformation("I am currently within the ShoppingCart action of the Orders Controller.");

            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal(),
            };

            return View(response);
        }

            private IActionResult View(ShoppingCartVM response)
            {
                throw new NotImplementedException();
            }

            public async Task<IActionResult> AddItemToShoppingCart(int id)
        {
            var item = await _productService.GetProductByIdAsync(id);
            if (item != null)
            {
                _shoppingCart.AddItemToCart(item);
            }

            _logger.LogInformation("Order added Successfully.");
            return RedirectToAction(nameof(ShoppingCart));

        }

        public async Task<IActionResult> RemoveItemFromShoppingCart(int id)
        {
            var item = await _productService.GetProductByIdAsync(id);
            if (item != null)
            {
                _logger.LogInformation("Order remove Successfully.");
                _shoppingCart.RemoveItemFromCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));

        }

        public async Task<IActionResult> CompleteOrder()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userEmailAddress = User.FindFirstValue(ClaimTypes.Email);

            await _ordersService.StoreOrderAsync(items, userId, userEmailAddress);
            await _shoppingCart.ClearShoppingCartAsync();
            _logger.LogInformation("Order Completed Successfully.");

            return View("OrderCompleted");
        }

            private IActionResult View(string v)
            {
                throw new NotImplementedException();
            }
        }
}
}