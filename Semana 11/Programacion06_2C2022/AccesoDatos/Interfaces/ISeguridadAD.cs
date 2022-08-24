using Entidades;

namespace AccesoDatos.Interfaces
{
    public interface ISeguridadAD
    {
        TUSR_USUARIOS recUsuario(string pUsrLogin);
    }
}
