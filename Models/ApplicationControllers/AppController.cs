using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Mvc_Apteka.Entities;

using pickpoint_delivery_service;
using pickpoint_delivery_service.Patterns;

public class AppController : Controller
{
    public IActionResult Index() => Redirect("/App/ListModules");    
    public IActionResult ListModules([FromServices] DeliveryDbContext db ) => View("ListModules", db.Products.Include(p=>p.ProductImages));
    
}