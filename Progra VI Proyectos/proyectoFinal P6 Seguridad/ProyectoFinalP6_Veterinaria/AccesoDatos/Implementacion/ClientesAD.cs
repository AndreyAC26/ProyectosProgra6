using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Interfaces;//AGREGAR
using Entidades; //AGREGAR
using NLog;

namespace AccesoDatos.Implementacion
{
    public class ClientesAD : IClientes
    {
        private VeterEntidades gObjConexionAW;
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();//VARIABLE EXECCIONES

        public ClientesAD(VeterEntidades lObjConexion)  //CONSTRUCTOR
        {
            gObjConexionAW = lObjConexion;
        }

        ///////****ENTIDADES****/////
        public List<Clientes> recClientes_ENT()
        {
            //VARIABLE
            List<Clientes> lobjRespuesta = new List<Clientes>();
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionAW.Clientes.ToList();
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            finally
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public Clientes recClientesXId_ENT(int pId)
        {
            //VARIABLE
            Clientes lobjRespuesta = new Clientes();
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionAW.Clientes.ToList().Find(cl => cl.IDCliente == pId);
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            finally
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool insClientes_ENT(Clientes pClientes)
        {
            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionAW.Clientes.Find(pClientes.IDCliente);
                if (regEncontrado == null)
                {
                    gObjConexionAW.Clientes.Add(pClientes);
                    // gObjConexionAW.Entry(regEncontrado).State = System.Data.Entity.EntityState.Added; // SEGUNDA OPCION
                    gObjConexionAW.SaveChanges();
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            finally
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool modClientes_ENT(Clientes pClientes)
        {
            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionAW.Clientes.Find(pClientes.IDCliente);
                if (regEncontrado != null)
                {
                    gObjConexionAW.Entry(regEncontrado).CurrentValues.SetValues(pClientes);
                    gObjConexionAW.Entry(regEncontrado).State = System.Data.Entity.EntityState.Modified;
                    gObjConexionAW.SaveChanges();
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            finally
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool delClientes_ENT(Clientes pClientes) // O SOLO PODRIAMOS USAR EL ID 
        {
            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionAW.Clientes.Find(pClientes.IDCliente);
                if (regEncontrado != null)
                {
                    gObjConexionAW.Entry(regEncontrado).CurrentValues.SetValues(pClientes);
                    gObjConexionAW.Entry(regEncontrado).State = System.Data.Entity.EntityState.Deleted;
                    gObjConexionAW.SaveChanges();
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            finally
            {
                gObjConexionAW.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }


        //////////****PROCEDIMIENTOS ALMACENADOS****/////
    }
}
