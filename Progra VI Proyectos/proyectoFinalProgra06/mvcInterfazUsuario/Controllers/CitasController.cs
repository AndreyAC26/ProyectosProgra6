using Entidades;
using mvcInterfazUsuario.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class CitasController : Controller
    {
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //*********ENTIDADES*********//
        public ActionResult listarCitas_ENT()
        {
            List<Citas> lobjRespuesta = new List<Citas>();
            List<modeloCitas> lobjRespuestaModelo = new List<modeloCitas>();
            try
            {
                using (srvCitas.IsrvCitasClient srvWCF_CR = new srvCitas.IsrvCitasClient())
                {
                    lobjRespuesta = srvWCF_CR.recCitas_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCitas objModeloCitas;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloCitas = new modeloCitas();
                            objModeloCitas.NumeroCita = lcr.NumeroCita;
                            objModeloCitas.IDCliente = lcr.IDCliente;
                            objModeloCitas.IDMascota = lcr.IDMascota;
                            objModeloCitas.FechaCita = lcr.FechaCita;
                            lobjRespuestaModelo.Add(objModeloCitas);
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

        public ActionResult agregarCitas_ENT()
        {
            return View();
        }

        public ActionResult modificarCitas_ENT(int pId)
        {
            Citas lobjRespuesta = new Citas();
            modeloCitas lobjModeloCitas;
            try
            {
                using (srvCitas.IsrvCitasClient srvWCF_CR = new srvCitas.IsrvCitasClient())
                {
                    lobjRespuesta = srvWCF_CR.recCitasXId_ENT(pId);
                    lobjModeloCitas = new modeloCitas();
                    lobjModeloCitas.NumeroCita = lobjRespuesta.NumeroCita;
                    lobjModeloCitas.IDCliente = lobjRespuesta.IDCliente;
                    lobjModeloCitas.IDMascota = lobjRespuesta.IDMascota;
                    lobjModeloCitas.FechaCita = lobjRespuesta.FechaCita;
                    
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloCitas);
        }

        public ActionResult eliminarCitas_ENT(int pId)
        {
            Citas lobjRespuesta = new Citas();
            modeloCitas lobjModeloCitas;
            try
            {
                using (srvCitas.IsrvCitasClient srvWCF_CR = new srvCitas.IsrvCitasClient())
                {
                    lobjRespuesta = srvWCF_CR.recCitasXId_ENT(pId);
                    lobjModeloCitas = new modeloCitas();
                    lobjModeloCitas.NumeroCita = lobjRespuesta.NumeroCita;
                    lobjModeloCitas.IDCliente = lobjRespuesta.IDCliente;
                    lobjModeloCitas.IDMascota = lobjRespuesta.IDMascota;
                    lobjModeloCitas.FechaCita = lobjRespuesta.FechaCita;

                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloCitas);
        }

        public ActionResult detalleCitas_ENT(int pId)
        {
            Citas lobjRespuesta = new Citas();
            modeloCitas lobjModeloCitas;
            try
            {
                using (srvCitas.IsrvCitasClient srvWCF_CR = new srvCitas.IsrvCitasClient())
                {
                    lobjRespuesta = srvWCF_CR.recCitasXId_ENT(pId);
                    lobjModeloCitas = new modeloCitas();
                    lobjModeloCitas.NumeroCita = lobjRespuesta.NumeroCita;
                    lobjModeloCitas.IDCliente = lobjRespuesta.IDCliente;
                    lobjModeloCitas.IDMascota = lobjRespuesta.IDMascota;
                    lobjModeloCitas.FechaCita = lobjRespuesta.FechaCita;

                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloCitas);
        }

        /*****Acciones entidades******/
        public ActionResult accionesEntidades(string enviarAccion, modeloCitas pModeloCitas)
        {
            Citas pCitas = new Citas();
            pCitas.NumeroCita = pModeloCitas.NumeroCita;
            pCitas.IDCliente = pModeloCitas.IDCliente;
            pCitas.IDMascota = pModeloCitas.IDMascota;
            pCitas.FechaCita = pModeloCitas.FechaCita;



            switch (enviarAccion)
            {
                case "Agregar":
                    return insertarCR_ENT(pCitas);
                case "Modificar":
                    return modificarCR_ENT(pCitas);
                case "Eliminar":
                    return eliminarCR_ENT(pCitas);
                default:
                    return RedirectToAction("listarCitas_ENT");
            }
        }

        public ActionResult insertarCR_ENT(Citas pCitas)
        {
            List<Citas> lobjRespuesta = new List<Citas>();
            List<modeloCitas> lobjRespuestaModelo = new List<modeloCitas>();
            try
            {
                using (srvCitas.IsrvCitasClient srvWCF_CR = new srvCitas.IsrvCitasClient())
                {
                    if (srvWCF_CR.insCitas_ENT(pCitas))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recCitas_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCitas objModeloCitas;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloCitas = new modeloCitas();
                            objModeloCitas.NumeroCita = lcr.NumeroCita;
                            objModeloCitas.IDCliente = lcr.IDCliente;
                            objModeloCitas.IDMascota = lcr.IDMascota;
                            objModeloCitas.FechaCita = lcr.FechaCita;
                            lobjRespuestaModelo.Add(objModeloCitas);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarCitas_ENT", lobjRespuestaModelo);
        }

        public ActionResult modificarCR_ENT(Citas pCitas)
        {
            List<Citas> lobjRespuesta = new List<Citas>();
            List<modeloCitas> lobjRespuestaModelo = new List<modeloCitas>();
            try
            {
                using (srvCitas.IsrvCitasClient srvWCF_CR = new srvCitas.IsrvCitasClient())
                {
                    if (srvWCF_CR.modCitas_ENT(pCitas))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recCitas_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCitas objModeloCitas;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloCitas = new modeloCitas();
                            objModeloCitas.NumeroCita = lcr.NumeroCita;
                            objModeloCitas.IDCliente = lcr.IDCliente;
                            objModeloCitas.IDMascota = lcr.IDMascota;
                            objModeloCitas.FechaCita = lcr.FechaCita;
                            lobjRespuestaModelo.Add(objModeloCitas);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarCitas_ENT", lobjRespuestaModelo);
        }

        public ActionResult eliminarCR_ENT(Citas pCitas)
        {
            List<Citas> lobjRespuesta = new List<Citas>();
            List<modeloCitas> lobjRespuestaModelo = new List<modeloCitas>();
            try
            {
                using (srvCitas.IsrvCitasClient srvWCF_CR = new srvCitas.IsrvCitasClient())
                {
                    if (srvWCF_CR.delCitas_ENT(pCitas))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recCitas_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCitas objModeloCitas;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloCitas = new modeloCitas();
                            objModeloCitas.NumeroCita = lcr.NumeroCita;
                            objModeloCitas.IDCliente = lcr.IDCliente;
                            objModeloCitas.IDMascota = lcr.IDMascota;
                            objModeloCitas.FechaCita = lcr.FechaCita;
                            lobjRespuestaModelo.Add(objModeloCitas);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarCitas_ENT", lobjRespuestaModelo);
        }
    }
}