using Entidades;//AGREGAR
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    public  interface ICitasLN
    {
        ///////****ENTIDADES****/////
        List<Citas> recCitas_ENT();
        Citas recCitasXId_ENT(int pId);
        bool insCitas_ENT(Citas pCitas);
        bool modCitas_ENT(Citas pCitas);
        bool delCitas_ENT(Citas pCitas);

        ///////****PROCEDIMIENTOS ALMACENADOS****/////
    }
}
