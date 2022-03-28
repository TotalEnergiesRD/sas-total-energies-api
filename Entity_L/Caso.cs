using System;
using System.Collections.Generic;

namespace sas_total_energies_api
{
    public partial class Caso
    {
        public int IdCaso { get; set; }
        public DateOnly Fecha { get; set; }
        public int TipoDeCaso { get; set; }
        public int? Categoria { get; set; }
        public int? SubCategoria { get; set; }
        public int? Detalle { get; set; }
        public int Estado { get; set; }
        public string Descripcion { get; set; } = null!;
        public TimeOnly Tiempo { get; set; }
        public int Responsable { get; set; }
        public string Extra { get; set; } = null!;
        public int IdCliente { get; set; }

        public virtual Categorium? CategoriaNavigation { get; set; }
        public virtual Detalle? DetalleNavigation { get; set; }
        public virtual Cliente IdClienteNavigation { get; set; } = null!;
        public virtual Usuario ResponsableNavigation { get; set; } = null!;
        public virtual SubCategorium? SubCategoriaNavigation { get; set; }
        public virtual TipoDeCaso TipoDeCasoNavigation { get; set; } = null!;
    }
}
