﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entity_Layer;
using Data_Layer.Cases;
using System.Text.Json;


namespace sas_total_energies_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseController : ControllerBase
    {
        private D_Cases cases = new D_Cases();
        
        [HttpGet("GetAll")]
        public async Task<List<CasosView>> GetAll()
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
        public async Task<CasosView> Get(string idcase)
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
        public async Task<List<CasosDiaView>> GetToday()
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
        public async Task<bool> Create(Caso caso)
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
               

        [HttpDelete("Delete")]
        public async Task<bool> Delete(string idcaso)
        {
            try
            {
                return await cases.Delete(idcaso);
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpPut("Update")]
        public async Task<bool> Update(Caso caso)
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


    }
}