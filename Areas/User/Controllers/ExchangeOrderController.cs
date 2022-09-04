using Microsoft.AspNetCore.Mvc;

namespace Mvc_LoginApp.ApplicationControllers
{
    [Area("User")]
    public class ExchangeOrderController: Controller
    {

        public IActionResult Index() => RedirectToAction("ExchangeOrder");
        public IActionResult Exchange() => RedirectToAction("ExchangeCheckout");
        public IActionResult ExchangeCheckout() => View();
    }
}
