using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entity_Layer;
using Data_Layer.Auth;

namespace sas_total_energies_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        Auth auth = new Auth();

        [HttpGet]
        public async Task<LoginModel> Login(string Email, string Pass)
        {
            try
            {
               return await auth.Login(Email, Pass);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
