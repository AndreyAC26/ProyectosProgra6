using AccesoDatos;//AGREGAR
using AccesoDatos.Implementacion;//AGREGAR
using AccesoDatos.Interfaces;//AGREGAR
using Entidades;//AGREGAR
using LogicaNegocio.Interfaces;//AGREGAR
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Implementacion
{
    public class ClientesLN : IClientesLN
    {
        //VARIABLE
        public static VeterEntidades _objContextoVeter = new VeterEntidades();
        private readonly IClientes gobjClientesAD = new ClientesAD(_objContextoVeter);
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();//VARIABLE EXECCIONES

        ///////****ENTIDADES****/////

        public List<Clientes> recClientes_ENT()
        {
            //VARIABLE
            List<Clientes> lobjRespuesta = new List<Clientes>();
            try
            {
                lobjRespuesta = gobjClientesAD.recClientes_ENT();
            }
            catch (Exception lEx)
            {

                // throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                     " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return lobjRespuesta;
        }

        public Clientes recClientesXId_ENT(int pId)
        {
            //VARIABLE
            Clientes lobjRespuesta = new Clientes();
            try
            {
                lobjRespuesta = gobjClientesAD.recClientesXId_ENT(pId);
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return lobjRespuesta;
        }

        public bool insClientes_ENT(Clientes pClientes)
        {

            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjClientesAD.insClientes_ENT(pClientes);
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return lobjRespuesta;
        }

        public bool modClientes_ENT(Clientes pClientes)
        {
            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjClientesAD.modClientes_ENT(pClientes);
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return lobjRespuesta;
        }

        public bool delClientes_ENT(Clientes pClientes)
        {
            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjClientesAD.delClientes_ENT(pClientes);
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return lobjRespuesta;
        }
    }
}
