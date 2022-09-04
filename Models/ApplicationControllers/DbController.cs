using Microsoft.AspNetCore.Mvc;

namespace Mvc_LoginApp.Controllers
{
    [Route("[controller]/[action]")]
    public class DbController: Controller
    {

        public IActionResult Index() => Redirect("/Home/Index");
        public IActionResult InitApplication([FromServices] AuthDbContext context)
        {
            AuthDbInitiallizer.DoInitiallize();
            return Ok();
        }
    }
}
