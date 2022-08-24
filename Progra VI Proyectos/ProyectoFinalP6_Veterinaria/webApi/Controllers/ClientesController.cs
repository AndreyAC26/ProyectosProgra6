using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using NLog;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace webApi.Controllers
{
    public class ClientesController : ApiController
    {
        //VARIABLES
        private readonly IClientesLN gobjClientesLN = new ClientesLN();
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();//VARIABLE EXECCIONES

        ///////****ENTIDADES****/////
        [HttpGet]
        public List<Clientes> recClientes_ENT()
        {
            //VARIABLE
            List<Clientes> lobjRespuesta = new List<Clientes>();
            try
            {
                lobjRespuesta = gobjClientesLN.recClientes_ENT();
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return lobjRespuesta;
        }

        [HttpGet]
        public Clientes recClientesXId_ENT(int pId)
        {
            //VARIABLE
            Clientes lobjRespuesta = new Clientes();
            try
            {
                lobjRespuesta = gobjClientesLN.recClientesXId_ENT(pId);
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return lobjRespuesta;
        }

        [HttpPost]
        public IHttpActionResult  insClientes([FromBody] Clientes pClientes)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjClientesLN.insClientes_ENT(pClientes);
                    lEstado = true;

                }
                else
                {
                    lEstado = false;
                }
            }
            catch (Exception lEx)
            {

                // throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                     " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            if (lEstado)
            {
                return Ok(pClientes);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IHttpActionResult modClientes([FromBody] Clientes pClientes)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjClientesLN.insClientes_ENT(pClientes);
                    lEstado = true;

                }
                else
                {
                    lEstado = false;
                }
            }
            catch (Exception lEx)
            {

                // throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                     " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            if (lEstado)
            {
                return Ok(pClientes);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IHttpActionResult delClientes([FromBody] Clientes pClientes)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjClientesLN.insClientes_ENT(pClientes);
                    lEstado = true;

                }
                else
                {
                    lEstado = false;
                }
            }
            catch (Exception lEx)
            {

                // throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                     " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            if (lEstado)
            {
                return Ok(pClientes);
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
