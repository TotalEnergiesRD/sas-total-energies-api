using System;
using System.Collections.Generic;

namespace Entity_Layer
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public long Codigo { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; } = null!;
    }
}
