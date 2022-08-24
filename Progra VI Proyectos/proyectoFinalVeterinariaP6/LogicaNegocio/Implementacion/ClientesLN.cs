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
    public class ClientesLN : IClientesLN
    {
        public static veterinariaEntidades _objContextoAW = new veterinariaEntidades();

        private readonly IClientesAD gobjClientesAD = new ClientesAD(_objContextoAW);

        //**************ENTIDADES**************//
        public List<Clientes> recClientes_ENT()
        {
            List<Clientes> lobjRespuesta = new List<Clientes>();
            try
            {
                lobjRespuesta = gobjClientesAD.recClientes_ENT();
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public Clientes recClientesXId_ENT(int pId)
        {
            Clientes lobjRespuesta = new Clientes();
            try
            {
                lobjRespuesta = gobjClientesAD.recClientesXId_ENT(pId);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool insClientes_ENT(Clientes pClientes)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjClientesAD.insCliente_ENT(pClientes);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool modClientes_ENT(Clientes pClientes)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjClientesAD.modCliente_ENT(pClientes);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }

        public bool delClientes_ENT(Clientes pClientes)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = gobjClientesAD.delCliente_ENT(pClientes);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }
    }
}
