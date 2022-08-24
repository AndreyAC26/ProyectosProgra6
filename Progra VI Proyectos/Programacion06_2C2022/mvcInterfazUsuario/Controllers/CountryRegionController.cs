using Entidades;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class CountryRegionController : Controller
    {
        //******Entidades******//
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

        public ActionResult insertarCountryRegions_ENT()
        {
            return View();
        }

        public ActionResult modificarCountryRegions_ENT(string pId)
        {
            CountryRegion lobjRespuesta = new CountryRegion();

            try
            {
                using (srvCountryRegion.IsrvCountryRegionClient srvWCF_CR = new srvCountryRegion.IsrvCountryRegionClient())

                    lobjRespuesta = srvWCF_CR.recCountryRegionXId_ENT(pId);
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

                    lobjRespuesta = srvWCF_CR.recCountryRegionXId_ENT(pId);
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

                    lobjRespuesta = srvWCF_CR.recCountryRegionXId_ENT(pId);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }

            return View(lobjRespuesta);
        }

        /**********Acciones Entidades************/

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
                        break;
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
        }

        public ActionResult insertarCR_ENT( CountryRegion pCountryRegion)
        {
            List<CountryRegion> lobjRespuesta = new List<CountryRegion>();
            try
            {
                using (srvCountryRegion.IsrvCountryRegionClient srvWCF_CR = new srvCountryRegion.IsrvCountryRegionClient()) 
                { 

                    if( srvWCF_CR.insCountryRegion_ENT(pCountryRegion))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.insCountryRegion_ENT(pCountryRegion);
                }

            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View("listarCountryRegion_ENT", lobjRespuesta);
        }


    }


}