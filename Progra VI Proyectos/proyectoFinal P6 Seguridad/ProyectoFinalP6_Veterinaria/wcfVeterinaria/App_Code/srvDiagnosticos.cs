using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvDiagnosticos" en el código, en svc y en el archivo de configuración a la vez.
public class srvDiagnosticos : IsrvDiagnosticos
{
    private readonly IDiagnosticosLN gobjDiagnosticosLN = new DiagnosticosLN();

    ///////****ENTIDADES****/////

    public List<Diagnósticos> recDiagnosticos_ENT()
    {
        //VARIABLE
        List<Diagnósticos> lobjRespuesta = new List<Diagnósticos>();
        try
        {
            lobjRespuesta = gobjDiagnosticosLN.recDiagnosticos_ENT();
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }

    public Diagnósticos recDiagnosticosXId_ENT(int pId)
    {
        //VARIABLE
        Diagnósticos lobjRespuesta = new Diagnósticos();
        try
        {
            lobjRespuesta = gobjDiagnosticosLN.recDiagnosticosXId_ENT(pId);
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool insDiagnósticos_ENT(Diagnósticos pDiagnosticos)
    {

        //VARIABLE 
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjDiagnosticosLN.insDiagnósticos_ENT(pDiagnosticos);
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool modDiagnósticos_ENT(Diagnósticos pDiagnosticos)
    {
        //VARIABLE 
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjDiagnosticosLN.modDiagnósticos_ENT(pDiagnosticos);
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool delDiagnósticos_ENT(Diagnósticos pDiagnosticos)
    {
        //VARIABLE 
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjDiagnosticosLN.delDiagnósticos_ENT(pDiagnosticos);
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }
}
