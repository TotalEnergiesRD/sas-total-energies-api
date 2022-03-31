using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Layer;
using Microsoft.EntityFrameworkCore;

namespace Data_Layer.Auth
{
    public class Auth
    {
       
        private SASContext _context = new SASContext();

        public async Task<LoginModel> Login(string Email, string Pass)
        {
            try
            {
                string newpass = Encrypt.GetMD5(Pass);
                return await UserValidation(Email, newpass);

            }
            catch (Exception)
            {

                throw;
            }            
        }

       
        private async Task<LoginModel> UserValidation(string Email, string Pass)
        {

            var user = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Email == Email && m.Password == Pass);
            if (user == null)
            {
                return null;
            }

            LoginModel login = new LoginModel()
            {
                IdUsuario = user.IdUsuario,
                Email = user.Email,
                Codigo = user.Codigo,
                Nombre = user.Nombre,
                Apellidos = user.Apellidos,
                Rol = user.Rol,
            };
            
            return login;
        }



    }
   
}
