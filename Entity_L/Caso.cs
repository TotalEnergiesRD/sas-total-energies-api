using System;
using System.Collections.Generic;

namespace Entity_Layer
{
    public partial class Caso
    {
        public int IdCaso { get; set; }
        public int TipoDeCaso { get; set; }
        public int? Categoria { get; set; }
        public int? SubCategoria { get; set; }
        public int? Detalle { get; set; }
        public int Estado { get; set; }
        public string Descripcion { get; set; } = null!;
        public int Responsable { get; set; }
        public int IdCliente { get; set; }
        public string? Fecha { get; set; }
        public string? Tiempo { get; set; }
        public string? Extra { get; set; }
    }
}
