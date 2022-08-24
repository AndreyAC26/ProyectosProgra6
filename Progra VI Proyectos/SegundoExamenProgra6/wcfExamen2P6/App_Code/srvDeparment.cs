using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

public class srvDeparment : IsrvDeparment
{
    private readonly IDepartmentLN gobjDepartmentLN = new DepartmentLN();

    //**************ENTIDADES**************//
    public List<Department> recDeparment_ENT()
    {
        List<Department> lobjRespuesta = new List<Department>();
        try
        {
            lobjRespuesta = gobjDepartmentLN.recDepartment_ENT();
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public Department recDepartmentXId_ENT(short pId)
    {
        Department lobjRespuesta = new Department();
        try
        {
            lobjRespuesta = gobjDepartmentLN.recDepartmentXId_ENT(pId);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool insDepartment_ENT(Department pDepartment)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjDepartmentLN.insDepartment_ENT(pDepartment);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool modDepartment_ENT(Department pDepartment)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjDepartmentLN.modDepartment_ENT(pDepartment);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool delDepartment_ENT(Department pDepartment)
    {
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjDepartmentLN.delDepartment_ENT(pDepartment);
        }
        catch (Exception lEx)
        {
            throw lEx;
        }
        return lobjRespuesta;
    }
}
