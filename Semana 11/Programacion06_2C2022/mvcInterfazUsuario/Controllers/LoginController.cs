using Entidades;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            Session["blnRegionesEnt"] = false;
            Session["blnRegionesPA"] = false;
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
            string lRuta = string.Empty;
            TUSR_USUARIOS lObjRespuesta = new TUSR_USUARIOS();

            using (srvSeguridad.IsrvSeguridadClient srvSEG = new srvSeguridad.IsrvSeguridadClient())
            {
                lObjRespuesta = srvSEG.recUsuario(pLogin.usuario);
            }
            if (lObjRespuesta != null)
            {
                if (lObjRespuesta.TC_Usuario == pLogin.usuario)
                {
                    if (lObjRespuesta.TC_Contrasena == pLogin.contrasena)
                    {
                        lRuta = "../Home/Index";
                        Session["blnRegionesEnt"] = false;
                        Session["blnRegionesPA"] = true;
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