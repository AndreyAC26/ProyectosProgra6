using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcInterfazUsuario.Models
{
    public class ModeloMascotas
    {
        public int IDMascota { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> IdCliente { get; set; }
    }
}