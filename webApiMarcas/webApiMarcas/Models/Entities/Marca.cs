﻿using System;
using System.Collections.Generic;

namespace webApiMarcas.Models.Entities
{
    public partial class Marca
    {
        public int MarcaId { get; set; }
        public string Nombre { get; set; } = null!;
    }
}
