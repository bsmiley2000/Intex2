using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Intex2.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Pages/Index.cshtml");
        }

        /*to add authorization*/
        [Authorize]
        public IActionResult Burial()
        {
            return View();
        }
    }
}
