using Microsoft.AspNetCore.Mvc;

namespace Mvc_LoginApp.ApplicationControllers
{
    public class DataController: Controller
    {


        public IActionResult Index() => RedirectToAction("StateChart");
        public IActionResult StateChart() => View();
    }
}
