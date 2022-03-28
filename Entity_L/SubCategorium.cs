using System;
using System.Collections.Generic;

namespace sas_total_energies_api
{
    public partial class SubCategorium
    {
        public SubCategorium()
        {
            Casos = new HashSet<Caso>();
            Detalles = new HashSet<Detalle>();
        }

        public int IdSubCategoria { get; set; }
        public string Nombre { get; set; } = null!;
        public int Categoria { get; set; }

        public virtual Categorium CategoriaNavigation { get; set; } = null!;
        public virtual ICollection<Caso> Casos { get; set; }
        public virtual ICollection<Detalle> Detalles { get; set; }
    }
}
