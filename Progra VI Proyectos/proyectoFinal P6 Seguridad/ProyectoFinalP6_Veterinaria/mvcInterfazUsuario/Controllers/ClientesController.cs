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
    public class ClientesController : Controller
    {
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();//VARIABLE EXECCIONES
        //**********ENTIDADES*******//
        public ActionResult listarClientes_ENT()
        {
            //VARIABLE
            List<Clientes> lobjRespuesta = new List<Clientes>();
            List<modeloClientes> lobjRespuestaModelo = new List<modeloClientes>();
            try
            {
                using (srvClientes.IsrvClientesClient srvWCF_CL = new srvClientes.IsrvClientesClient())
                {
                    lobjRespuesta = srvWCF_CL.recClientes_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloClientes objModeloClientes;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloClientes = new modeloClientes();
                            objModeloClientes.IDCliente = lcl.IDCliente;
                            objModeloClientes.Nombre = lcl.Nombre;
                            objModeloClientes.PrimerApellido = lcl.PrimerApellido;
                            objModeloClientes.SegundoApellido = lcl.SegundoApellido;
                            objModeloClientes.Telefono = lcl.Telefono;
                            objModeloClientes.CorreoElectronico = lcl.CorreoElectronico;
                            lobjRespuestaModelo.Add(objModeloClientes);

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
            return View(lobjRespuestaModelo);
        }

        public ActionResult AgregarClientes_ENT()
        {
            return View();
        }

        public ActionResult ModificarClientes_ENT(int pId)
        {
            //VARIABLES
            Clientes lobjRespuesta = new Clientes();
            modeloClientes lobjModeloClientes = new modeloClientes();
            try
            {
                using (srvClientes.IsrvClientesClient srvWCF_CL = new srvClientes.IsrvClientesClient())
                {
                    lobjRespuesta = srvWCF_CL.recClientesXId_ENT(pId);
                    //lobjModeloClientes = new modeloClientes();
                    lobjModeloClientes.IDCliente = lobjRespuesta.IDCliente;
                    lobjModeloClientes.Nombre = lobjRespuesta.Nombre;
                    lobjModeloClientes.PrimerApellido = lobjRespuesta.PrimerApellido;
                    lobjModeloClientes.SegundoApellido = lobjRespuesta.SegundoApellido;
                    lobjModeloClientes.Telefono = lobjRespuesta.Telefono;
                    lobjModeloClientes.CorreoElectronico = lobjRespuesta.CorreoElectronico;
                }
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View(lobjModeloClientes);
        }

        public ActionResult EliminarClientes_ENT(int pId)
        {
            //VARIABLES
            Clientes lobjRespuesta = new Clientes();
            modeloClientes lobjModeloClientes = new modeloClientes();
            try
            {
                using (srvClientes.IsrvClientesClient srvWCF_CL = new srvClientes.IsrvClientesClient())
                {
                    lobjRespuesta = srvWCF_CL.recClientesXId_ENT(pId);
                    //lobjModeloClientes = new modeloClientes();
                    lobjModeloClientes.IDCliente = lobjRespuesta.IDCliente;
                    lobjModeloClientes.Nombre = lobjRespuesta.Nombre;
                    lobjModeloClientes.PrimerApellido = lobjRespuesta.PrimerApellido;
                    lobjModeloClientes.SegundoApellido = lobjRespuesta.SegundoApellido;
                    lobjModeloClientes.Telefono = lobjRespuesta.Telefono;
                    lobjModeloClientes.CorreoElectronico = lobjRespuesta.CorreoElectronico;
                }
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View(lobjModeloClientes);
        }

        public ActionResult DetalleClientes_ENT(int pId)
        {
            //VARIABLES
            Clientes lobjRespuesta = new Clientes();
            modeloClientes lobjModeloClientes = new modeloClientes();
            try
            {
                using (srvClientes.IsrvClientesClient srvWCF_CL = new srvClientes.IsrvClientesClient())
                {
                    lobjRespuesta = srvWCF_CL.recClientesXId_ENT(pId);
                    //lobjModeloClientes = new modeloClientes();
                    lobjModeloClientes.IDCliente = lobjRespuesta.IDCliente;
                    lobjModeloClientes.Nombre = lobjRespuesta.Nombre;
                    lobjModeloClientes.PrimerApellido = lobjRespuesta.PrimerApellido;
                    lobjModeloClientes.SegundoApellido = lobjRespuesta.SegundoApellido;
                    lobjModeloClientes.Telefono = lobjRespuesta.Telefono;
                    lobjModeloClientes.CorreoElectronico = lobjRespuesta.CorreoElectronico;
                }
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View(lobjModeloClientes);
        }

        //*****ACCIONES ENTIDADES*****//
        public ActionResult accionesEntidades(string enviarAccion, modeloClientes pModeloClientes)
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
                    return insertarCli_ENT(pClientes);
                case "Modificar":
                    return modificarCli_ENT(pClientes);
                case "Eliminar":
                    return eliminarCli_ENT(pClientes);
                default:
                    return RedirectToAction("listarCitas_ENT");

            }

        }

        public ActionResult insertarCli_ENT(Clientes pClientes)
        {
            
            List<Clientes> lobjRespuesta = new List<Clientes>();
            List<modeloClientes> lobjRespuestaModelo = new List<modeloClientes>();
            try
            {
                using (srvClientes.IsrvClientesClient srvWCF_CL = new srvClientes.IsrvClientesClient())
                {
                    if (srvWCF_CL.insClientes_ENT(pClientes))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CL.recClientes_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloClientes objModeloClientes;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloClientes = new modeloClientes();
                            objModeloClientes.IDCliente = lcl.IDCliente;
                            objModeloClientes.Nombre = lcl.Nombre;
                            objModeloClientes.PrimerApellido = lcl.PrimerApellido;
                            objModeloClientes.SegundoApellido = lcl.SegundoApellido;
                            objModeloClientes.Telefono = lcl.Telefono;
                            objModeloClientes.CorreoElectronico = lcl.CorreoElectronico;
                            lobjRespuestaModelo.Add(objModeloClientes);

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
            return View("listarClientes_ENT", lobjRespuestaModelo);
        }

        public ActionResult modificarCli_ENT(Clientes pClientes)
        {
            List<Clientes> lobjRespuesta = new List<Clientes>();
            List<modeloClientes> lobjRespuestaModelo = new List<modeloClientes>();
            try
            {
                using (srvClientes.IsrvClientesClient srvWCF_CL = new srvClientes.IsrvClientesClient())
                {
                    if (srvWCF_CL.modClientes_ENT(pClientes))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CL.recClientes_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloClientes objModeloClientes;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloClientes = new modeloClientes();
                            objModeloClientes.IDCliente = lcl.IDCliente;
                            objModeloClientes.Nombre = lcl.Nombre;
                            objModeloClientes.PrimerApellido = lcl.PrimerApellido;
                            objModeloClientes.SegundoApellido = lcl.SegundoApellido;
                            objModeloClientes.Telefono = lcl.Telefono;
                            objModeloClientes.CorreoElectronico = lcl.CorreoElectronico;
                            lobjRespuestaModelo.Add(objModeloClientes);

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
            return View("listarClientes_ENT", lobjRespuestaModelo);
        }

        public ActionResult eliminarCli_ENT(Clientes pClientes)
        {
            List<Clientes> lobjRespuesta = new List<Clientes>();
            List<modeloClientes> lobjRespuestaModelo = new List<modeloClientes>();
            try
            {
                using (srvClientes.IsrvClientesClient srvWCF_CL = new srvClientes.IsrvClientesClient())
                {
                    if (srvWCF_CL.delClientes_ENT(pClientes))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CL.recClientes_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloClientes objModeloClientes;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloClientes = new modeloClientes();
                            objModeloClientes.IDCliente = lcl.IDCliente;
                            objModeloClientes.Nombre = lcl.Nombre;
                            objModeloClientes.PrimerApellido = lcl.PrimerApellido;
                            objModeloClientes.SegundoApellido = lcl.SegundoApellido;
                            objModeloClientes.Telefono = lcl.Telefono;
                            objModeloClientes.CorreoElectronico = lcl.CorreoElectronico;
                            lobjRespuestaModelo.Add(objModeloClientes);

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
            return View("listarClientes_ENT", lobjRespuestaModelo);
        }


    }
}