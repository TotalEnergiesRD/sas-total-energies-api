using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Data_Layer.Users;
using Entity_L;

namespace sas_total_energies_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private D_Users users = new D_Users();
        [HttpGet("GetAll")]
        public async Task<List<Usuario>> GetAll()
        {
            try
            {
                return await users.GetAll();
            }
            catch (Exception)
            {
                throw;
            }

        }
        [HttpPost("Create")]
        public async Task<bool> Create(Usuario usuario)
        {
            try
            {
                return await users.Create(usuario);
            }
            catch (Exception)
            {
                throw;
            }

        }
        [HttpGet("Get")]
        public async Task<Usuario> Get(int id)
        {
            try
            {
                return await users.Get(id);
            }
            catch (Exception)
            {
                throw;
            }

        }

        [HttpPut("Edit")]
        public async Task<bool> Edit(Usuario usuario)
        {
            try
            {
                return await users.Edit(usuario);

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        [HttpPut("Delete")]
        public async Task<bool> Delete(int id)
        {
            try
            {
                return await users.Delete(id);

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
    }
}
