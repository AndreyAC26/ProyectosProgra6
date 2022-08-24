using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcInterfazUsuario.Models
{
    public class ModeloServicios
    {
        public int IDServicio { get; set; }
        public Nullable<int> IDCliente { get; set; }
        public string NombreCliente { get; set; }
        public string NombreMascota { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> NumeroCita { get; set; }
    }
}