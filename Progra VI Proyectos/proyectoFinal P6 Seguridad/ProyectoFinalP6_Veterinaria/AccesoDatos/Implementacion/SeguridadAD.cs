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
    public class SeguridadAD : ISeguridadAD
    {
        private SEGEntidades gObjConexionSEG;
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();//VARIABLE EXECCIONES

        public SeguridadAD(SEGEntidades lObjConexion)  //CONSTRUCTOR
        {
            gObjConexionSEG = lObjConexion;
        }
        public TUSR_USUARIOS recUsuario(string pUsrLogin)
        {
            //VARIABLE
            TUSR_USUARIOS lobjRespuesta = new TUSR_USUARIOS();
            try
            {
                gObjConexionSEG.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionSEG.TUSR_USUARIOS.ToList().Find(us => us.TC_Usuario == pUsrLogin);
            }
            catch (Exception lEx)
            {

                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicacion: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            finally
            {
                gObjConexionSEG.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }
    }
}
