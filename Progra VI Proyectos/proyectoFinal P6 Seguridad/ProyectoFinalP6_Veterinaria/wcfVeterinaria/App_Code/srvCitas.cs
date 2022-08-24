
using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvCitas" en el código, en svc y en el archivo de configuración a la vez.
public class srvCitas : IsrvCitas
{

    //VARIABLE
    //public static VeterEntidades _objContextoVeter = new VeterEntidades();
    private readonly ICitasLN gobjCitasLN = new CitasLN();

    ///////****ENTIDADES****/////

    public List<Citas> recCitas_ENT()
    {
        //VARIABLE
        List<Citas> lobjRespuesta = new List<Citas>();
        try
        {
            lobjRespuesta = gobjCitasLN.recCitas_ENT();
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }

    public Citas recCitasXId_ENT(int pId)
    {
        //VARIABLE
        Citas lobjRespuesta = new Citas();
        try
        {
            lobjRespuesta = gobjCitasLN.recCitasXId_ENT(pId);
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool insCitas_ENT(Citas pCitas)
    {

        //VARIABLE 
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjCitasLN.insCitas_ENT(pCitas);
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool modCitas_ENT(Citas pCitas)
    {
        //VARIABLE 
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjCitasLN.modCitas_ENT(pCitas);
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool delCitas_ENT(Citas pCitas)
    {
        //VARIABLE 
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjCitasLN.delCitas_ENT(pCitas);
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }



}
