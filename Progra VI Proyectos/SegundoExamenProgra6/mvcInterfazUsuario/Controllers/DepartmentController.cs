using Entidades;
using mvcInterfazUsuario.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //*********ENTIDADES*********//
        public ActionResult listarDepartment_ENT()
        {
            List<Department> lobjRespuesta = new List<Department>();
            List<modeloDepartment> lobjRespuestaModelo = new List<modeloDepartment>();
            try
            {
                using (srvDepartment.IsrvDeparmentClient srvWCF_CR = new srvDepartment.IsrvDeparmentClient())
                {
                    lobjRespuesta = srvWCF_CR.recDeparment_ENT();
                    modeloDepartment objModeloDepartment;
                    foreach (var lcr in lobjRespuesta)
                    {
                        objModeloDepartment = new modeloDepartment();
                        objModeloDepartment.DepartmentID = lcr.DepartmentID;
                        objModeloDepartment.GroupName = lcr.GroupName;
                        objModeloDepartment.Name = lcr.Name;
                        objModeloDepartment.ModifiedDate = lcr.ModifiedDate;
                        lobjRespuestaModelo.Add(objModeloDepartment);
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

        public ActionResult agregarDepartment_ENT()
        {
            return View();
        }

        public ActionResult modificarDepartment_ENT(short pId)
        {
            Department lobjRespuesta = new Department();
            modeloDepartment lobjModeloDepartment;
            try
            {
                using (srvDepartment.IsrvDeparmentClient srvWCF_CR = new srvDepartment.IsrvDeparmentClient())
                {
                    lobjRespuesta = srvWCF_CR.recDepartmentXId_ENT(pId);
                    lobjModeloDepartment = new modeloDepartment();
                    lobjModeloDepartment.DepartmentID = lobjRespuesta.DepartmentID;
                    lobjModeloDepartment.GroupName = lobjRespuesta.GroupName;
                    lobjModeloDepartment.Name = lobjRespuesta.Name;
                    lobjModeloDepartment.ModifiedDate = lobjRespuesta.ModifiedDate;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloDepartment);
        }

        public ActionResult eliminarDepartment_ENT(short pId)
        {
            Department lobjRespuesta = new Department();
            modeloDepartment lobjModeloDepartment;
            try
            {
                using (srvDepartment.IsrvDeparmentClient srvWCF_CR = new srvDepartment.IsrvDeparmentClient())
                {
                    lobjRespuesta = srvWCF_CR.recDepartmentXId_ENT(pId);
                    lobjModeloDepartment = new modeloDepartment();
                    lobjModeloDepartment.DepartmentID = lobjRespuesta.DepartmentID;
                    lobjModeloDepartment.GroupName = lobjRespuesta.GroupName;
                    lobjModeloDepartment.Name = lobjRespuesta.Name;
                    lobjModeloDepartment.ModifiedDate = lobjRespuesta.ModifiedDate;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloDepartment);
        }

        public ActionResult detalleDepartment_ENT(short pId)
        {
            Department lobjRespuesta = new Department();
            modeloDepartment lobjModeloDepartment;
            try
            {
                using (srvDepartment.IsrvDeparmentClient srvWCF_CR = new srvDepartment.IsrvDeparmentClient())
                {
                    lobjRespuesta = srvWCF_CR.recDepartmentXId_ENT(pId);
                    lobjModeloDepartment = new modeloDepartment();
                    lobjModeloDepartment.DepartmentID = lobjRespuesta.DepartmentID;
                    lobjModeloDepartment.GroupName = lobjRespuesta.GroupName;
                    lobjModeloDepartment.Name = lobjRespuesta.Name;
                    lobjModeloDepartment.ModifiedDate = lobjRespuesta.ModifiedDate;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloDepartment);
        }

        /*****Acciones entidades******/
        public ActionResult accionesEntidades(string enviarAccion, modeloDepartment pModeloDepartment)
        {
            Department pDepartment = new Department();
            pDepartment.DepartmentID = pModeloDepartment.DepartmentID;
            pDepartment.Name = pModeloDepartment.Name;
            pDepartment.ModifiedDate = pModeloDepartment.ModifiedDate;
            switch (enviarAccion)
            {
                case "Agregar":
                    return insertarCR_ENT(pDepartment);
                case "Modificar":
                    return modificarCR_ENT(pDepartment);
                case "Eliminar":
                    return eliminarCR_ENT(pDepartment);
                default:
                    return RedirectToAction("listarDepartment_ENT");
            }
        }

        public ActionResult insertarCR_ENT(Department pDepartment)
        {
            List<Department> lobjRespuesta = new List<Department>();
            try
            {
                using (srvDepartment.IsrvDeparmentClient srvWCF_CR = new srvDepartment.IsrvDeparmentClient())
                {
                    if (srvWCF_CR.insDepartment_ENT(pDepartment))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recDeparment_ENT();
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarDepartment_ENT", lobjRespuesta);
        }

        public ActionResult modificarCR_ENT(Department pDepartment)
        {
            List<Department> lobjRespuesta = new List<Department>();
            try
            {
                using (srvDepartment.IsrvDeparmentClient srvWCF_CR = new srvDepartment.IsrvDeparmentClient())
                {
                    if (srvWCF_CR.modDepartment_ENT(pDepartment))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recDeparment_ENT();
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarCountryRegions_ENT", lobjRespuesta);
        }

        public ActionResult eliminarCR_ENT(Department pDepartment)
        {
            List<Department> lobjRespuesta = new List<Department>();
            try
            {
                using (srvDepartment.IsrvDeparmentClient srvWCF_CR = new srvDepartment.IsrvDeparmentClient())
                {
                    if (srvWCF_CR.delDepartment_ENT(pDepartment))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_CR.recDeparment_ENT();
                }
            }
            catch (Exception lEx)
            {
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarDepartment_ENT", lobjRespuesta);
        }
    }
}