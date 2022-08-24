using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class CountryRegionController : Controller
    {        
        //*********ENTIDADES*********//
        public ActionResult listarCountryRegions_ENT()
        {
            List<CountryRegion> lobjRespuesta = new List<CountryRegion>();
            try
            {
                using (srvCountryRegion.IsrvCountryRegionClient srvWCF_CR = new srvCountryRegion.IsrvCountryRegionClient())
                {
                    lobjRespuesta = srvWCF_CR.recCountryRegion_ENT();
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult agregarCountryRegions_ENT()
        {
            return View();
        }

        public ActionResult modificarCountryRegions_ENT(string pId)
        {
            CountryRegion lobjRespuesta = new CountryRegion();
            try
            {
                using (srvCountryRegion.IsrvCountryRegionClient srvWCF_CR = new srvCountryRegion.IsrvCountryRegionClient())
                {
                    lobjRespuesta = srvWCF_CR.recCountryRegionXId_ENT(pId);
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult eliminarCountryRegions_ENT(string pId)
        {
            CountryRegion lobjRespuesta = new CountryRegion();
            try
            {
                using (srvCountryRegion.IsrvCountryRegionClient srvWCF_CR = new srvCountryRegion.IsrvCountryRegionClient())
                {
                    lobjRespuesta = srvWCF_CR.recCountryRegionXId_ENT(pId);
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult detalleCountryRegions_ENT(string pId)
        {
            CountryRegion lobjRespuesta = new CountryRegion();
            try
            {
                using (srvCountryRegion.IsrvCountryRegionClient srvWCF_CR = new srvCountryRegion.IsrvCountryRegionClient())
                {
                    lobjRespuesta = srvWCF_CR.recCountryRegionXId_ENT(pId);
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        /*****Acciones entidades******/
        public ActionResult accionesEntidades(string enviarAccion, CountryRegion pCountryRegion)
        {
            try
            {
                switch (enviarAccion)
                {
                    case "Agregar":
                        return insertarCR_ENT(pCountryRegion);
                    case "Modificar":
                        return modificarCR_ENT(pCountryRegion);
                    case "Eliminar":
                        return eliminarCR_ENT(pCountryRegion);
                    default:
                        return RedirectToAction("listarCountryRegions_ENT");
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
        }

        public ActionResult insertarCR_ENT(CountryRegion pCountryRegion)
        {
            List<CountryRegion> lobjRespuesta = new List<CountryRegion>();
            try
            {
                using (srvCountryRegion.IsrvCountryRegionClient srvWCF_CR = new srvCountryRegion.IsrvCountryRegionClient())
                {
                    if (srvWCF_CR.insCountryRegion_ENT(pCountryRegion))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recCountryRegion_ENT();
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return View("listarCountryRegions_ENT", lobjRespuesta);
        }

        public ActionResult modificarCR_ENT(CountryRegion pCountryRegion)
        {
            List<CountryRegion> lobjRespuesta = new List<CountryRegion>();
            try
            {
                using (srvCountryRegion.IsrvCountryRegionClient srvWCF_CR = new srvCountryRegion.IsrvCountryRegionClient())
                {
                    if (srvWCF_CR.modCountryRegion_ENT(pCountryRegion))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recCountryRegion_ENT();
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return View("listarCountryRegions_ENT", lobjRespuesta);
        }

        public ActionResult eliminarCR_ENT(CountryRegion pCountryRegion)
        {
            List<CountryRegion> lobjRespuesta = new List<CountryRegion>();
            try
            {
                using (srvCountryRegion.IsrvCountryRegionClient srvWCF_CR = new srvCountryRegion.IsrvCountryRegionClient())
                {
                    if (srvWCF_CR.delCountryRegion_ENT(pCountryRegion))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recCountryRegion_ENT();
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return View("listarCountryRegions_ENT", lobjRespuesta);
        }

        //*********Procedimientos almacenados*********//
        public ActionResult listarCountryRegions_PA()
        {
            List<recCountryRegions_Result> lobjRespuesta = new List<recCountryRegions_Result>();
            try
            {
                using (srvCountryRegion.IsrvCountryRegionClient srvWCF_CR = new srvCountryRegion.IsrvCountryRegionClient())
                {
                    lobjRespuesta = srvWCF_CR.recCountryRegion_PA();
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult agregarCountryRegions_PA()
        {
            return View();
        }

        public ActionResult modificarCountryRegions_PA(string pId)
        {
            recCountryRegionsxId_Result lobjRespuesta_PA = new recCountryRegionsxId_Result();
            CountryRegion lobjRespuesta = new CountryRegion();
            try
            {
                using (srvCountryRegion.IsrvCountryRegionClient srvWCF_CR = new srvCountryRegion.IsrvCountryRegionClient())
                {
                    lobjRespuesta_PA = srvWCF_CR.recCountryRegionXId_PA(pId);
                }
                if(lobjRespuesta_PA != null)
                {
                    lobjRespuesta.CountryRegionCode = lobjRespuesta_PA.CountryRegionCode;
                    lobjRespuesta.Name = lobjRespuesta_PA.Name;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult eliminarCountryRegions_PA(string pId)
        {
            recCountryRegionsxId_Result lobjRespuesta_PA = new recCountryRegionsxId_Result();
            CountryRegion lobjRespuesta = new CountryRegion();
            try
            {
                using (srvCountryRegion.IsrvCountryRegionClient srvWCF_CR = new srvCountryRegion.IsrvCountryRegionClient())
                {
                    lobjRespuesta_PA = srvWCF_CR.recCountryRegionXId_PA(pId);
                }
                if (lobjRespuesta_PA != null)
                {
                    lobjRespuesta.CountryRegionCode = lobjRespuesta_PA.CountryRegionCode;
                    lobjRespuesta.Name = lobjRespuesta_PA.Name;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult detalleCountryRegions_PA(string pId)
        {
            recCountryRegionsxId_Result lobjRespuesta_PA = new recCountryRegionsxId_Result();
            CountryRegion lobjRespuesta = new CountryRegion();
            try
            {
                using (srvCountryRegion.IsrvCountryRegionClient srvWCF_CR = new srvCountryRegion.IsrvCountryRegionClient())
                {
                    lobjRespuesta_PA = srvWCF_CR.recCountryRegionXId_PA(pId);
                }
                if (lobjRespuesta_PA != null)
                {
                    lobjRespuesta.CountryRegionCode = lobjRespuesta_PA.CountryRegionCode;
                    lobjRespuesta.Name = lobjRespuesta_PA.Name;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        /*****Acciones procedimientos almacenados******/
        public ActionResult accionesPA(string enviarAccion, CountryRegion pCountryRegion)
        {
            try
            {
                switch (enviarAccion)
                {
                    case "Agregar":
                        return insertarCR_PA(pCountryRegion);
                    case "Modificar":
                        return modificarCR_PA(pCountryRegion);
                    case "Eliminar":
                        return eliminarCR_PA(pCountryRegion);
                    default:
                        return RedirectToAction("listarCountryRegions_PA");
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
        }

        public ActionResult insertarCR_PA(CountryRegion pCountryRegion)
        {
            List<recCountryRegions_Result> lobjRespuesta = new List<recCountryRegions_Result>();
            try
            {
                using (srvCountryRegion.IsrvCountryRegionClient srvWCF_CR = new srvCountryRegion.IsrvCountryRegionClient())
                {
                    if (srvWCF_CR.insCountryRegion_PA(pCountryRegion))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recCountryRegion_PA();
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return View("listarCountryRegions_PA", lobjRespuesta);
        }

        public ActionResult modificarCR_PA(CountryRegion pCountryRegion)
        {
            List<recCountryRegions_Result> lobjRespuesta = new List<recCountryRegions_Result>();
            try
            {
                using (srvCountryRegion.IsrvCountryRegionClient srvWCF_CR = new srvCountryRegion.IsrvCountryRegionClient())
                {
                    if (srvWCF_CR.modCountryRegion_PA(pCountryRegion))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recCountryRegion_PA();
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return View("listarCountryRegions_PA", lobjRespuesta);
        }

        public ActionResult eliminarCR_PA(CountryRegion pCountryRegion)
        {
            List<recCountryRegions_Result> lobjRespuesta = new List<recCountryRegions_Result>();
            try
            {
                using (srvCountryRegion.IsrvCountryRegionClient srvWCF_CR = new srvCountryRegion.IsrvCountryRegionClient())
                {
                    if (srvWCF_CR.delCountryRegion_PA(pCountryRegion))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recCountryRegion_PA();
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return View("listarCountryRegions_PA", lobjRespuesta);
        }

    }
}