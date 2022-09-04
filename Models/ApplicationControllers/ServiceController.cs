using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace Mvc_LoginApp.ApplicationControllers
{
    [Route("[controller]/[action]")]
    public class ServiceController: Controller
    {
        public IActionResult Index() => RedirectToAction("ListServices");
        [HttpGet] public IActionResult ListServices() => View("ListServices", new List<string>() );
        [HttpPost] public IActionResult ListActions( string service ) => View("ListServices", new List<string>());
    }
}
