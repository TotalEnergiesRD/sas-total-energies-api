using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Layer;
using Microsoft.EntityFrameworkCore;

namespace Data_Layer.D_Customer
{
    public class D_Customer
    {
        private SASContext _context = new SASContext();
        public async Task<List<Customer>> GetAll()
        {
            try
            {
                return await _context.Customers.ToListAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return new List<Customer>();
            }
        }

        public async Task<Customer> Get(int? id)
        {
            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.IdCustomer == id);
            if (customer == null)
            {
                return customer;
            }

            return customer;
        }


        public async Task<bool> Create(Customer customer)
        {
            try
            {
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                if (CustomerExists(id))
                {
                    var customer = await _context.Customers.FindAsync(id);
                    _context.Customers.Remove(customer);
                    await _context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.IdCustomer == id);
        }

        public async Task<bool> Update(Customer customer)
        {
            try
            {
                _context.Customers.Update(customer);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(customer.IdCustomer))
                {
                    return false;
                }
            }
            return false;
        }
    }
}
