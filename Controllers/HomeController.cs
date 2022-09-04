using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
 

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_LoginApp.Controllers
{
    
    public class HomeController : Controller
    {
        public IActionResult Index() => Redirect("/Home/Start");
        public IActionResult Start([FromServices] pickpoint_delivery_service.DeliveryDbContext db) 
            => View(new StartModel()
        {
            Cards = db.Products.Include(p=>p.ProductImages).ToList(),
            Links = new Dictionary<string, IDictionary<string, string>>()
        });
        

        public IActionResult About() => View();
        public IActionResult Config() => View();
        public IActionResult Privacy() => View();
        public new IActionResult NotFound() => View();
        public IActionResult Forbidden() => View();

        public IActionResult Exception() =>
            throw new Exception( $"{GetType().Name} throws Exception" );
        public IActionResult ClearHistory([FromServices] AppDbContext context)
        {
            foreach (var activity in context.ProductActivities.ToList())
            {
                context.ProductActivities.Remove(activity);
            }
            context.SaveChanges();
            return Redirect("/Home/Index");
        }
    }
}
