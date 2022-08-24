using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult cerrarSesion()
        {
            Session["blnClientes"] = false;
            Session["blnCitas"] = false;
            Session["blnMascotas"] = false;
            // Session["blnServicios"] = false; FALTA AGREGAR
            Session["Logueado"] = false;
            return RedirectToAction("../Login/Index");
        }
    }
}