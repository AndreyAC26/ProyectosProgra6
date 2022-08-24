using AccesoDatos.Interfaces;//AGREGAR
using Entidades;//AGREGAR
using LogicaNegocio.Implementacion;//AGREGAR
using LogicaNegocio.Interfaces;//AGREGAR
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "srvClientes" en el código, en svc y en el archivo de configuración a la vez.
public class srvClientes : IsrvClientes
{

    private readonly IClientesLN gobjClientesLN = new ClientesLN();

    ///////****ENTIDADES****/////

    public List<Clientes> recClientes_ENT()
    {
        //VARIABLE
        List<Clientes> lobjRespuesta = new List<Clientes>();
        try
        {
            lobjRespuesta = gobjClientesLN.recClientes_ENT();
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }

    public Clientes recClientesXId_ENT(int pId)
    {
        //VARIABLE
        Clientes lobjRespuesta = new Clientes();
        try
        {
            lobjRespuesta = gobjClientesLN.recClientesXId_ENT(pId);
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool insClientes_ENT(Clientes pClientes)
    {

        //VARIABLE 
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjClientesLN.insClientes_ENT(pClientes);
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool modClientes_ENT(Clientes pClientes)
    {
        //VARIABLE 
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjClientesLN.modClientes_ENT(pClientes);
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }

    public bool delClientes_ENT(Clientes pClientes)
    {
        //VARIABLE 
        bool lobjRespuesta = false;
        try
        {
            lobjRespuesta = gobjClientesLN.delClientes_ENT(pClientes);
        }
        catch (Exception lEx)
        {

            throw lEx;
        }
        return lobjRespuesta;
    }
}
