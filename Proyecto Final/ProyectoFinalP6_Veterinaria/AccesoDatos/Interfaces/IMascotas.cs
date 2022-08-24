using Entidades;//AGREGAR
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface IMascotas
    {
        ///////****ENTIDADES****/////
        List<Mascotas> recMascotas_ENT();
        Mascotas recMascotasXId_ENT(int pId);
        bool insMascotas_ENT(Mascotas pMascota);
        bool modMascotas_ENT(Mascotas pMascota);
        bool delMascotas_ENT(Mascotas pMascota);

        //////////****PROCEDIMIENTOS ALMACENADOS****/////

    }
}
