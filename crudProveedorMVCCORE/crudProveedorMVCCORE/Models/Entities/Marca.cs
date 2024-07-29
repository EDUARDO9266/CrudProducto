using System;
using System.Collections.Generic;

namespace crudProveedorMVCCORE.Models.Entities
{
    public partial class Marca
    {
        public int MarcaId { get; set; }
        public string Nombre { get; set; } = null!;
    }
}
