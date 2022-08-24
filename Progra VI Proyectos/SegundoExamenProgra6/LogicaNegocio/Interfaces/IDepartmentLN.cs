using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    public interface IDepartmentLN 
    {
        List<Department> recDepartment_ENT();
        Department recDepartmentXId_ENT(short pId);
        bool insDepartment_ENT(Department pDepartment);
        bool modDepartment_ENT(Department pDepartment);
        bool delDepartment_ENT(Department pDepartment);

    }
}
