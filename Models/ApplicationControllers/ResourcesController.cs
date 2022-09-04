using Microsoft.AspNetCore.Mvc;

namespace Mvc_LoginApp.ApplicationControllers
{
    public class ResourcesController: Controller
    {

        public IActionResult Index() => Redirect("/Data/StateChart");
        public IActionResult StateChart() => View();
    }
}
