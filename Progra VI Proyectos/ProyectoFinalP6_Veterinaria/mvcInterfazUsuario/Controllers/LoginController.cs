using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult errorUsuario()
        {
            return View();
        }
        public ActionResult errorPass()
        {
            return View();
        }

        public ActionResult validaAccesoUsuario(Models.modeloLogin pLogin)
        {
            //VARIABLE 
            string lRuta = string.Empty;
            if (pLogin.usuario == "usrprueba")
            {
                if (pLogin.contrasena == "123456")
                {
                    lRuta = "../Home/Index";
                }
                else
                {
                    lRuta = "../Login/errorPass";
                }
            }
            else
            {
                lRuta = "../Login/errorUsuario";
            }
            return RedirectToAction(lRuta);
        }

        public ActionResult retornarLogin()
        {
            return RedirectToAction("../Login/Index");
        }
    }
}