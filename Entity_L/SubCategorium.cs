using System;
using System.Collections.Generic;

namespace Entity_L
{
    public partial class SubCategorium
    {
        public int IdSubCategoria { get; set; }
        public string Nombre { get; set; } = null!;
        public int Categoria { get; set; }
    }
}
