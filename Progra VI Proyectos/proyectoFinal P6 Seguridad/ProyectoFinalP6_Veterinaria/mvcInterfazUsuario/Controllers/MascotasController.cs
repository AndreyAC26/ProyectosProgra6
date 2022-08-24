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
        //VARIABLE
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();//VARIABLE EXECCIONES
        //********ENTIDADES********//
        public ActionResult listarMascotas_ENT()
        {
            //VARIABLES
            List<Mascotas> lobjRespuesta = new List<Mascotas>();
            List<modeloMascotas> lobjRespuestaModelo = new List<modeloMascotas>();
            try
            {
                using (srvMascotas.IsrvMascotasClient srvWCF_MA = new srvMascotas.IsrvMascotasClient())
                {
                    lobjRespuesta = srvWCF_MA.recMascotas_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloMascotas objModeloMascotas;
                        foreach (var lma in lobjRespuesta)
                        {
                            objModeloMascotas = new modeloMascotas();
                            objModeloMascotas.IDMascota = lma.IDMascota;
                            objModeloMascotas.Nombre = lma.Nombre;
                            objModeloMascotas.IdCliente = lma.IdCliente;
                            lobjRespuestaModelo.Add(objModeloMascotas);

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

        public ActionResult AgregarMascotas_ENT()
        { 
            return View();
        }

        public ActionResult ModificarMascotas_ENT(int pId)
        {
            //VARIABLES
            Mascotas lobjRespuesta = new Mascotas();
            modeloMascotas lobjModeloMascotas = new modeloMascotas();
            try
            {
                using (srvMascotas.IsrvMascotasClient srvWCF_MA = new srvMascotas.IsrvMascotasClient())
                {
                    lobjRespuesta = srvWCF_MA.recMascotasXId_ENT(pId);
                    //lobjModeloMascotas = new modeloMascotas();
                    lobjModeloMascotas.IDMascota = lobjRespuesta.IDMascota;
                    lobjModeloMascotas.Nombre = lobjRespuesta.Nombre;
                    lobjModeloMascotas.IdCliente = lobjRespuesta.IdCliente;
                }
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View(lobjModeloMascotas);
        }

        public ActionResult EliminarMascotas_ENT(int pId)
        {
            //VARIABLES
            Mascotas lobjRespuesta = new Mascotas();
            modeloMascotas lobjModeloMascotas = new modeloMascotas();
            try
            {
                using (srvMascotas.IsrvMascotasClient srvWCF_MA = new srvMascotas.IsrvMascotasClient())
                {
                    lobjRespuesta = srvWCF_MA.recMascotasXId_ENT(pId);
                    //lobjModeloMascotas = new modeloMascotas();
                    lobjModeloMascotas.IDMascota = lobjRespuesta.IDMascota;
                    lobjModeloMascotas.Nombre = lobjRespuesta.Nombre;
                    lobjModeloMascotas.IdCliente = lobjRespuesta.IdCliente;
                }
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View(lobjModeloMascotas);
        }

        public ActionResult DetalleMascotas_ENT(int pId)
        {
            //VARIABLES
            Mascotas lobjRespuesta = new Mascotas();
            modeloMascotas lobjModeloMascotas = new modeloMascotas();
            try
            {
                using (srvMascotas.IsrvMascotasClient srvWCF_MA = new srvMascotas.IsrvMascotasClient())
                {
                    lobjRespuesta = srvWCF_MA.recMascotasXId_ENT(pId);
                    //lobjModeloMascotas = new modeloMascotas();
                    lobjModeloMascotas.IDMascota = lobjRespuesta.IDMascota;
                    lobjModeloMascotas.Nombre = lobjRespuesta.Nombre;
                    lobjModeloMascotas.IdCliente = lobjRespuesta.IdCliente;
                }
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View(lobjModeloMascotas);
        }

        //*****ACCIONES ENTIDADES*****//
        public ActionResult accionesEntidades(string enviarAccion, modeloMascotas pModeloMascotas)
        {
            Mascotas pMascotas = new Mascotas();
            pMascotas.IDMascota = pModeloMascotas.IDMascota;
            pMascotas.IdCliente = pModeloMascotas.IdCliente;
            pMascotas.Nombre = pModeloMascotas.Nombre;
            
            
            switch (enviarAccion)
            {
                case "Agregar":
                    return insertarMASC_ENT(pMascotas);
                case "Modificar":
                    return modificarMASC_ENT(pMascotas);
                case "Eliminar":
                    return eliminarMASC_ENT(pMascotas);
                default:
                    return RedirectToAction("listarCitas_ENT");

            }

        }

        public ActionResult insertarMASC_ENT(Mascotas pMascotas)
        {
            List<Mascotas> lobjRespuesta = new List<Mascotas>();
            List<modeloMascotas> lobjRespuestaModelo = new List<modeloMascotas>();
            try
            {
                using (srvMascotas.IsrvMascotasClient srvWCF_MA = new srvMascotas.IsrvMascotasClient())
                {
                    if (srvWCF_MA.insMascotas_ENT(pMascotas))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_MA.recMascotas_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloMascotas objModeloMascotas;
                        foreach (var lma in lobjRespuesta)
                        {
                            objModeloMascotas = new modeloMascotas();
                            objModeloMascotas.IDMascota = lma.IDMascota;
                            objModeloMascotas.Nombre = lma.Nombre;
                            objModeloMascotas.IdCliente = lma.IdCliente;
                            lobjRespuestaModelo.Add(objModeloMascotas);

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

        public ActionResult modificarMASC_ENT(Mascotas pMascotas)
        {
            List<Mascotas> lobjRespuesta = new List<Mascotas>();
            List<modeloMascotas> lobjRespuestaModelo = new List<modeloMascotas>();
            try
            {
                using (srvMascotas.IsrvMascotasClient srvWCF_MA = new srvMascotas.IsrvMascotasClient())
                {
                    if (srvWCF_MA.modMascotas_ENT(pMascotas))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_MA.recMascotas_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloMascotas objModeloMascotas;
                        foreach (var lma in lobjRespuesta)
                        {
                            objModeloMascotas = new modeloMascotas();
                            objModeloMascotas.IDMascota = lma.IDMascota;
                            objModeloMascotas.Nombre = lma.Nombre;
                            objModeloMascotas.IdCliente = lma.IdCliente;
                            lobjRespuestaModelo.Add(objModeloMascotas);

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

        public ActionResult eliminarMASC_ENT(Mascotas pMascotas)
        {
            List<Mascotas> lobjRespuesta = new List<Mascotas>();
            List<modeloMascotas> lobjRespuestaModelo = new List<modeloMascotas>();
            try
            {
                using (srvMascotas.IsrvMascotasClient srvWCF_MA = new srvMascotas.IsrvMascotasClient())
                {
                    if (srvWCF_MA.delMascotas_ENT(pMascotas))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_MA.recMascotas_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloMascotas objModeloMascotas;
                        foreach (var lma in lobjRespuesta)
                        {
                            objModeloMascotas = new modeloMascotas();
                            objModeloMascotas.IDMascota = lma.IDMascota;
                            objModeloMascotas.Nombre = lma.Nombre;
                            objModeloMascotas.IdCliente = lma.IdCliente;
                            lobjRespuestaModelo.Add(objModeloMascotas);

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