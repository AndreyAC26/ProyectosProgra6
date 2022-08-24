using Entidades;
using mvcInterfazUsuario.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class CountryRegionController : Controller
    {
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //*********ENTIDADES*********//
        public ActionResult listarCountryRegions_ENT()
        {
            List<CountryRegion> lobjRespuesta = new List<CountryRegion>();
            List<modeloCountryRegion> lobjRespuestaModelo = new List<modeloCountryRegion>();
            try
            {
                using (srvCountryRegion.IsrvCountryRegionClient srvWCF_CR = new srvCountryRegion.IsrvCountryRegionClient())
                {
                    lobjRespuesta = srvWCF_CR.recCountryRegion_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCountryRegion objModeloCountryRegion;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloCountryRegion = new modeloCountryRegion();
                            objModeloCountryRegion.CountryRegionCode = lcr.CountryRegionCode;
                            objModeloCountryRegion.Name = lcr.Name;
                            objModeloCountryRegion.ModifiedDate = lcr.ModifiedDate;
                            lobjRespuestaModelo.Add(objModeloCountryRegion);
                        }
                    }                    
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View(lobjRespuestaModelo);
        }

        public ActionResult agregarCountryRegions_ENT()
        {
            return View();
        }

        public ActionResult modificarCountryRegions_ENT(string pId)
        {
            CountryRegion lobjRespuesta = new CountryRegion();
            modeloCountryRegion lobjModeloCountryRegion;
            try
            {
                using (srvCountryRegion.IsrvCountryRegionClient srvWCF_CR = new srvCountryRegion.IsrvCountryRegionClient())
                {
                    lobjRespuesta = srvWCF_CR.recCountryRegionXId_ENT(pId);
                    lobjModeloCountryRegion = new modeloCountryRegion();
                    lobjModeloCountryRegion.CountryRegionCode = lobjRespuesta.CountryRegionCode;
                    lobjModeloCountryRegion.Name = lobjRespuesta.Name;
                    lobjModeloCountryRegion.ModifiedDate = lobjRespuesta.ModifiedDate;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloCountryRegion);
        }

        public ActionResult eliminarCountryRegions_ENT(string pId)
        {
            CountryRegion lobjRespuesta = new CountryRegion();
            modeloCountryRegion lobjModeloCountryRegion;
            try
            {
                using (srvCountryRegion.IsrvCountryRegionClient srvWCF_CR = new srvCountryRegion.IsrvCountryRegionClient())
                {
                    lobjRespuesta = srvWCF_CR.recCountryRegionXId_ENT(pId);
                    lobjModeloCountryRegion = new modeloCountryRegion();
                    lobjModeloCountryRegion.CountryRegionCode = lobjRespuesta.CountryRegionCode;
                    lobjModeloCountryRegion.Name = lobjRespuesta.Name;
                    lobjModeloCountryRegion.ModifiedDate = lobjRespuesta.ModifiedDate;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloCountryRegion);
        }

        public ActionResult detalleCountryRegions_ENT(string pId)
        {
            CountryRegion lobjRespuesta = new CountryRegion();
            modeloCountryRegion lobjModeloCountryRegion;
            try
            {
                using (srvCountryRegion.IsrvCountryRegionClient srvWCF_CR = new srvCountryRegion.IsrvCountryRegionClient())
                {
                    lobjRespuesta = srvWCF_CR.recCountryRegionXId_ENT(pId);
                    lobjModeloCountryRegion = new modeloCountryRegion();
                    lobjModeloCountryRegion.CountryRegionCode = lobjRespuesta.CountryRegionCode;
                    lobjModeloCountryRegion.Name = lobjRespuesta.Name;
                    lobjModeloCountryRegion.ModifiedDate = lobjRespuesta.ModifiedDate;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloCountryRegion);
        }

        /*****Acciones entidades******/
        public ActionResult accionesEntidades(string enviarAccion, modeloCountryRegion pModeloCountryRegion)
        {
            CountryRegion pCountryRegion = new CountryRegion();
            pCountryRegion.CountryRegionCode = pModeloCountryRegion.CountryRegionCode;
            pCountryRegion.Name = pModeloCountryRegion.Name;
            pCountryRegion.ModifiedDate = pModeloCountryRegion.ModifiedDate;

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

        public ActionResult insertarCR_ENT(CountryRegion pCountryRegion)
        {            
            List<CountryRegion> lobjRespuesta = new List<CountryRegion>();
            List<modeloCountryRegion> lobjRespuestaModelo = new List<modeloCountryRegion>();
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
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCountryRegion objModeloCountryRegion;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloCountryRegion = new modeloCountryRegion();
                            objModeloCountryRegion.CountryRegionCode = lcr.CountryRegionCode;
                            objModeloCountryRegion.Name = lcr.Name;
                            objModeloCountryRegion.ModifiedDate = lcr.ModifiedDate;
                            lobjRespuestaModelo.Add(objModeloCountryRegion);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarCountryRegions_ENT", lobjRespuestaModelo);
        }

        public ActionResult modificarCR_ENT(CountryRegion pCountryRegion)
        {
            List<CountryRegion> lobjRespuesta = new List<CountryRegion>();
            List<modeloCountryRegion> lobjRespuestaModelo = new List<modeloCountryRegion>();
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
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCountryRegion objModeloCountryRegion;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloCountryRegion = new modeloCountryRegion();
                            objModeloCountryRegion.CountryRegionCode = lcr.CountryRegionCode;
                            objModeloCountryRegion.Name = lcr.Name;
                            objModeloCountryRegion.ModifiedDate = lcr.ModifiedDate;
                            lobjRespuestaModelo.Add(objModeloCountryRegion);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarCountryRegions_ENT", lobjRespuestaModelo);
        }

        public ActionResult eliminarCR_ENT(CountryRegion pCountryRegion)
        {
            List<CountryRegion> lobjRespuesta = new List<CountryRegion>();
            List<modeloCountryRegion> lobjRespuestaModelo = new List<modeloCountryRegion>();
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
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCountryRegion objModeloCountryRegion;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloCountryRegion = new modeloCountryRegion();
                            objModeloCountryRegion.CountryRegionCode = lcr.CountryRegionCode;
                            objModeloCountryRegion.Name = lcr.Name;
                            objModeloCountryRegion.ModifiedDate = lcr.ModifiedDate;
                            lobjRespuestaModelo.Add(objModeloCountryRegion);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarCountryRegions_ENT", lobjRespuestaModelo);
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
            modeloCountryRegion lobjRespuesta = new modeloCountryRegion();
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
            modeloCountryRegion lobjRespuesta = new modeloCountryRegion();
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
            modeloCountryRegion lobjRespuesta = new modeloCountryRegion();
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
        public ActionResult accionesPA(string enviarAccion, modeloCountryRegion pModeloCountryRegion)
        {
            try
            {
                CountryRegion pCountryRegion = new CountryRegion();
                pCountryRegion.CountryRegionCode = pModeloCountryRegion.CountryRegionCode;
                pCountryRegion.Name = pModeloCountryRegion.Name;
                pCountryRegion.ModifiedDate = pModeloCountryRegion.ModifiedDate;

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