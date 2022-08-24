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
    public class SalesReasonLN : ISalesReasonLN
    {
        public static AWEntidades _objContextoAW = new AWEntidades();

        private readonly ISalesReasonAD gobjSalesReasonAD = new SalesReasonAD(_objContextoAW);


        public List<SalesReason> recSalesReason_ENT()
        {
            List<SalesReason> lobjRespuesta = new List<SalesReason>();
            try
            {
                lobjRespuesta = gobjSalesReasonAD.recSalesReason_ENT();
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public SalesReason recSalesReasonXId_ENT(int pId)
        {
            SalesReason lobjRespuesta = new SalesReason();
            try
            {
                lobjRespuesta = gobjSalesReasonAD.recSalesReasonXId_ENT(pId);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool insSalesReason_ENT(SalesReason pSalesReason)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjSalesReasonAD.insSalesReason_ENT(pSalesReason);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool modSalesReason_ENT(SalesReason pSalesReason)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjSalesReasonAD.modSalesReason_ENT(pSalesReason);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool delSalesReason_ENT(SalesReason pSalesReason)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjSalesReasonAD.delSalesReason_ENT(pSalesReason);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }




    }
}
