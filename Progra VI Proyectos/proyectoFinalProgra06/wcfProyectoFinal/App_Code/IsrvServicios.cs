using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvServicios" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvServicios
{
    [OperationContract]
    List<Servicios> recServicios_ENT();
    [OperationContract]
    Servicios recServiciosXId_ENT(int pId);
    [OperationContract]
    bool insServicios_ENT(Servicios pServicios);
    [OperationContract]
    bool modServicios_ENT(Servicios pServicios);
    [OperationContract]
    bool delServicios_ENT(Servicios pServicios);
}
