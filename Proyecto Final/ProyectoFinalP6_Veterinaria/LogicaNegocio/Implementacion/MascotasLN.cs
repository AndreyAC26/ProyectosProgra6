using AccesoDatos;
using AccesoDatos.Implementacion;//AGREGAR
using AccesoDatos.Interfaces;//AGREGAR
using Entidades;//AGREGAR
using LogicaNegocio.Interfaces;//AGREGAR
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Implementacion
{
    public class MascotasLN : IMascotasLN
    {
        //VARIABLE
        public static VeterEntidades _objContextoVeter = new VeterEntidades();
        private readonly IMascotas gobjMascotasAD = new MascotasAD(_objContextoVeter);

        ///////****ENTIDADES****/////

        public List<Mascotas> recMascotas_ENT()
        {
            //VARIABLE
            List<Mascotas> lobjRespuesta = new List<Mascotas>();
            try
            {
                lobjRespuesta = gobjMascotasAD.recMascotas_ENT();
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        public Mascotas recMascotasXId_ENT(int pId)
        {
            //VARIABLE
            Mascotas lobjRespuesta = new Mascotas();
            try
            {
                lobjRespuesta = gobjMascotasAD.recMascotasXId_ENT(pId);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool insMascotas_ENT(Mascotas pMascotas)
        {

            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjMascotasAD.insMascotas_ENT(pMascotas);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool modMascotas_ENT(Mascotas pMascotas)
        {
            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjMascotasAD.modMascotas_ENT(pMascotas);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool delMascotas_ENT(Mascotas pMascotas)
        {
            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjMascotasAD.delMascotas_ENT(pMascotas);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }
    }
}
