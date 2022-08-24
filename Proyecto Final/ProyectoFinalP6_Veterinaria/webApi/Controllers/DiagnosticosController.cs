using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webApi.Controllers
{
    public class DiagnosticosController : ApiController
    {
        private readonly IDiagnosticosLN gobjDiagnosticosLN = new DiagnosticosLN();

        ///////****ENTIDADES****/////
        [HttpGet]
        public List<Diagnósticos> recDiagnosticos_ENT()
        {
            //VARIABLE
            List<Diagnósticos> lobjRespuesta = new List<Diagnósticos>();
            try
            {
                lobjRespuesta = gobjDiagnosticosLN.recDiagnosticos_ENT();
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        [HttpGet]
        public Diagnósticos recDiagnosticosXId_ENT(int pId)
        {
            //VARIABLE
            Diagnósticos lobjRespuesta = new Diagnósticos();
            try
            {
                lobjRespuesta = gobjDiagnosticosLN.recDiagnosticosXId_ENT(pId);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        [HttpPost]
        public IHttpActionResult insDiagnosticos([FromBody] Diagnósticos pDiagnosticos)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gobjDiagnosticosLN.insDiagnósticos_ENT(pDiagnosticos);
                    return Ok(pDiagnosticos);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
        }
    }
}
