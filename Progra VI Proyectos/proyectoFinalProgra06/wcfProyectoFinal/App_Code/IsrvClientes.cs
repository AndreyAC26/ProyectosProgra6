using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

[ServiceContract]
public interface IsrvClientes
{
    [OperationContract]
    List<Clientes> recClientes_ENT();
    [OperationContract]
    Clientes recClientesXId_ENT(int pId);
    [OperationContract]
    bool insClientes_ENT(Clientes pClientes);
    [OperationContract]
    bool modClientes_ENT(Clientes pClientes);
    [OperationContract]
    bool delClientes_ENT(Clientes pClientes);
}
