using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class ClientesController : Controller
    {
        //**********ENTIDADES*******//
        public ActionResult listarClientes_ENT()
        {
            //VARIABLE
            List<Clientes> lobjRespuesta = new List<Clientes>();
            try
            {
                using (srvClientes.IsrvClientesClient srvWCF_CL = new srvClientes.IsrvClientesClient())
                {
                    lobjRespuesta = srvWCF_CL.recClientes_ENT();
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult AgregarClientes_ENT()
        {
            return View();
        }

        public ActionResult ModificarClientes_ENT(int pId)
        {
            //VARIABLE
            Clientes lobjRespuesta = new Clientes();
            try
            {
                using (srvClientes.IsrvClientesClient srvWCF_CL = new srvClientes.IsrvClientesClient())
                {
                    lobjRespuesta = srvWCF_CL.recClientesXId_ENT(pId);
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult EliminarClientes_ENT(int pId)
        {
            //VARIABLE
            Clientes lobjRespuesta = new Clientes();
            try
            {
                using (srvClientes.IsrvClientesClient srvWCF_CL = new srvClientes.IsrvClientesClient())
                {
                    lobjRespuesta = srvWCF_CL.recClientesXId_ENT(pId);
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }

        public ActionResult DetalleClientes_ENT(int pId)
        {
            //VARIABLE
            Clientes lobjRespuesta = new Clientes();
            try
            {
                using (srvClientes.IsrvClientesClient srvWCF_CL = new srvClientes.IsrvClientesClient())
                {
                    lobjRespuesta = srvWCF_CL.recClientesXId_ENT(pId);
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjRespuesta);
        }


    }
}