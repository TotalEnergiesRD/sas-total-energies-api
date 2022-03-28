using System;
using System.Collections.Generic;

namespace Entity_L
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Apellidos { get; set; }
        public long? Telefono { get; set; }
        public long? Celular { get; set; }
        public string? Direccion { get; set; }
    }
}
