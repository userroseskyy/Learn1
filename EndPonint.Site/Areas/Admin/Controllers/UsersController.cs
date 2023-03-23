using Microsoft.AspNetCore.Mvc;

namespace EndPonint.Site.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
