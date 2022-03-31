using System;
using System.Collections.Generic;

namespace Entity_Layer
{
    public partial class Categorium
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; } = null!;
        public int TipodeCaso { get; set; }
    }
}
