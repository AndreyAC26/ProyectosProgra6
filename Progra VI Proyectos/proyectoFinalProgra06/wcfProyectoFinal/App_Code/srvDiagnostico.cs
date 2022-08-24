using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

public class srvDiagnostico : IsrvDiagnostico
{
    private readonly IDiagnosticoLN gobjDiagnósticosLN = new DiagnosticoLN();

    //**************ENTIDADES**************//
    public List<Diagnósticos> recDiagnósticos_ENT()
    {
        List<Diagnósticos> lobjRespuesta = new List<Diagnósticos>();
        try
        {
            lobjRespuesta = gobjDiagnósticosLN.recDiagnósticos_ENT();
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public Diagnósticos recDiagnósticosXId_ENT(int pId)
    {
        Diagnósticos lobjRespuesta = new Diagnósticos();
        try
        {
            lobjRespuesta = gobjDiagnósticosLN.recDiagnósticosXId_ENT(pId);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool insDiagnósticos_ENT(Diagnósticos pDiagnósticos)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjDiagnósticosLN.insDiagnósticos_ENT(pDiagnósticos);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool modDiagnósticos_ENT(Diagnósticos pDiagnósticos)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjDiagnósticosLN.modDiagnósticos_ENT(pDiagnósticos);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool delDiagnósticos_ENT(Diagnósticos pDiagnósticos)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjDiagnósticosLN.delDiagnósticos_ENT(pDiagnósticos);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }
}
