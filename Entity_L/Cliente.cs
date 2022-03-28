using System;
using System.Collections.Generic;

namespace sas_total_energies_api
{
    public partial class Cliente
    {
        public Cliente()
        {
            Casos = new HashSet<Caso>();
        }

        public int IdCliente { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Apellidos { get; set; }
        public long? Telefono { get; set; }
        public long? Celular { get; set; }
        public string? Direccion { get; set; }

        public virtual ICollection<Caso> Casos { get; set; }
    }
}
