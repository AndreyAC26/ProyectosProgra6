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
    public class ClientesController : ApiController
    {
        private readonly IClientesLN gobjClientesLN = new ClientesLN();

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

                throw lEx;
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

                throw lEx;
            }
            return lobjRespuesta;
        }

        [HttpPost]
        public IHttpActionResult  insClientes([FromBody] Clientes pClientes)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gobjClientesLN.insClientes_ENT(pClientes);
                    return Ok(pClientes);
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
