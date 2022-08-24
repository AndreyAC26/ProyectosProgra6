using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface ICitas
    {
        ///////****ENTIDADES****/////
        List<Citas> recCitas_ENT();
        Citas recCitasXId_ENT(int pId);
        bool insCitas_ENT(Citas pCita);
        bool modCitas_ENT(Citas pCita);
        bool delCitas_ENT(Citas pCita);

        //////////****PROCEDIMIENTOS ALMACENADOS****/////
    }
}
