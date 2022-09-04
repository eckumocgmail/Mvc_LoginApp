using Microsoft.AspNetCore.Mvc;

[Area("User")]
public class OrderCheckout : Controller
{
    public IActionResult OrderStatusTracing() => View();
}

