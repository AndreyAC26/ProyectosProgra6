using Entidades;
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
            Session["blnClientes"] = false;
            Session["blnCitas"] = false;
            Session["blnMascotas"] = false;
            // Session["blnServicios"] = false; FALTA AGREGAR

            Session["Logueado"] = false;
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
            TUSR_USUARIOS lobjRespuesta = new TUSR_USUARIOS();

            using (srvSeguridad.IsrvSeguridadClient srvSeg = new srvSeguridad.IsrvSeguridadClient())
            {
                lobjRespuesta = srvSeg.recUsuario(pLogin.usuario);
            }

            if (lobjRespuesta != null)
            {
                if (lobjRespuesta.TC_Usuario == pLogin.usuario)
                {
                    if (lobjRespuesta.TC_Contrasena == pLogin.contrasena)
                    {
                        lRuta = "../Home/Index";
                        //VARIABLES DE SESIONES
                        Session["blnClientes"] = true;
                        Session["blnCitas"] = true;
                        Session["blnMascotas"] = true;
                        // Session["blnServicios"] = true; FALTA AGREGAR

                        Session["Logueado"] = true;
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