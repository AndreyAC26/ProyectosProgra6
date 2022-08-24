using Entidades;

namespace LogicaNegocio.Interfaces
{
    public interface ISeguridadLN
    {
        TUSR_USUARIOS recUsuario(string pUsrLogin);
    }
}
