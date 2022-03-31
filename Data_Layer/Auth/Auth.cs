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
                return await UserValidation(Email.ToLower(), newpass);

            }
            catch (Exception)
            {

                throw;
            }            
        }

       
        private async Task<LoginModel> UserValidation(string Email, string Pass)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Email == Email && m.Password == Pass);
            if (user == null)
            {
                return null;
            }

            LoginModel login = new LoginModel()
            {
                IdUser = user.IdUser,
                Email = user.Email,
                Code = user.Code,
                Name = user.Name,
                LastName = user.Lastname,
                Role = user.Role,
            };
            
            return login;
        }



    }
   
}
