using Microsoft.AspNetCore.Mvc;
 

using System;
using System.Collections.Generic;

[Route("[controller]/[action]")]
public class LoginController: Controller
{
    public IActionResult Index() => RedirectToAction("Login");
    [HttpGet] public IActionResult Login()
    {
        if (ViewData.ContainsKey("Path") == false)
            ViewData["Path"] = new List<string>();
        ((List<string>)ViewData["Path"]).Clear();
        ((List<string>)ViewData["Path"]).AddRange("app-login".Split("-"));
        return View("Login", new LoginModel());
    }
    [HttpPost] public IActionResult Login([FromServices] AuthorizationOptions options, [FromServices] ITokenValidation validation, [FromServices] IUserLogin login, [FromServices] ITokenProvider provider, LoginModel model)
    {
        if (ModelState.IsValid)
        {
            string token = login.Signin(model.Email, model.Password);
            provider.Set(token);
            if (validation.IsValid(token))
            {
                return Redirect(options.UserHome);
            }
            else
            {
                model.Message = "Авторизация не выполнена";
                return View(model);
            }
        }
        else
        {
            return View(model);
        }
    }

        
}

