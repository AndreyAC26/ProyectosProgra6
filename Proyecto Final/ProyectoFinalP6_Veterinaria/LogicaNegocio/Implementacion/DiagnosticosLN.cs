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
    public class DiagnosticosLN : IDiagnosticosLN
    {
        //VARIABLE
        public static VeterEntidades _objContextoVeter = new VeterEntidades();
        private readonly IDiagnosticos gobjDiagnosticosAD = new DiagnosticosAD(_objContextoVeter);

        ///////****ENTIDADES****/////

        public List<Diagnósticos> recDiagnosticos_ENT()
        {
            //VARIABLE
            List<Diagnósticos> lobjRespuesta = new List<Diagnósticos>();
            try
            {
                lobjRespuesta = gobjDiagnosticosAD.recDiagnosticos_ENT();
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        public Diagnósticos recDiagnosticosXId_ENT(int pId)
        {
            //VARIABLE
            Diagnósticos lobjRespuesta = new Diagnósticos();
            try
            {
                lobjRespuesta = gobjDiagnosticosAD.recDiagnosticosXId_ENT(pId);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool insDiagnósticos_ENT(Diagnósticos pDiagnosticos)
        {

            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjDiagnosticosAD.insDiagnosticos_ENT(pDiagnosticos);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool modDiagnósticos_ENT(Diagnósticos pDiagnosticos)
        {
            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjDiagnosticosAD.modDiagnosticos_ENT(pDiagnosticos);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool delDiagnósticos_ENT(Diagnósticos pDiagnosticos)
        {
            //VARIABLE 
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjDiagnosticosAD.delDiagnosticos_ENT(pDiagnosticos);
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return lobjRespuesta;
        }

    }
}
