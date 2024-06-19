using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaMatricula.Models;
using System.Web.Mvc;

namespace SistemaMatricula.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public JsonResult Solicitud()
        {
            List<dias> dias = new List<dias>{
                new dias{id=1, dia="lunes"},
                new dias{id=2, dia="martes"},
                new dias{id=3, dia="miercoles"},
                new dias{id=4, dia="jueves"},
                new dias{id=5, dia="viernes"}
             };
            return Json(dias, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}