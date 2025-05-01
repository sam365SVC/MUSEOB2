using Microsoft.AspNetCore.Mvc;

namespace MUSEOB2.Controllers
{
    public class PantallaPrincipal : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
