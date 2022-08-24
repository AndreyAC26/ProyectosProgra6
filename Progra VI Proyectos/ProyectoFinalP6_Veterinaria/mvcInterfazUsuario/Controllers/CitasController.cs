using Entidades;
using mvcInterfazUsuario.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class CitasController : Controller
    {
        //VARIABLE
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();//VARIABLE EXECCIONES
        //********ENTIDADES********//
        public ActionResult listarCitas_ENT()
        {
            //VARIABLE
            List<Citas> lobjRespuesta = new List<Citas>();
            List<modeloCitas> lobjRespuestaModelo = new List<modeloCitas>();
            try
            {
                using (srvCitas.IsrvCitasClient srvWCF_CI = new srvCitas.IsrvCitasClient())
                {
                    lobjRespuesta = srvWCF_CI.recCitas_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCitas objmodeloCitas;
                        foreach (var lci in lobjRespuesta)
                        {
                            objmodeloCitas = new modeloCitas();
                            objmodeloCitas.NumeroCita = lci.NumeroCita;
                            objmodeloCitas.IDCliente = lci.IDCliente;
                            objmodeloCitas.IDMascota = lci.IDMascota;
                            objmodeloCitas.FechaCita = lci.FechaCita;
                            lobjRespuestaModelo.Add(objmodeloCitas);

                        }
                    }
                    
                }
            }
            catch (Exception lEx)
            {

                // throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                     " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View(lobjRespuestaModelo);
        }

        public ActionResult AgregarCitas_ENT()
        { 
            return View();
        }

        public ActionResult ModificarCitas_ENT(int pId)
        {
            //VARIABLES
            Citas lobjRespuesta = new Citas();
            modeloCitas lobjmodeloCitas = new modeloCitas();
            try
            {
                using (srvCitas.IsrvCitasClient srvWCF_CI = new srvCitas.IsrvCitasClient())
                {
                    lobjRespuesta = srvWCF_CI.recCitasXId_ENT(pId);
                    lobjmodeloCitas = new modeloCitas();
                    lobjmodeloCitas.NumeroCita = lobjRespuesta.NumeroCita;
                    lobjmodeloCitas.IDCliente = lobjRespuesta.IDCliente;
                    lobjmodeloCitas.IDMascota = lobjRespuesta.IDMascota;
                    lobjmodeloCitas.FechaCita = lobjRespuesta.FechaCita;
                }
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View(lobjmodeloCitas);
        }

        public ActionResult EliminarCitas_ENT(int pId)
        {
            //VARIABLES
            Citas lobjRespuesta = new Citas();
            modeloCitas lobjmodeloCitas = new modeloCitas();
            try
            {
                using (srvCitas.IsrvCitasClient srvWCF_CI = new srvCitas.IsrvCitasClient())
                {
                    lobjRespuesta = srvWCF_CI.recCitasXId_ENT(pId);
                    //lobjmodeloCitas = new modeloCitas();
                    lobjmodeloCitas.NumeroCita = lobjRespuesta.NumeroCita;
                    lobjmodeloCitas.IDCliente = lobjRespuesta.IDCliente;
                    lobjmodeloCitas.IDMascota = lobjRespuesta.IDMascota;
                    lobjmodeloCitas.FechaCita = lobjRespuesta.FechaCita;
                }
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View(lobjmodeloCitas);
        }

        public ActionResult DetalleCitas_ENT(int pId)
        {
            //VARIABLES
            Citas lobjRespuesta = new Citas();
            modeloCitas lobjmodeloCitas = new modeloCitas();
            try
            {
                using (srvCitas.IsrvCitasClient srvWCF_CI = new srvCitas.IsrvCitasClient())
                {
                    lobjRespuesta = srvWCF_CI.recCitasXId_ENT(pId);
                    //lobjmodeloCitas = new modeloCitas();
                    lobjmodeloCitas.NumeroCita = lobjRespuesta.NumeroCita;
                    lobjmodeloCitas.IDCliente = lobjRespuesta.IDCliente;
                    lobjmodeloCitas.IDMascota = lobjRespuesta.IDMascota;
                    lobjmodeloCitas.FechaCita = lobjRespuesta.FechaCita;
                }
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View(lobjmodeloCitas);
        }

        //*****ACCIONES ENTIDADES*****//
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
                    return insertarCit_ENT(pCitas);
                case "Modificar":
                    return modificarCit_ENT(pCitas);
                case "Eliminar":
                    return eliminarCit_ENT(pCitas);
                default:
                    return RedirectToAction("listarCitas_ENT");

            }

        }

        public ActionResult insertarCit_ENT(Citas pCitas)
        { 
            //pCitas.FechaCita = DateTime.Now; Fecha automatica del dia 
            List<Citas> lobjRespuesta = new List<Citas>();
            List<modeloCitas> lobjRespuestaModelo = new List<modeloCitas>();
            try
            {
                using (srvCitas.IsrvCitasClient srvWCF_CI = new srvCitas.IsrvCitasClient())
                {
                    if (srvWCF_CI.insCitas_ENT(pCitas))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    { 
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CI.recCitas_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCitas objmodeloCitas;
                        foreach (var lci in lobjRespuesta)
                        {
                            objmodeloCitas = new modeloCitas();
                            objmodeloCitas.NumeroCita = lci.NumeroCita;
                            objmodeloCitas.IDCliente = lci.IDCliente;
                            objmodeloCitas.IDMascota = lci.IDMascota;
                            objmodeloCitas.FechaCita = lci.FechaCita;
                            lobjRespuestaModelo.Add(objmodeloCitas);

                        }
                    }
                }
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                     " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarCitas_ENT", lobjRespuestaModelo);
        }

        public ActionResult modificarCit_ENT(Citas pCitas)
        {
            List<Citas> lobjRespuesta = new List<Citas>();
            List<modeloCitas> lobjRespuestaModelo = new List<modeloCitas>();
            try
            {
                using (srvCitas.IsrvCitasClient srvWCF_CI = new srvCitas.IsrvCitasClient())
                {
                    if (srvWCF_CI.modCitas_ENT(pCitas))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CI.recCitas_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCitas objmodeloCitas;
                        foreach (var lci in lobjRespuesta)
                        {
                            objmodeloCitas = new modeloCitas();
                            objmodeloCitas.NumeroCita = lci.NumeroCita;
                            objmodeloCitas.IDCliente = lci.IDCliente;
                            objmodeloCitas.IDMascota = lci.IDMascota;
                            objmodeloCitas.FechaCita = lci.FechaCita;
                            lobjRespuestaModelo.Add(objmodeloCitas);

                        }
                    }
                }
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                     " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarCitas_ENT", lobjRespuestaModelo);
        }

        public ActionResult eliminarCit_ENT(Citas pCitas)
        {
            List<Citas> lobjRespuesta = new List<Citas>();
            List<modeloCitas> lobjRespuestaModelo = new List<modeloCitas>();
            try
            {
                using (srvCitas.IsrvCitasClient srvWCF_CI = new srvCitas.IsrvCitasClient())
                {
                    if (srvWCF_CI.delCitas_ENT(pCitas))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CI.recCitas_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCitas objmodeloCitas;
                        foreach (var lci in lobjRespuesta)
                        {
                            objmodeloCitas = new modeloCitas();
                            objmodeloCitas.NumeroCita = lci.NumeroCita;
                            objmodeloCitas.IDCliente = lci.IDCliente;
                            objmodeloCitas.IDMascota = lci.IDMascota;
                            objmodeloCitas.FechaCita = lci.FechaCita;
                            lobjRespuestaModelo.Add(objmodeloCitas);

                        }
                    }
                }
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                     " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarCitas_ENT", lobjRespuestaModelo);
        }


    }
}