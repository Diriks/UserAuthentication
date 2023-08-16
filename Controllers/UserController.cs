using Microsoft.AspNetCore.Mvc;

namespace UserAuthentication.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
