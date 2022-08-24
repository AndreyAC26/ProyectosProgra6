using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IsrvFacturacion" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IsrvFacturacion
{
    [OperationContract]
    List<Facturacion> recFacturacion_ENT();
    [OperationContract]
    Facturacion recFacturacionXId_ENT(int pId);
    [OperationContract]
    bool insFacturacion_ENT(Facturacion pFacturacion);
    [OperationContract]
    bool modFacturacion_ENT(Facturacion pFacturacion);
    [OperationContract]
    bool delFacturacion_ENT(Facturacion pFacturacion);
}
