using AccesoDatos;
using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Implementacion
{
    public class MascotasLN : IMascotasLN
    {
        public static VeterinariaEntidades _objContextoAW = new VeterinariaEntidades();

        private readonly IMascotasAD gobjMascotasAD = new MascotasAD(_objContextoAW);

        //**************ENTIDADES**************//
        public List<Mascotas> recMascotas_ENT()
        {
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
