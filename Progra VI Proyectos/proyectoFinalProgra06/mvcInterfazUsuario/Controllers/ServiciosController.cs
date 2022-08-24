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
    public class ServiciosController : Controller
    {
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //*********ENTIDADES*********//
        public ActionResult listarServicios_ENT()
        {
            List<Servicios> lobjRespuesta = new List<Servicios>();
            List<ModeloServicios> lobjRespuestaModelo = new List<ModeloServicios>();
            try
            {
                using (srvServicios.IsrvServiciosClient srvWCF_CR = new srvServicios.IsrvServiciosClient())
                {
                    lobjRespuesta = srvWCF_CR.recServicios_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        ModeloServicios objModeloServicios;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloServicios = new ModeloServicios();
                            objModeloServicios.IDServicio = lcr.IDServicio;
                            objModeloServicios.IDCliente = lcr.IDCliente;
                            objModeloServicios.NombreCliente = lcr.NombreCliente;
                            objModeloServicios.NombreMascota = lcr.NombreMascota;
                            objModeloServicios.Descripcion = lcr.Descripcion;
                            objModeloServicios.NumeroCita = lcr.NumeroCita;
                            lobjRespuestaModelo.Add(objModeloServicios);
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

        public ActionResult agregarServicios_ENT()
        {
            return View();
        }

        public ActionResult modificarServicios_ENT(int pId)
        {
            Servicios lobjRespuesta = new Servicios();
            ModeloServicios lobjModeloServicios;
            try
            {
                using (srvServicios.IsrvServiciosClient srvWCF_CR = new srvServicios.IsrvServiciosClient())
                {
                    lobjRespuesta = srvWCF_CR.recServiciosXId_ENT(pId);
                    lobjModeloServicios = new ModeloServicios();
                    lobjModeloServicios.IDServicio = lobjRespuesta.IDServicio;
                    lobjModeloServicios.IDCliente = lobjRespuesta.IDCliente;
                    lobjModeloServicios.NombreCliente = lobjRespuesta.NombreCliente;
                    lobjModeloServicios.NombreMascota = lobjRespuesta.NombreMascota; 
                    lobjModeloServicios.Descripcion = lobjRespuesta.Descripcion;
                    lobjModeloServicios.NumeroCita = lobjRespuesta.NumeroCita;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloServicios);
        }

        public ActionResult eliminarServicios_ENT(int pId)
        {
            Servicios lobjRespuesta = new Servicios();
            ModeloServicios lobjModeloServicios;
            try
            {
                using (srvServicios.IsrvServiciosClient srvWCF_CR = new srvServicios.IsrvServiciosClient())
                {
                    lobjRespuesta = srvWCF_CR.recServiciosXId_ENT(pId);
                    lobjModeloServicios = new ModeloServicios();
                    lobjModeloServicios.IDServicio = lobjRespuesta.IDServicio;
                    lobjModeloServicios.IDCliente = lobjRespuesta.IDCliente;
                    lobjModeloServicios.NombreCliente = lobjRespuesta.NombreCliente;
                    lobjModeloServicios.NombreMascota = lobjRespuesta.NombreMascota;
                    lobjModeloServicios.Descripcion = lobjRespuesta.Descripcion;
                    lobjModeloServicios.NumeroCita = lobjRespuesta.NumeroCita;

                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloServicios);
        }

        public ActionResult detalleServicios_ENT(int pId)
        {
            Servicios lobjRespuesta = new Servicios();
            ModeloServicios lobjModeloServicios;
            try
            {
                using (srvServicios.IsrvServiciosClient srvWCF_CR = new srvServicios.IsrvServiciosClient())
                {
                    lobjRespuesta = srvWCF_CR.recServiciosXId_ENT(pId);
                    lobjModeloServicios = new ModeloServicios();
                    lobjModeloServicios.IDServicio = lobjRespuesta.IDServicio;
                    lobjModeloServicios.IDCliente = lobjRespuesta.IDCliente;
                    lobjModeloServicios.NombreCliente = lobjRespuesta.NombreCliente;
                    lobjModeloServicios.NombreMascota = lobjRespuesta.NombreMascota;
                    lobjModeloServicios.Descripcion = lobjRespuesta.Descripcion;
                    lobjModeloServicios.NumeroCita = lobjRespuesta.NumeroCita;

                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloServicios);
        }

        /*****Acciones entidades******/
        public ActionResult accionesEntidades(string enviarAccion, ModeloServicios pModeloServicios)
        {
            Servicios pServicios = new Servicios();
            pServicios.IDServicio = pModeloServicios.IDServicio;
            pServicios.IDCliente = pModeloServicios.IDCliente;
            pServicios.NombreCliente = pModeloServicios.NombreCliente;
            pServicios.NombreMascota = pModeloServicios.NombreMascota;
            pServicios.Descripcion = pModeloServicios.Descripcion;
            pServicios.NumeroCita = pModeloServicios.NumeroCita;


            switch (enviarAccion)
            {
                case "Agregar":
                    return insertarCR_ENT(pServicios);
                case "Modificar":
                    return modificarCR_ENT(pServicios);
                case "Eliminar":
                    return eliminarCR_ENT(pServicios);
                default:
                    return RedirectToAction("listarServicios_ENT");
            }
        }

        public ActionResult insertarCR_ENT(Servicios pServicios)
        {
            List<Servicios> lobjRespuesta = new List<Servicios>();
            List<ModeloServicios> lobjRespuestaModelo = new List<ModeloServicios>();
            try
            {
                using (srvServicios.IsrvServiciosClient srvWCF_CR = new srvServicios.IsrvServiciosClient())
                {
                    if (srvWCF_CR.insServicios_ENT(pServicios))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recServicios_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        ModeloServicios objModeloServicios;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloServicios = new ModeloServicios();
                            objModeloServicios.IDServicio = lcr.IDServicio;
                            objModeloServicios.IDCliente = lcr.IDCliente;
                            objModeloServicios.NombreCliente = lcr.NombreCliente;
                            objModeloServicios.NombreMascota = lcr.NombreMascota;
                            objModeloServicios.Descripcion = lcr.Descripcion;
                            objModeloServicios.NumeroCita = lcr.NumeroCita;
                            lobjRespuestaModelo.Add(objModeloServicios);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarServicios_ENT", lobjRespuestaModelo);
        }

        public ActionResult modificarCR_ENT(Servicios pServicios)
        {
            List<Servicios> lobjRespuesta = new List<Servicios>();
            List<ModeloServicios> lobjRespuestaModelo = new List<ModeloServicios>();
            try
            {
                using (srvServicios.IsrvServiciosClient srvWCF_CR = new srvServicios.IsrvServiciosClient())
                {
                    if (srvWCF_CR.modServicios_ENT(pServicios))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recServicios_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        ModeloServicios objModeloServicios;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloServicios = new ModeloServicios();
                            objModeloServicios.IDServicio = lcr.IDServicio;
                            objModeloServicios.IDCliente = lcr.IDCliente;
                            objModeloServicios.NombreCliente = lcr.NombreCliente;
                            objModeloServicios.NombreMascota = lcr.NombreMascota;
                            objModeloServicios.Descripcion = lcr.Descripcion;
                            objModeloServicios.NumeroCita = lcr.NumeroCita;
                            lobjRespuestaModelo.Add(objModeloServicios);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarServicios_ENT", lobjRespuestaModelo);
        }

        public ActionResult eliminarCR_ENT(Servicios pServicios)
        {
            List<Servicios> lobjRespuesta = new List<Servicios>();
            List<ModeloServicios> lobjRespuestaModelo = new List<ModeloServicios>();
            try
            {
                using (srvServicios.IsrvServiciosClient srvWCF_CR = new srvServicios.IsrvServiciosClient())
                {
                    if (srvWCF_CR.delServicios_ENT(pServicios))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recServicios_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        ModeloServicios objModeloServicios;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloServicios = new ModeloServicios();
                            objModeloServicios.IDServicio = lcr.IDServicio;
                            objModeloServicios.IDCliente = lcr.IDCliente;
                            objModeloServicios.NombreCliente = lcr.NombreCliente;
                            objModeloServicios.NombreMascota = lcr.NombreMascota;
                            objModeloServicios.Descripcion = lcr.Descripcion;
                            objModeloServicios.NumeroCita = lcr.NumeroCita;
                            lobjRespuestaModelo.Add(objModeloServicios);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarServicios_ENT", lobjRespuestaModelo);
        }
    }
}