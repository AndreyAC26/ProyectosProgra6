using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IwcfClientes" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IwcfClientes
{
    [OperationContract]
    List<Clientes> recCountryRegion_ENT();
    [OperationContract]
    Clientes recClientesXId_ENT(int pId);
    [OperationContract]
    bool insClientes_ENT(Clientes pClientes);
    [OperationContract]
    bool modClientes_ENT(Clientes pClientes);
    [OperationContract]
    bool delClientes_ENT(Clientes pClientes);
}
