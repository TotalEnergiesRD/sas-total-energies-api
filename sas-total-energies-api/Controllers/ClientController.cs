using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Data_Layer.Clients;
using Entity_Layer;

namespace sas_total_energies_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private D_Clients client = new D_Clients();

        [HttpGet("GetAll")]
        public async Task<List<Cliente>> GetAll()
        {
            try
            {
                return await client.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("Get")]
        public async Task<Cliente> Get(int idclient)
        {
            try
            {
                return await client.Get(idclient);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("Create")]
        public async Task<bool> Create(Cliente cliente)
        {
            try
            {
                return await client.Create(cliente);
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpDelete("Delete")]
        public async Task<bool> Delete(int idclient)
        {
            try
            {
                return await client.Delete(idclient);
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpPut("Update")]
        public async Task<bool> Update(Cliente cliente)
        {
            try
            {
                return await client.Update(cliente);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
