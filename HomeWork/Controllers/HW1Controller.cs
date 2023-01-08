using Microsoft.AspNetCore.Mvc;

namespace HomeWork.Controllers
{
    public class HW1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
