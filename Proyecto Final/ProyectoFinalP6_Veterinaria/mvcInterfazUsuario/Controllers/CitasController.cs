using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class CitasController : Controller
    {
        //********ENTIDADES********//
        public ActionResult listarCitas_ENT()
        {
            //VARIABLE
            List<Citas> lobjRespuesta = new List<Citas>();
            try
            {
                using (srvCitas.IsrvCitasClient srvWCF_CI = new srvCitas.IsrvCitasClient())
                {
                    lobjRespuesta = srvWCF_CI.recCitas_ENT();
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult AgregarCitas_ENT()
        { 
            return View();
        }

        public ActionResult ModificarCitas_ENT(int pId)
        {
            //VARIABLE
            Citas lobjRespuesta = new Citas();
            try
            {
                using (srvCitas.IsrvCitasClient srvWCF_CI = new srvCitas.IsrvCitasClient())
                {
                    lobjRespuesta = srvWCF_CI.recCitasXId_ENT(pId);
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult EliminarCitas_ENT(int pId)
        {
            //VARIABLE
            Citas lobjRespuesta = new Citas();
            try
            {
                using (srvCitas.IsrvCitasClient srvWCF_CI = new srvCitas.IsrvCitasClient())
                {
                    lobjRespuesta = srvWCF_CI.recCitasXId_ENT(pId);
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult DetalleCitas_ENT(int pId)
        {
            //VARIABLE
            Citas lobjRespuesta = new Citas();
            try
            {
                using (srvCitas.IsrvCitasClient srvWCF_CI = new srvCitas.IsrvCitasClient())
                {
                    lobjRespuesta = srvWCF_CI.recCitasXId_ENT(pId);
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }
    }
}