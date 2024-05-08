using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ksserptotalweb_api.Areas.Pruebas.Controllers
{
    public class IndexController : Controller
    {
        // GET: Admin/Index
        public ActionResult Index()
        {
            ViewBag.Title = "Area Pruebas";
            return View();
        }
    }
}