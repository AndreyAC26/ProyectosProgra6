using AccesoDatos;
using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;

namespace LogicaNegocio.Implementacion
{
    public class DiagnosticoLN : IDiagnosticoLN
    {
        public static VeterinariaEntidades _objContextoAW = new VeterinariaEntidades();

        private readonly IDiagnosticoAD gobjDiagnósticosAD = new DiagnosticoAD(_objContextoAW);

        //**************ENTIDADES**************//
        public List<Diagnósticos> recDiagnósticos_ENT()
        {
            List<Diagnósticos> lobjRespuesta = new List<Diagnósticos>();
            try
            {
                lobjRespuesta = gobjDiagnósticosAD.recDiagnósticos_ENT();
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public Diagnósticos recDiagnósticosXId_ENT(int pId)
        {
            Diagnósticos lobjRespuesta = new Diagnósticos();
            try
            {
                lobjRespuesta = gobjDiagnósticosAD.recDiagnósticosXId_ENT(pId);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool insDiagnósticos_ENT(Diagnósticos pDiagnósticos)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjDiagnósticosAD.insDiagnósticos_ENT(pDiagnósticos);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool modDiagnósticos_ENT(Diagnósticos pDiagnósticos)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjDiagnósticosAD.modDiagnósticos_ENT(pDiagnósticos);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool delDiagnósticos_ENT(Diagnósticos pDiagnósticos)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjDiagnósticosAD.delDiagnósticos_ENT(pDiagnósticos);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }
    }
}
