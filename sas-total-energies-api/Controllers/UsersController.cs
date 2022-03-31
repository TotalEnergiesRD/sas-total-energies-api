using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Data_Layer.D_Users;
using Entity_Layer;

namespace sas_total_energies_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private D_Users users = new D_Users();
        [HttpGet("GetAll")]
        public async Task<List<User>> GetAll()
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
        public async Task<bool> Create(User usuario)
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
        public async Task<User> Get(int id)
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

        [HttpPut("Update")]
        public async Task<bool> Update(User user)
        {
            try
            {
                return await users.Update(user);

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        [HttpDelete("Delete")]
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
