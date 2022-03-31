using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Data_Layer.D_Details;
using Entity_Layer;

namespace sas_total_energies_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailsController : ControllerBase
    {
        private D_Details details = new D_Details();
        [HttpGet("GetAll")]
        public async Task<List<Detail>> GetAll()
        {
            try
            {
                return await details.GetAll();
            }
            catch (Exception)
            {
                throw;
            }

        }
        [HttpPost("Create")]
        public async Task<bool> Create(Detail detail)
        {
            try
            {
                return await details.Create(detail);
            }
            catch (Exception)
            {
                throw;
            }

        }
        [HttpGet("Get")]
        public async Task<Detail> Get(int id)
        {
            try
            {
                return await details.Get(id);
            }
            catch (Exception)
            {
                throw;
            }

        }

        [HttpPut("Update")]
        public async Task<bool> Update(Detail detail)
        {
            try
            {
                return await details.Update(detail);

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
                return await details.Delete(id);

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
    }
}
