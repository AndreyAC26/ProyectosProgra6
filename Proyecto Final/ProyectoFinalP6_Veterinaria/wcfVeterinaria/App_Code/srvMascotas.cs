using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvMascotas" en el código, en svc y en el archivo de configuración a la vez.
public class srvMascotas : IsrvMascotas
{
    private readonly IMascotasLN gobjMascotasLN = new MascotasLN();

    ///////****ENTIDADES****/////

    public List<Mascotas> recMascotas_ENT()
    {
        //VARIABLE
        List<Mascotas> lobjRespuesta = new List<Mascotas>();
        try
        {
            lobjRespuesta = gobjMascotasLN.recMascotas_ENT();
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }

    public Mascotas recMascotasXId_ENT(int pId)
    {
        //VARIABLE
        Mascotas lobjRespuesta = new Mascotas();
        try
        {
            lobjRespuesta = gobjMascotasLN.recMascotasXId_ENT(pId);
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool insMascotas_ENT(Mascotas pMascotas)
    {

        //VARIABLE 
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjMascotasLN.insMascotas_ENT(pMascotas);
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool modMascotas_ENT(Mascotas pMascotas)
    {
        //VARIABLE 
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjMascotasLN.modMascotas_ENT(pMascotas);
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool delMascotas_ENT(Mascotas pMascotas)
    {
        //VARIABLE 
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjMascotasLN.delMascotas_ENT(pMascotas);
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }
}
