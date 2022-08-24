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
    public class FacturacionController : Controller
    {
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //*********ENTIDADES*********//
        public ActionResult listarFacturacion_ENT()
        {
            List<Facturacion> lobjRespuesta = new List<Facturacion>();
            List<ModeloFacturacion> lobjRespuestaModelo = new List<ModeloFacturacion>();
            try
            {
                using (srvFacturacion.IsrvFacturacionClient srvWCF_CR = new srvFacturacion.IsrvFacturacionClient())
                {
                    lobjRespuesta = srvWCF_CR.recFacturacion_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        ModeloFacturacion objModeloFacturacion;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloFacturacion = new ModeloFacturacion();
                            objModeloFacturacion.NumeroFactura = lcr.NumeroFactura;
                            objModeloFacturacion.Descripcion = lcr.Descripcion;
                            objModeloFacturacion.NumeroCita = lcr.NumeroCita;
                            objModeloFacturacion.NombreCliente = lcr.NombreCliente;
                            objModeloFacturacion.NombreMascota = lcr.NombreMascota;
                            objModeloFacturacion.FechaCita = lcr.FechaCita;
                            objModeloFacturacion.IdServicio = lcr.IdServicio;
                            lobjRespuestaModelo.Add(objModeloFacturacion);
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

        public ActionResult agregarFacturacion_ENT()
        {
            return View();
        }

        public ActionResult modificarFacturacion_ENT(int pId)
        {
            Facturacion lobjRespuesta = new Facturacion();
            ModeloFacturacion lobjModeloFacturacion;
            try
            {
                using (srvFacturacion.IsrvFacturacionClient srvWCF_CR = new srvFacturacion.IsrvFacturacionClient())
                {
                    lobjRespuesta = srvWCF_CR.recFacturacionXId_ENT(pId);
                    lobjModeloFacturacion = new ModeloFacturacion();
                    lobjModeloFacturacion.NumeroFactura = lobjRespuesta.NumeroFactura;
                    lobjModeloFacturacion.Descripcion = lobjRespuesta.Descripcion;
                    lobjModeloFacturacion.NumeroCita = lobjRespuesta.NumeroCita;
                    lobjModeloFacturacion.NombreCliente = lobjRespuesta.NombreCliente;
                    lobjModeloFacturacion.NombreMascota = lobjRespuesta.NombreMascota;
                    lobjModeloFacturacion.FechaCita = lobjRespuesta.FechaCita;
                    lobjModeloFacturacion.IdServicio = lobjRespuesta.IdServicio;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloFacturacion);
        }

        public ActionResult eliminarFacturacion_ENT(int pId)
        {
            Facturacion lobjRespuesta = new Facturacion();
            ModeloFacturacion lobjModeloFacturacion;
            try
            {
                using (srvFacturacion.IsrvFacturacionClient srvWCF_CR = new srvFacturacion.IsrvFacturacionClient())
                {
                    lobjRespuesta = srvWCF_CR.recFacturacionXId_ENT(pId);
                    lobjModeloFacturacion = new ModeloFacturacion();
                    lobjModeloFacturacion.NumeroFactura = lobjRespuesta.NumeroFactura;
                    lobjModeloFacturacion.Descripcion = lobjRespuesta.Descripcion;
                    lobjModeloFacturacion.NumeroCita = lobjRespuesta.NumeroCita;
                    lobjModeloFacturacion.NombreCliente = lobjRespuesta.NombreCliente;
                    lobjModeloFacturacion.NombreMascota = lobjRespuesta.NombreMascota;
                    lobjModeloFacturacion.FechaCita = lobjRespuesta.FechaCita;
                    lobjModeloFacturacion.IdServicio = lobjRespuesta.IdServicio;

                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloFacturacion);
        }

        public ActionResult detalleFacturacion_ENT(int pId)
        {
            Facturacion lobjRespuesta = new Facturacion();
            ModeloFacturacion lobjModeloFacturacion;
            try
            {
                using (srvFacturacion.IsrvFacturacionClient srvWCF_CR = new srvFacturacion.IsrvFacturacionClient())
                {
                    lobjRespuesta = srvWCF_CR.recFacturacionXId_ENT(pId);
                    lobjModeloFacturacion = new ModeloFacturacion();
                    lobjModeloFacturacion.NumeroFactura = lobjRespuesta.NumeroFactura;
                    lobjModeloFacturacion.Descripcion = lobjRespuesta.Descripcion;
                    lobjModeloFacturacion.NumeroCita = lobjRespuesta.NumeroCita;
                    lobjModeloFacturacion.NombreCliente = lobjRespuesta.NombreCliente;
                    lobjModeloFacturacion.NombreMascota = lobjRespuesta.NombreMascota;
                    lobjModeloFacturacion.FechaCita = lobjRespuesta.FechaCita;
                    lobjModeloFacturacion.IdServicio = lobjRespuesta.IdServicio;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloFacturacion);
        }

        /*****Acciones entidades******/
        public ActionResult accionesEntidades(string enviarAccion, ModeloFacturacion pModeloFacturacion)
        {
            Facturacion pFacturacion = new Facturacion();
            pFacturacion.NumeroFactura = pModeloFacturacion.NumeroFactura;
            pFacturacion.Descripcion = pModeloFacturacion.Descripcion;
            pFacturacion.NumeroCita = pModeloFacturacion.NumeroCita;
            pFacturacion.NombreCliente = pModeloFacturacion.NombreCliente;
            pFacturacion.NombreMascota = pModeloFacturacion.NombreMascota;
            pFacturacion.FechaCita = pModeloFacturacion.FechaCita;
            pFacturacion.IdServicio = pModeloFacturacion.IdServicio;


            switch (enviarAccion)
            {
                case "Agregar":
                    return insertarCR_ENT(pFacturacion);
                case "Modificar":
                    return modificarCR_ENT(pFacturacion);
                case "Eliminar":
                    return eliminarCR_ENT(pFacturacion);
                default:
                    return RedirectToAction("listarFacturacion_ENT");
            }
        }

        public ActionResult insertarCR_ENT(Facturacion pFacturacion)
        {
            List<Facturacion> lobjRespuesta = new List<Facturacion>();
            List<ModeloFacturacion> lobjRespuestaModelo = new List<ModeloFacturacion>();
            try
            {
                using (srvFacturacion.IsrvFacturacionClient srvWCF_CR = new srvFacturacion.IsrvFacturacionClient())
                {
                    if (srvWCF_CR.insFacturacion_ENT(pFacturacion))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recFacturacion_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        ModeloFacturacion objModeloFacturacion;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloFacturacion = new ModeloFacturacion();
                            objModeloFacturacion.NumeroFactura = lcr.NumeroFactura;
                            objModeloFacturacion.Descripcion = lcr.Descripcion;
                            objModeloFacturacion.NumeroCita = lcr.NumeroCita;
                            objModeloFacturacion.NombreCliente = lcr.NombreCliente;
                            objModeloFacturacion.NombreMascota = lcr.NombreMascota;
                            objModeloFacturacion.FechaCita = lcr.FechaCita;
                            objModeloFacturacion.IdServicio = lcr.IdServicio;
                            lobjRespuestaModelo.Add(objModeloFacturacion);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarFacturacion_ENT", lobjRespuestaModelo);
        }

        public ActionResult modificarCR_ENT(Facturacion pFacturacion)
        {
            List<Facturacion> lobjRespuesta = new List<Facturacion>();
            List<ModeloFacturacion> lobjRespuestaModelo = new List<ModeloFacturacion>();
            try
            {
                using (srvFacturacion.IsrvFacturacionClient srvWCF_CR = new srvFacturacion.IsrvFacturacionClient())
                {
                    if (srvWCF_CR.modFacturacion_ENT(pFacturacion))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recFacturacion_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        ModeloFacturacion objModeloFacturacion;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloFacturacion = new ModeloFacturacion();
                            objModeloFacturacion.NumeroFactura = lcr.NumeroFactura;
                            objModeloFacturacion.Descripcion = lcr.Descripcion;
                            objModeloFacturacion.NumeroCita = lcr.NumeroCita;
                            objModeloFacturacion.NombreCliente = lcr.NombreCliente;
                            objModeloFacturacion.NombreMascota = lcr.NombreMascota;
                            objModeloFacturacion.FechaCita = lcr.FechaCita;
                            objModeloFacturacion.IdServicio = lcr.IdServicio;
                            lobjRespuestaModelo.Add(objModeloFacturacion);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarFacturacion_ENT", lobjRespuestaModelo);
        }

        public ActionResult eliminarCR_ENT(Facturacion pFacturacion)
        {
            List<Facturacion> lobjRespuesta = new List<Facturacion>();
            List<ModeloFacturacion> lobjRespuestaModelo = new List<ModeloFacturacion>();
            try
            {
                using (srvFacturacion.IsrvFacturacionClient srvWCF_CR = new srvFacturacion.IsrvFacturacionClient())
                {
                    if (srvWCF_CR.delFacturacion_ENT(pFacturacion))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recFacturacion_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        ModeloFacturacion objModeloFacturacion;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloFacturacion = new ModeloFacturacion();
                            objModeloFacturacion.NumeroFactura = lcr.NumeroFactura;
                            objModeloFacturacion.Descripcion = lcr.Descripcion;
                            objModeloFacturacion.NumeroCita = lcr.NumeroCita;
                            objModeloFacturacion.NombreCliente = lcr.NombreCliente;
                            objModeloFacturacion.NombreMascota = lcr.NombreMascota;
                            objModeloFacturacion.FechaCita = lcr.FechaCita;
                            objModeloFacturacion.IdServicio = lcr.IdServicio;
                            lobjRespuestaModelo.Add(objModeloFacturacion);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarFacturacion_ENT", lobjRespuestaModelo);
        }
    }
}