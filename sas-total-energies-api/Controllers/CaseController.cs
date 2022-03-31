using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entity_Layer;
using Data_Layer.D_Cases;
using System.Text.Json;


namespace sas_total_energies_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseController : ControllerBase
    {
        private D_Cases cases = new D_Cases();
        
        [HttpGet("GetAll")]
        public async Task<List<CasesView>> GetAll()
        {
            try
            {
                return await cases.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("Get")]
        public async Task<CasesView> Get(string idcase)
        {
            try
            {
                return await cases.Get(idcase);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("GetToday")]
        public async Task<List<CasesTodayView>> GetToday()
        {
            try
            {
                return await cases.GetToday();
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpPost("Create")]
        public async Task<bool> Create(Case caso)
        {
            try
            {
                return await cases.Create(caso);
            }
            catch (Exception)
            {

                throw;
            }

        }


        [HttpPut("Update")]
        public async Task<bool> Update(Case caso)
        {
            try
            {
                return await cases.Update(caso);
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpDelete("Delete")]
        public async Task<bool> Delete(int idcase)
        {
            try
            {
                return await cases.Delete(idcase);
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}