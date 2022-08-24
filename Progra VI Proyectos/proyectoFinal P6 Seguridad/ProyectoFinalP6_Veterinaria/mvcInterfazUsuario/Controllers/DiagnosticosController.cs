using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class DiagnosticosController : Controller
    {
        //********ENTIDADES********//
        public ActionResult listarDiagnosticos_ENT()
        {

            //VARIABLE
            List<Diagnósticos> lobjRespuesta = new List<Diagnósticos>();
            try
            {
                using (srvDiagnosticos.IsrvDiagnosticosClient srvWCF_DI = new srvDiagnosticos.IsrvDiagnosticosClient())
                {
                    lobjRespuesta = srvWCF_DI.recDiagnosticos_ENT();
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult AgregarDiagnosticos_ENT()
        { 
            return View();
        }

        public ActionResult ModificarDiagnosticos_ENT(int pId)
        {
            //VARIABLE
            Diagnósticos lobjRespuesta = new Diagnósticos();
            try
            {
                using (srvDiagnosticos.IsrvDiagnosticosClient srvWCF_DI = new srvDiagnosticos.IsrvDiagnosticosClient())
                {
                    lobjRespuesta = srvWCF_DI.recDiagnosticosXId_ENT(pId);
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult EliminarDiagnosticos_ENT(int pId)
        {
            //VARIABLE
            Diagnósticos lobjRespuesta = new Diagnósticos();
            try
            {
                using (srvDiagnosticos.IsrvDiagnosticosClient srvWCF_DI = new srvDiagnosticos.IsrvDiagnosticosClient())
                {
                    lobjRespuesta = srvWCF_DI.recDiagnosticosXId_ENT(pId);
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult DetalleDiagnosticos_ENT(int pId)
        {
            //VARIABLE
            Diagnósticos lobjRespuesta = new Diagnósticos();
            try
            {
                using (srvDiagnosticos.IsrvDiagnosticosClient srvWCF_DI = new srvDiagnosticos.IsrvDiagnosticosClient())
                {
                    lobjRespuesta = srvWCF_DI.recDiagnosticosXId_ENT(pId);
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