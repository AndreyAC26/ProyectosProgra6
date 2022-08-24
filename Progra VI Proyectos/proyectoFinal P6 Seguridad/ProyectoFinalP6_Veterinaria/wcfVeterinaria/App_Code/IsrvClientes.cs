using Entidades;//AGREGAR
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvClientes" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvClientes
{

    ///////****ENTIDADES****/////
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

    ///////****PROCEDIMIENTOS ALMACENADOS****/////
    //[OperationContract]
    // void DoWork();
}
