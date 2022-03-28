﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Data_Layer.Category;
using Entity_Layer;

namespace sas_total_energies_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private D_Category category = new D_Category();
        [HttpGet("GetAll")]
        public async Task<List<Categorium>> GetAll()
        {
            try
            {
                return await category.GetAll();
            }
            catch (Exception)
            {
                throw;
            }

        }
        [HttpPost("Create")]
        public async Task<bool> Create(Categorium categorium)
        {
            try
            {
                return await category.Create(categorium);
            }
            catch (Exception)
            {
                throw;
            }

        }
        [HttpGet("Get")]
        public async Task<Categorium> Get(int id)
        {
            try
            {
                return await category.Get(id);
            }
            catch (Exception)
            {
                throw;
            }

        }

        [HttpPut("Edit")]
        public async Task<bool> Edit(Categorium categorium)
        {
            try
            {
                return await category.Edit(categorium);

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
                return await category.Delete(id);

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }



    }
}
