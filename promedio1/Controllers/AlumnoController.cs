using Microsoft.AspNetCore.Mvc;
using promedio1.Models;//esto es una importacion para cargar los modelos de la importacion
namespace promedio1.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            return View();  
        }
        [HttpPost]//accuib que permiute encuar por el medio post ñp qie cargue el fo
        public ActionResult CalcularPromedio(Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado",alumno);
            }
            return View("Index");
        }
    }
}