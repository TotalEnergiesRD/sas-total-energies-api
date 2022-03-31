using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entity_Layer;
using Data_Layer.D_CaseType;
using System.Text.Json;

namespace sas_total_energies_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseTypeController : ControllerBase
    {
        private D_CaseType casetypes = new D_CaseType();

        [HttpGet("GetAll")]
        public async Task<List<CaseType>> GetAll()
        {
            try
            {
                return await casetypes.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("Get")]
        public async Task<CaseType> Get(int idcasetype)
        {
            try
            {
                return await casetypes.Get(idcasetype);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("Create")]
        public async Task<bool> Create(CaseType caseType)
        {
            try
            {
                return await casetypes.Create(caseType);
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpPut("Update")]
        public async Task<bool> Update(CaseType caseType)
        {
            try
            {
                return await casetypes.Update(caseType);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete("Delete")]
        public async Task<bool> Delete(int idcaseType)
        {
            try
            {
                return await casetypes.Delete(idcaseType);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
