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
        bool insCliente_ENT(Clientes pClientes);
        bool modCliente_ENT(Clientes pClientes);
        bool delCliente_ENT(Clientes pClientes);
    }
}
