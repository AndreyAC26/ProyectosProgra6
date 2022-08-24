using Entidades;
using System.ServiceModel;

[ServiceContract]
public interface IsrvSeguridad
{
    [OperationContract]
    TUSR_USUARIOS recUsuario(string pUsrLogin);
}
