using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class MascotasController : Controller
    {
        //********ENTIDADES********//
        public ActionResult listarMascotas_ENT()
        {
            //VARIABLE
            List<Mascotas> lobjRespuesta = new List<Mascotas>();
            try
            {
                using (srvMascotas.IsrvMascotasClient srvWCF_MA = new srvMascotas.IsrvMascotasClient())
                {
                    lobjRespuesta = srvWCF_MA.recMascotas_ENT();
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult AgregarMascotas_ENT()
        { 
            return View();
        }

        public ActionResult ModificarMascotas_ENT(int pId)
        {
            //VARIABLE
            Mascotas lobjRespuesta = new Mascotas();
            try
            {
                using (srvMascotas.IsrvMascotasClient srvWCF_MA = new srvMascotas.IsrvMascotasClient())
                {
                    lobjRespuesta = srvWCF_MA.recMascotasXId_ENT(pId);
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult EliminarMascotas_ENT(int pId)
        {
            //VARIABLE
            Mascotas lobjRespuesta = new Mascotas();
            try
            {
                using (srvMascotas.IsrvMascotasClient srvWCF_MA = new srvMascotas.IsrvMascotasClient())
                {
                    lobjRespuesta = srvWCF_MA.recMascotasXId_ENT(pId);
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult DetalleMascotas_ENT(int pId)
        {
            //VARIABLE
            Mascotas lobjRespuesta = new Mascotas();
            try
            {
                using (srvMascotas.IsrvMascotasClient srvWCF_MA = new srvMascotas.IsrvMascotasClient())
                {
                    lobjRespuesta = srvWCF_MA.recMascotasXId_ENT(pId);
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