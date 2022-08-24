using AccesoDatos;
using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;

namespace LogicaNegocio.Implementacion
{
    public class ClientesLN : IClientesLN
    {
        public static VeterinariaEntidades _objContextoAW = new VeterinariaEntidades();

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
                lobjRespuesta = gobjClientesAD.insClientes_ENT(pClientes);
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
                lobjRespuesta = gobjClientesAD.modClientes_ENT(pClientes);
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
                lobjRespuesta = gobjClientesAD.delClientes_ENT(pClientes);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }
    }
}
