using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Data_Layer.D_Category;
using Entity_Layer;

namespace sas_total_energies_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private D_Category Categories = new D_Category();
        [HttpGet("GetAll")]
        public async Task<List<Category>> GetAll()
        {
            try
            {
                return await Categories.GetAll();
            }
            catch (Exception)
            {
                throw;
            }

        }
        [HttpPost("Create")]
        public async Task<bool> Create(Category category)
        {
            try
            {
                return await Categories.Create(category);
            }
            catch (Exception)
            {
                throw;
            }

        }
        [HttpGet("Get")]
        public async Task<Category> Get(int id)
        {
            try
            {
                return await Categories.Get(id);
            }
            catch (Exception)
            {
                throw;
            }

        }

        [HttpPut("Update")]
        public async Task<bool> Update(Category category)
        {
            try
            {
                return await Categories.Update(category);

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
                return await Categories.Delete(id);

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }



    }
}
