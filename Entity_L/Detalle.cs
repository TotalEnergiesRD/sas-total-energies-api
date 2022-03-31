using System;
using System.Collections.Generic;

namespace Entity_Layer
{
    public partial class Detalle
    {
        public int IdDetalle { get; set; }
        public string Nombre { get; set; } = null!;
        public int SubCategoria { get; set; }
    }
}
