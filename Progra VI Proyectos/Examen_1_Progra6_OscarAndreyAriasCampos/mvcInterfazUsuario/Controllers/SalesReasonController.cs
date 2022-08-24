using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class SalesReasonController : Controller
    {
        //  SalesReason
        public ActionResult listarSalesReason_ENT()
        {
            List<SalesReason> lobjRespuesta = new List<SalesReason>();
            try
            {
                using (srvSalesReason.IsrvSalesReasonClient srvWCF_CR = new srvSalesReason.IsrvSalesReasonClient())
                {
                    lobjRespuesta = srvWCF_CR.recSalesReason_ENT();
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult agregarSalesReason_ENT()
        {
            return View();
        }

        public ActionResult modificaSalesReason_ENT(int pId)
        {
            SalesReason lobjRespuesta = new SalesReason();
            try
            {
                using (srvSalesReason.IsrvSalesReasonClient srvWCF_CR = new srvSalesReason.IsrvSalesReasonClient())
                {
                    lobjRespuesta = srvWCF_CR.recSalesReasonXId_ENT(pId);
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult eliminarSalesReason_ENT(int pId)
        {
            SalesReason lobjRespuesta = new SalesReason();
            try
            {
                using (srvSalesReason.IsrvSalesReasonClient srvWCF_CR = new srvSalesReason.IsrvSalesReasonClient())
                {
                    lobjRespuesta = srvWCF_CR.recSalesReasonXId_ENT(pId);
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult detalleSalesReason_ENT(int pId)
        {
            SalesReason lobjRespuesta = new SalesReason();
            try
            {
                using (srvSalesReason.IsrvSalesReasonClient srvWCF_CR = new srvSalesReason.IsrvSalesReasonClient())
                {
                    lobjRespuesta = srvWCF_CR.recSalesReasonXId_ENT(pId);
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        /*****Acciones entidades******/
        public ActionResult accionesEntidades(string enviarAccion, SalesReason pSalesReason)
        {
            try
            {
                switch (enviarAccion)
                {
                    case "Agregar":
                        return insertarCR_ENT(pSalesReason);
                    case "Modificar":
                        return modificarCR_ENT(pSalesReason);
                    case "Eliminar":
                        return eliminarCR_ENT(pSalesReason);
                    default:
                        return RedirectToAction("listarSalesReason_ENT");
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
        }

        public ActionResult insertarCR_ENT(SalesReason pSalesReason)
        {
            List<SalesReason> lobjRespuesta = new List<SalesReason>();
            try
            {
                using (srvSalesReason.IsrvSalesReasonClient srvWCF_CR = new srvSalesReason.IsrvSalesReasonClient())
                {
                    if (srvWCF_CR.insSalesReason_ENT(pSalesReason))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recSalesReason_ENT();
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return View("listarSalesReason_ENT", lobjRespuesta);
        }

        public ActionResult modificarCR_ENT(SalesReason pSalesReason)
        {
            List<SalesReason> lobjRespuesta = new List<SalesReason>();
            try
            {
                using (srvSalesReason.IsrvSalesReasonClient srvWCF_CR = new srvSalesReason.IsrvSalesReasonClient())
                {
                    if (srvWCF_CR.modSalesReason_ENT(pSalesReason))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recSalesReason_ENT();
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return View("listarSalesReason_ENT", lobjRespuesta);
        }

        public ActionResult eliminarCR_ENT(SalesReason pSalesReason)
        {
            List<SalesReason> lobjRespuesta = new List<SalesReason>();
            try
            {
                using (srvSalesReason.IsrvSalesReasonClient srvWCF_CR = new srvSalesReason.IsrvSalesReasonClient())
                {
                    if (srvWCF_CR.delSalesReason_ENT(pSalesReason))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recSalesReason_ENT();
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return View("listarSalesReason_ENT", lobjRespuesta);
        }
    }
}