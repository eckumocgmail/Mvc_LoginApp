using Microsoft.AspNetCore.Mvc;

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

