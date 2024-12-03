using Microsoft.AspNetCore.Mvc;

namespace promedio1.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            return View();  
        }
    }
}
