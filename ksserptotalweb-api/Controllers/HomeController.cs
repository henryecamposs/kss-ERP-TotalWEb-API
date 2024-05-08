using System.Web.Mvc;

namespace ksserptotalweb_api.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Página de Inicio";

            return View();
        }
    }
}
