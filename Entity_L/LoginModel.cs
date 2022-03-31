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
        public int IdUser { get; set; }
        public long Code { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }
        public int Role { get; set; }
    }
}
