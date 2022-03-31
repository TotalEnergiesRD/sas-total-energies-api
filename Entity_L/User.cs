using System;
using System.Collections.Generic;

namespace Entity_Layer
{
    public partial class User
    {
        public int IdUser { get; set; }
        public string Name { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public long Code { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Role { get; set; }
    }
}
