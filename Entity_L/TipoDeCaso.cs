using System;
using System.Collections.Generic;

namespace sas_total_energies_api
{
    public partial class TipoDeCaso
    {
        public TipoDeCaso()
        {
            Casos = new HashSet<Caso>();
            Categoria = new HashSet<Categorium>();
        }

        public int IdCaso { get; set; }
        public string Nombre { get; set; } = null!;
        public TimeOnly? Sla { get; set; }

        public virtual ICollection<Caso> Casos { get; set; }
        public virtual ICollection<Categorium> Categoria { get; set; }
    }
}
