using Microsoft.AspNetCore.Mvc;

namespace Mvc_LoginApp.Controllers
{
    [Route("[controller]/[action]")]
    public class LogoutController: Controller
    {


        public IActionResult Index() => RedirectToAction("Logout");
        public IActionResult Logout([FromServices] IUserLogout logout)
        {
            logout.Signout();
            return Redirect("/Login/Login");
        }
    }
}
