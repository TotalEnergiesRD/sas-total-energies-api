using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Data_Layer.D_Customer;
using Entity_Layer;

namespace sas_total_energies_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private D_Customer customers = new D_Customer();

        [HttpGet("GetAll")]
        public async Task<List<Customer>> GetAll()
        {
            try
            {
                return await customers.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("Get")]
        public async Task<Customer> Get(int idcustomer)
        {
            try
            {
                return await customers.Get(idcustomer);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("Create")]
        public async Task<bool> Create(Customer customer)
        {
            try
            {
                return await customers.Create(customer);
            }
            catch (Exception)
            {

                throw;
            }

        }
        

        [HttpPut("Update")]
        public async Task<bool> Update(Customer customer)
        {
            try
            {
                return await customers.Update(customer);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("Delete")]
        public async Task<bool> Delete(int idcustomer)
        {
            try
            {
                return await customers.Delete(idcustomer);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
