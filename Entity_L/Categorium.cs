using System;
using System.Collections.Generic;

namespace sas_total_energies_api
{
    public partial class Categorium
    {
        public Categorium()
        {
            Casos = new HashSet<Caso>();
            SubCategoria = new HashSet<SubCategorium>();
        }

        public int IdCategoria { get; set; }
        public string Nombre { get; set; } = null!;
        public int TipodeCaso { get; set; }

        public virtual TipoDeCaso TipodeCasoNavigation { get; set; } = null!;
        public virtual ICollection<Caso> Casos { get; set; }
        public virtual ICollection<SubCategorium> SubCategoria { get; set; }
    }
}
