using Entidades;
using mvcInterfazUsuario.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class ClientesController : Controller
    {
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //*********ENTIDADES*********//
        public ActionResult listarClientes_ENT()
        {
            List<Clientes> lobjRespuesta = new List<Clientes>();
            List<ModeloClientes> lobjRespuestaModelo = new List<ModeloClientes>();
            try
            {
                using (srvClientes.IsrvClientesClient srvWCF_CR = new srvClientes.IsrvClientesClient())
                {
                    lobjRespuesta = srvWCF_CR.recClientes_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        ModeloClientes objModeloClientes;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloClientes = new ModeloClientes();
                            objModeloClientes.IDCliente = lcr.IDCliente;
                            objModeloClientes.Nombre = lcr.Nombre;
                            objModeloClientes.PrimerApellido = lcr.PrimerApellido;
                            objModeloClientes.SegundoApellido = lcr.SegundoApellido;
                            objModeloClientes.Telefono = (int)lcr.Telefono;
                            objModeloClientes.CorreoElectronico = lcr.CorreoElectronico;
                            lobjRespuestaModelo.Add(objModeloClientes);
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

        public ActionResult agregarClientes_ENT()
        {
            return View();
        }

        public ActionResult modificarClientes_ENT(int pId)
        {
            Clientes lobjRespuesta = new Clientes();
            ModeloClientes lobjModeloClientes;
            try
            {
                using (srvClientes.IsrvClientesClient srvWCF_CR = new srvClientes.IsrvClientesClient())
                {
                    lobjRespuesta = srvWCF_CR.recClientesXId_ENT(pId);
                    lobjModeloClientes = new ModeloClientes();
                    lobjModeloClientes.IDCliente = lobjRespuesta.IDCliente;
                    lobjModeloClientes.Nombre = lobjRespuesta.Nombre;
                    lobjModeloClientes.PrimerApellido = lobjRespuesta.PrimerApellido;
                    lobjModeloClientes.SegundoApellido = lobjRespuesta.SegundoApellido;
                    lobjModeloClientes.Telefono = (int)lobjRespuesta.Telefono;
                    lobjModeloClientes.CorreoElectronico = lobjRespuesta.CorreoElectronico;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloClientes);
        }

        public ActionResult eliminarClientes_ENT(int pId)
        {
            Clientes lobjRespuesta = new Clientes();
            ModeloClientes lobjModeloClientes;
            try
            {
                using (srvClientes.IsrvClientesClient srvWCF_CR = new srvClientes.IsrvClientesClient())
                {
                    lobjRespuesta = srvWCF_CR.recClientesXId_ENT(pId);
                    lobjModeloClientes = new ModeloClientes();
                    lobjModeloClientes.IDCliente = lobjRespuesta.IDCliente;
                    lobjModeloClientes.Nombre = lobjRespuesta.Nombre;
                    lobjModeloClientes.PrimerApellido = lobjRespuesta.PrimerApellido;
                    lobjModeloClientes.SegundoApellido = lobjRespuesta.SegundoApellido;
                    lobjModeloClientes.Telefono = (int)lobjRespuesta.Telefono;
                    lobjModeloClientes.CorreoElectronico = lobjRespuesta.CorreoElectronico;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloClientes);
        }

        public ActionResult detalleClientes_ENT(int pId)
        {
            Clientes lobjRespuesta = new Clientes();
            ModeloClientes lobjModeloClientes;
            try
            {
                using (srvClientes.IsrvClientesClient srvWCF_CR = new srvClientes.IsrvClientesClient())
                {
                    lobjRespuesta = srvWCF_CR.recClientesXId_ENT(pId);
                    lobjModeloClientes = new ModeloClientes();
                    lobjModeloClientes.IDCliente = lobjRespuesta.IDCliente;
                    lobjModeloClientes.Nombre = lobjRespuesta.Nombre;
                    lobjModeloClientes.PrimerApellido = lobjRespuesta.PrimerApellido;
                    lobjModeloClientes.SegundoApellido = lobjRespuesta.SegundoApellido;
                    lobjModeloClientes.Telefono = (int)lobjRespuesta.Telefono;
                    lobjModeloClientes.CorreoElectronico = lobjRespuesta.CorreoElectronico;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloClientes);
        }

        /*****Acciones entidades******/
        public ActionResult accionesEntidades(string enviarAccion, ModeloClientes pModeloClientes)
        {
            Clientes pClientes = new Clientes();
            pClientes.IDCliente = pModeloClientes.IDCliente;
            pClientes.Nombre = pModeloClientes.Nombre;
            pClientes.PrimerApellido = pModeloClientes.PrimerApellido;
            pClientes.SegundoApellido = pModeloClientes.SegundoApellido;
            pClientes.Telefono = pModeloClientes.Telefono;
            pClientes.CorreoElectronico = pModeloClientes.CorreoElectronico;


            switch (enviarAccion)
            {
                case "Agregar":
                    return insertarCR_ENT(pClientes);
                case "Modificar":
                    return modificarCR_ENT(pClientes);
                case "Eliminar":
                    return eliminarCR_ENT(pClientes);
                default:
                    return RedirectToAction("listarClientes_ENT");
            }
        }

        public ActionResult insertarCR_ENT(Clientes pClientes)
        {
            List<Clientes> lobjRespuesta = new List<Clientes>();
            List<ModeloClientes> lobjRespuestaModelo = new List<ModeloClientes>();
            try
            {
                using (srvClientes.IsrvClientesClient srvWCF_CR = new srvClientes.IsrvClientesClient())
                {
                    if (srvWCF_CR.insClientes_ENT(pClientes))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recClientes_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        ModeloClientes objModeloClientes;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloClientes = new ModeloClientes();
                            objModeloClientes.IDCliente = lcr.IDCliente;
                            objModeloClientes.Nombre = lcr.Nombre;
                            objModeloClientes.PrimerApellido = lcr.PrimerApellido;
                            objModeloClientes.SegundoApellido = lcr.SegundoApellido;
                            objModeloClientes.Telefono = (int)lcr.Telefono;
                            objModeloClientes.CorreoElectronico = lcr.CorreoElectronico;
                            lobjRespuestaModelo.Add(objModeloClientes);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarClientes_ENT", lobjRespuestaModelo);
        }

        public ActionResult modificarCR_ENT(Clientes pClientes)
        {
            List<Clientes> lobjRespuesta = new List<Clientes>();
            List<ModeloClientes> lobjRespuestaModelo = new List<ModeloClientes>();
            try
            {
                using (srvClientes.IsrvClientesClient srvWCF_CR = new srvClientes.IsrvClientesClient())
                {
                    if (srvWCF_CR.modClientes_ENT(pClientes))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recClientes_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        ModeloClientes objModeloClientes;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloClientes = new ModeloClientes();
                            objModeloClientes.IDCliente = lcr.IDCliente;
                            objModeloClientes.Nombre = lcr.Nombre;
                            objModeloClientes.PrimerApellido = lcr.PrimerApellido;
                            objModeloClientes.SegundoApellido = lcr.SegundoApellido;
                            objModeloClientes.Telefono = (int)lcr.Telefono;
                            objModeloClientes.CorreoElectronico = lcr.CorreoElectronico;
                            lobjRespuestaModelo.Add(objModeloClientes);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarClientes_ENT", lobjRespuestaModelo);
        }

        public ActionResult eliminarCR_ENT(Clientes pClientes)
        {
            List<Clientes> lobjRespuesta = new List<Clientes>();
            List<ModeloClientes> lobjRespuestaModelo = new List<ModeloClientes>();
            try
            {
                using (srvClientes.IsrvClientesClient srvWCF_CR = new srvClientes.IsrvClientesClient())
                {
                    if (srvWCF_CR.delClientes_ENT(pClientes))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recClientes_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        ModeloClientes objModeloClientes;
                        foreach (var lcr in lobjRespuesta)
                        {
                            objModeloClientes = new ModeloClientes();
                            objModeloClientes.IDCliente = lcr.IDCliente;
                            objModeloClientes.Nombre = lcr.Nombre;
                            objModeloClientes.PrimerApellido = lcr.PrimerApellido;
                            objModeloClientes.SegundoApellido = lcr.SegundoApellido;
                            objModeloClientes.Telefono = (int)lcr.Telefono;
                            objModeloClientes.CorreoElectronico = lcr.CorreoElectronico;
                            lobjRespuestaModelo.Add(objModeloClientes);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarClientes_ENT", lobjRespuestaModelo);
        }

    }
}