using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webApi.Controllers
{
    public class DepartmentController : ApiController
    {
        private readonly IDepartmentLN gobjDepartmentLN = new DepartmentLN();
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //**************ENTIDADES**************//

        [HttpGet]
        public List<Department> recDepartmentn_ENT()
        {
            List<Department> lobjRespuesta = new List<Department>();
            try
            {
                lobjRespuesta = gobjDepartmentLN.recDepartment_ENT();
            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return lobjRespuesta;
        }

        [HttpGet]
        public Department recDepartmentXId_ENT(int pId)
        {
            Department lobjRespuesta = new Department();
            try
            {
                lobjRespuesta = gobjDepartmentLN.recDepartmentXId_ENT(pId);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        [HttpPost]
        public IHttpActionResult insDepartment([FromBody] Department pDepartment)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjDepartmentLN.insDepartment_ENT(pDepartment);
                    lEstado = true;
                }
                else
                {
                    lEstado = false;
                }

            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            if (lEstado)
            {
                return Ok(pDepartment);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IHttpActionResult modDepartment([FromBody] Department pDepartment)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjDepartmentLN.modDepartment_ENT(pDepartment);
                    lEstado = true;
                }
                else
                {
                    lEstado = false;
                }

            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            if (lEstado)
            {
                return Ok(pDepartment);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IHttpActionResult delDepartment([FromBody] Department pDepartment)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjDepartmentLN.delDepartment_ENT(pDepartment);
                    lEstado = true;
                }
                else
                {
                    lEstado = false;
                }

            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            if (lEstado)
            {
                return Ok(pDepartment);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
