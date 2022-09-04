using Microsoft.AspNetCore.Mvc;

using System;

namespace Mvc_LoginApp.Areas.User.Controllers
{
    [Area("User")]
    public class UserSettingsController: Controller
    {
        public IActionResult Index() => Redirect("/User/UserSettings/EditSettings");
                
        public IActionResult EditSettings([FromServices] IUserAuthentication userAuthentication)
        {
            try
            {
                var settings = userAuthentication.Authenticate().Settings;
                return View(settings);
            }
            catch(Exception ex)
            {
                return View("Exception", new Exception("Исключение при получении настроек пользователя. ", ex));
            }          
        }
    }
}
