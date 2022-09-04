using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Threading.Tasks;
using static pickpoint_delivery_service.CustomerContext;
using System.ComponentModel.DataAnnotations;
using static System.Console;
using static Newtonsoft.Json.JsonConvert;
using Newtonsoft.Json.Linq;
using pickpoint_delivery_service.Patterns;
using pickpoint_delivery_service.Controllers;
using Newtonsoft.Json;
using pickpoint_delivery_service.Delivery;
using System.Collections.Concurrent;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace pickpoint_delivery_service.Controllers
{


    
    [Area("User")]
    public class UserHomeController : SearchController<Product>
    {


        private readonly DeliveryDbContext _context;

        public AuthorizationUsers _users { get; }

        private readonly IWebHostEnvironment _env;
        private readonly IDeliveryDbContextInitiallizer _initiallizer;
        private readonly ILogger<UserHomeController> _logger;

        private readonly IEventsService _events;

        public UserHomeController(
            ILogger<UserHomeController> logger, 
            IWebHostEnvironment env,
            IDeliveryDbContextInitiallizer initiallizer,
            IEventsService events,
            AuthorizationUsers users,
            DeliveryDbContext context)
        {
            _context = context;
            _users = users;
            
            _logger = logger;
            _logger.LogInformation($"Content Path:  {env.ContentRootPath.Substring(0, env.ContentRootPath.Length - 1)}");
            _logger.LogInformation($"Web Path:      {env.WebRootPath}");
            _env = env;
            _events = events;
            _initiallizer = initiallizer;

           
            
        }
        public IActionResult Index() => View();
        public IActionResult ProductSearch()
            => Redirect("/User/Product/ProductSearch");

        public IActionResult Init() 
        =>Json(
            _initiallizer.Init(_context, _env.ContentRootPath )
        );    


        [HttpGet()]
        public System.Collections.Generic.IDictionary<string, string> GetOptions()
        {
            var options = new Dictionary<string, string>();
            foreach (var method in this.GetType().GetMethods())
            {
                string query = "";
                foreach (var parameter in method.GetParameters())
                {
                    query += $"{parameter.Name}=" + "{" + parameter.ParameterType.Name + "}";
                }
                if (query.Length > 0)
                    query = "?" + query.Substring(1);
                options[query] = query;
            }
           
            return options;
        }

        public async Task<IEnumerable<Order>> GetOrders()
            => await _context.Orders.ToListAsync();
        public async Task<Order> GetOrder(int customerId, int orderId)
        {
            var order = _context.Orders.Find(orderId);
            order.OrderItems = await this.GetOrderItems(orderId);
            return order;
        }

        public async Task<IEnumerable<Order>> GetCustomerOrders(int customerId)
        {
            return await _context.Orders.Where(o => o.CustomerID == customerId).OrderByDescending(o => o.OrderCreated).ToListAsync();
        }

        private async Task<IEnumerable<OrderItem>> GetOrderItems(int orderId)
        {
            return await _context.OrderItems.Include(item => item.Product).Where(o => o.OrderID == orderId).ToListAsync();
        }

        public async Task<Order> CreateOrder(int customerId)
        {
            var order = new Order()
            {
                CustomerID = customerId,
                OrderCreated = DateTime.Now
            };
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return order;
        }



        public async Task<OrderItem> AddItem(int customerId, int orderId, int productId, int productCount)
        {

            var item = new OrderItem()
            {
                ProductID = productCount,
                ProductCount = productCount,
                OrderID = orderId
            };
            Order order = _context.Orders.Find(orderId);
            order.OrderUpdated = DateTime.Now;
            order.UpdateCounter++;
            _context.OrderItems.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<int> RemoveItem(int customerId, int orderItemId)
        {
            var item = _context.OrderItems.Find(orderItemId);
            var order = _context.Orders.Find(item.OrderID);
            _context.OrderItems.Remove(item);
            order.OrderUpdated = DateTime.Now;
            order.UpdateCounter++;
            return await _context.SaveChangesAsync();
        }

        public Order CheckoutOrder(int customerId, int orderId)
        {
            var order = _context.Orders.Find(orderId);
            order.OnOrderCreated();
            _context.SaveChanges();
            _events.Publish("CustomerCheckoutOrder", order);
            return order;
        }

        public override SearchModel<Product> GetModel()
        {
            return new SearchModel<Product>();
        }

        public override IEnumerable<string> GetOptions(string Query)
        {
            return new List<string>();
        }
    }
}
