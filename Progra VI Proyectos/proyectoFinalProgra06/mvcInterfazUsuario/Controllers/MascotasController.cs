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
    public class MascotasController : Controller
    {
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //*********ENTIDADES*********//
        public ActionResult listarMascotas_ENT()
        {
            List<Mascotas> lobjRespuesta = new List<Mascotas>();
            List<ModeloMascotas> lobjRespuestaModelo = new List<ModeloMascotas>();
            try
            {
                using (srvMascotas.IsrvMascotasClient srvWCF_CR = new srvMascotas.IsrvMascotasClient())
                {
                    lobjRespuesta = srvWCF_CR.recMascotas_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        ModeloMascotas objModeloMascotas;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloMascotas = new ModeloMascotas();
                            objModeloMascotas.IDMascota = lcr.IDMascota;
                            objModeloMascotas.Nombre = lcr.Nombre;
                            objModeloMascotas.IdCliente = lcr.IdCliente;
                           lobjRespuestaModelo.Add(objModeloMascotas);
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

        public ActionResult agregarMascotas_ENT()
        {
            return View();
        }

        public ActionResult modificarMascotas_ENT(int pId)
        {
            Mascotas lobjRespuesta = new Mascotas();
            ModeloMascotas lobjModeloMascotas;
            try
            {
                using (srvMascotas.IsrvMascotasClient srvWCF_CR = new srvMascotas.IsrvMascotasClient())
                {
                    lobjRespuesta = srvWCF_CR.recMascotasXId_ENT(pId);
                    lobjModeloMascotas = new ModeloMascotas();
                    lobjModeloMascotas.IDMascota = lobjRespuesta.IDMascota;
                    lobjModeloMascotas.Nombre = lobjRespuesta.Nombre;
                    lobjModeloMascotas.IdCliente = lobjRespuesta.IdCliente;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloMascotas);
        }

        public ActionResult eliminarMascotas_ENT(int pId)
        {
            Mascotas lobjRespuesta = new Mascotas();
            ModeloMascotas lobjModeloMascotas;
            try
            {
                using (srvMascotas.IsrvMascotasClient srvWCF_CR = new srvMascotas.IsrvMascotasClient())
                {
                    lobjRespuesta = srvWCF_CR.recMascotasXId_ENT(pId);
                    lobjModeloMascotas = new ModeloMascotas();
                    lobjModeloMascotas.IDMascota = lobjRespuesta.IDMascota;
                    lobjModeloMascotas.Nombre = lobjRespuesta.Nombre;
                    lobjModeloMascotas.IdCliente = lobjRespuesta.IdCliente; 
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloMascotas);
        }

        public ActionResult detalleMascotas_ENT(int pId)
        {
            Mascotas lobjRespuesta = new Mascotas();
            ModeloMascotas lobjModeloMascotas;
            try
            {
                using (srvMascotas.IsrvMascotasClient srvWCF_CR = new srvMascotas.IsrvMascotasClient())
                {
                    lobjRespuesta = srvWCF_CR.recMascotasXId_ENT(pId);
                    lobjModeloMascotas = new ModeloMascotas();
                    lobjModeloMascotas.IDMascota = lobjRespuesta.IDMascota;
                    lobjModeloMascotas.Nombre = lobjRespuesta.Nombre;
                    lobjModeloMascotas.IdCliente = lobjRespuesta.IdCliente;

                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloMascotas);
        }

        /*****Acciones entidades******/
        public ActionResult accionesEntidades(string enviarAccion, ModeloMascotas pModeloMascotas)
        {
            Mascotas pMascotas = new Mascotas();
            pMascotas.IDMascota = pModeloMascotas.IDMascota;
            pMascotas.Nombre = pModeloMascotas.Nombre;
            pMascotas.IdCliente = pModeloMascotas.IdCliente;



            switch (enviarAccion)
            {
                case "Agregar":
                    return insertarCR_ENT(pMascotas);
                case "Modificar":
                    return modificarCR_ENT(pMascotas);
                case "Eliminar":
                    return eliminarCR_ENT(pMascotas);
                default:
                    return RedirectToAction("listarMascotas_ENT");
            }
        }

        public ActionResult insertarCR_ENT(Mascotas pMascotas)
        {
            List<Mascotas> lobjRespuesta = new List<Mascotas>();
            List<ModeloMascotas> lobjRespuestaModelo = new List<ModeloMascotas>();
            try
            {
                using (srvMascotas.IsrvMascotasClient srvWCF_CR = new srvMascotas.IsrvMascotasClient())
                {
                    if (srvWCF_CR.insMascotas_ENT(pMascotas))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recMascotas_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        ModeloMascotas objModeloMascotas;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloMascotas = new ModeloMascotas();
                            objModeloMascotas.IDMascota = lcr.IDMascota;
                            objModeloMascotas.Nombre = lcr.Nombre;
                            objModeloMascotas.IdCliente = lcr.IdCliente;
                            lobjRespuestaModelo.Add(objModeloMascotas);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarMascotas_ENT", lobjRespuestaModelo);
        }

        public ActionResult modificarCR_ENT(Mascotas pMascotas)
        {
            List<Mascotas> lobjRespuesta = new List<Mascotas>();
            List<ModeloMascotas> lobjRespuestaModelo = new List<ModeloMascotas>();
            try
            {
                using (srvMascotas.IsrvMascotasClient srvWCF_CR = new srvMascotas.IsrvMascotasClient())
                {
                    if (srvWCF_CR.modMascotas_ENT(pMascotas))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recMascotas_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        ModeloMascotas objModeloMascotas;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloMascotas = new ModeloMascotas();
                            objModeloMascotas.IDMascota = lcr.IDMascota;
                            objModeloMascotas.Nombre = lcr.Nombre;
                            objModeloMascotas.IdCliente = lcr.IdCliente;
                            lobjRespuestaModelo.Add(objModeloMascotas);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarMascotas_ENT", lobjRespuestaModelo);
        }

        public ActionResult eliminarCR_ENT(Mascotas pMascotas)
        {
            List<Mascotas> lobjRespuesta = new List<Mascotas>();
            List<ModeloMascotas> lobjRespuestaModelo = new List<ModeloMascotas>();
            try
            {
                using (srvMascotas.IsrvMascotasClient srvWCF_CR = new srvMascotas.IsrvMascotasClient())
                {
                    if (srvWCF_CR.delMascotas_ENT(pMascotas))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recMascotas_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        ModeloMascotas objModeloMascotas;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloMascotas = new ModeloMascotas();
                            objModeloMascotas.IDMascota = lcr.IDMascota;
                            objModeloMascotas.Nombre = lcr.Nombre;
                            objModeloMascotas.IdCliente = lcr.IdCliente;
                            lobjRespuestaModelo.Add(objModeloMascotas);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarMascotas_ENT", lobjRespuestaModelo);
        }
    }
}