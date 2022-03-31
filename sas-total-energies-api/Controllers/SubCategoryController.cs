using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Data_Layer.D_SubCategory;
using Entity_Layer;

namespace sas_total_energies_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private D_SubCategory SubCategories = new D_SubCategory();
        [HttpGet("GetAll")]
        public async Task<List<SubCategory>> GetAll()
        {
            try
            {
                return await SubCategories.GetAll();
            }
            catch (Exception)
            {
                throw;
            }

        }
        [HttpPost("Create")]
        public async Task<bool> Create(SubCategory subCategory)
        {
            try
            {
                return await SubCategories.Create(subCategory);
            }
            catch (Exception)
            {
                throw;
            }

        }
        [HttpGet("Get")]
        public async Task<SubCategory> Get(int id)
        {
            try
            {
                return await SubCategories.Get(id);
            }
            catch (Exception)
            {
                throw;
            }

        }

        [HttpPut("Update")]
        public async Task<bool> Update(SubCategory subCategory)
        {
            try
            {
                return await SubCategories.Update(subCategory);

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
                return await SubCategories.Delete(id);

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
    }
}
