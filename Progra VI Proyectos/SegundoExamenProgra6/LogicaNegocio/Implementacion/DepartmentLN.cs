using AccesoDatos;
using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Implementacion
{
    public class DepartmentLN : IDepartmentLN
    {
        public static AWEntidades _objContextoAW = new AWEntidades();

        private readonly IDepartmentAD gobjDepartmentAD = new DepartmentAD(_objContextoAW);

        //**************ENTIDADES**************//
        public List<Department> recDepartment_ENT()
        {
            List<Department> lobjRespuesta = new List<Department>();
            try
            {
                lobjRespuesta = gobjDepartmentAD.recDepartment_ENT();
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
                lobjRespuesta = gobjDepartmentAD.recDepartmentXId_ENT(pId);
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
                lobjRespuesta = gobjDepartmentAD.insDepartment_ENT(pDepartment);
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
                lobjRespuesta = gobjDepartmentAD.modDepartment_ENT(pDepartment);
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
                lobjRespuesta = gobjDepartmentAD.delDepartment_ENT(pDepartment);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return lobjRespuesta;
        }
    }
}
