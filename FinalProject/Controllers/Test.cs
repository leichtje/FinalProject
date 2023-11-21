using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class Test : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
