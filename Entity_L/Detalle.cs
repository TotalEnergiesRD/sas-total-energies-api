using System;
using System.Collections.Generic;

namespace sas_total_energies_api
{
    public partial class Detalle
    {
        public Detalle()
        {
            Casos = new HashSet<Caso>();
        }

        public int IdDetalle { get; set; }
        public string Nombre { get; set; } = null!;
        public int SubCategoria { get; set; }

        public virtual SubCategorium SubCategoriaNavigation { get; set; } = null!;
        public virtual ICollection<Caso> Casos { get; set; }
    }
}
