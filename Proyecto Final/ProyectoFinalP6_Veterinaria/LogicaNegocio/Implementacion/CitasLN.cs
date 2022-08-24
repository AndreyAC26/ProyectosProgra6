using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;//AGREGAR
using AccesoDatos.Implementacion;//AGREGAR
using AccesoDatos.Interfaces;//AGREGAR
using Entidades;//AGREGAR
using LogicaNegocio.Interfaces;//AGREGAR

namespace LogicaNegocio.Implementacion
{
    public class CitasLN : ICitasLN
    {
        //VARIABLE
        public static VeterEntidades _objContextoVeter = new VeterEntidades();
        private readonly ICitas gobjCitasAD = new CitasAD(_objContextoVeter);

        ///////****ENTIDADES****/////

        public List<Citas> recCitas_ENT()
        {
            //VARIABLE
            List<Citas> lobjRespuesta = new List<Citas>();
            try
            {
                lobjRespuesta = gobjCitasAD.recCitas_ENT();
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        public Citas recCitasXId_ENT(int pId)
        {
            //VARIABLE
            Citas lobjRespuesta = new Citas();
            try
            {
                lobjRespuesta = gobjCitasAD.recCitasXId_ENT(pId);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool insCitas_ENT(Citas pCitas)
        {

            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjCitasAD.insCitas_ENT(pCitas);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool modCitas_ENT(Citas pCitas)
        {
            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjCitasAD.modCitas_ENT(pCitas);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool delCitas_ENT(Citas pCitas)
        {
            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjCitasAD.delCitas_ENT(pCitas);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

    }
}
