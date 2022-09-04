using Microsoft.AspNetCore.Mvc;

 
[Route("[controller]/[action]")]
public class RegistrationController : Controller
{
    public IActionResult Index() => RedirectToAction("Registration");
    [HttpGet] public IActionResult Registration() => View("Registration",new RegistrationModel());
    [HttpPost]
    public IActionResult Registration([FromServices] IAccountRegistration registration, RegistrationModel model)
    {
        if (ModelState.IsValid)
        {

            if(registration.Signup(model.Email, model.Password))
            {
                return Redirect("/Login/Login");
            }
            else
            {
                model.Message = "Регистрация не выполнена (пользователь уже зарегистрирован)";
                return View(model);
            }
        }
        else
        {
            return View(model);
        }
    }

}
