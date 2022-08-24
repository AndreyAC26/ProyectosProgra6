using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface IClientesAD
    {
        List<Clientes> recClientes_ENT();
        Clientes recClientesXId_ENT(int pId);
        bool insClientes_ENT(Clientes pClientes);
        bool modClientes_ENT(Clientes pClientes);
        bool delClientes_ENT(Clientes pClientes);
    }
}
