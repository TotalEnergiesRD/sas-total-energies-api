using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class LoginModel
    {

        public string Email { get; set; }
        public int IdUsuario { get; set; }
        public long Codigo { get; set; }
        public string Nombre { get; set; }

        public string Apellidos { get; set; }
        public int Rol { get; set; }
    }
}
