using AccesoDatos.Interfaces;
using Entidades;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementacion
{
    public class ClientesAD : IClientesAD
    {

        private veterinariaEntidades gObjConexionVeterinaria;
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        public ClientesAD(veterinariaEntidades lObjConexionAW)
        {
            gObjConexionVeterinaria = lObjConexionAW;
        }

        //**************ENTIDADES**************//
        public List<Clientes> recClientes_ENT()
        {
            List<Clientes> lobjRespuesta = new List<Clientes>();
            try
            {
                gObjConexionVeterinaria.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionVeterinaria.Clientes.ToList();
            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            finally
            {
                gObjConexionVeterinaria.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public Clientes recClientesXId_ENT(int pId)
        {
            Clientes lobjRespuesta = new Clientes();
            try
            {
                gObjConexionVeterinaria.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionVeterinaria.Clientes.ToList().Find(cr => cr.IDCliente == pId);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            finally
            {
                gObjConexionVeterinaria.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool insCliente_ENT(Clientes pClientes)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionVeterinaria.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionVeterinaria.Clientes.Find(pClientes.IDCliente);
                if (regEncontrado == null)
                {
                    gObjConexionVeterinaria.Clientes.Add(pClientes);
                    gObjConexionVeterinaria.SaveChanges();
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            finally
            {
                gObjConexionVeterinaria.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool modCliente_ENT(Clientes pClientes)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionVeterinaria.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionVeterinaria.Clientes.Find(pClientes.IDCliente);
                if (regEncontrado != null)
                {
                    gObjConexionVeterinaria.Entry(regEncontrado).CurrentValues.SetValues(pClientes);
                    gObjConexionVeterinaria.Entry(regEncontrado).State = System.Data.Entity.EntityState.Modified;
                    gObjConexionVeterinaria.SaveChanges();
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            finally
            {
                gObjConexionVeterinaria.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool delCliente_ENT(Clientes pClientes)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionVeterinaria.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionVeterinaria.Clientes.Find(pClientes.IDCliente);
                if (regEncontrado != null)
                {
                    gObjConexionVeterinaria.Entry(regEncontrado).CurrentValues.SetValues(pClientes);
                    gObjConexionVeterinaria.Entry(regEncontrado).State = System.Data.Entity.EntityState.Deleted;
                    gObjConexionVeterinaria.SaveChanges();
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            finally
            {
                gObjConexionVeterinaria.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }
    }
}
