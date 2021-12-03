using Microsoft.AspNetCore.Mvc;

namespace Genealogi.Controllers
{
    public class FamilyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
