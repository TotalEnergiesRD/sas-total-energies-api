using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Layer;
using Microsoft.EntityFrameworkCore;

namespace Data_Layer.Clients
{
    public class D_Clients
    {
        private SASContext _context = new SASContext();
        public async Task<List<Cliente>> GetAll()
        {
            try
            {
                return await _context.Clientes.ToListAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return new List<Cliente>();
            }
        }

        public async Task<Cliente> Get(int? id)
        {
            var client = await _context.Clientes
                .FirstOrDefaultAsync(m => m.IdCliente == id);
            if (client == null)
            {
                return client;
            }

            return client;
        }


        public async Task<bool> Create(Cliente cliente)
        {
            try
            {
                _context.Clientes.Add(cliente);
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
                if (ClientExists(id))
                {
                    var client = await _context.Clientes.FindAsync(id);
                    _context.Clientes.Remove(client);
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

        private bool ClientExists(int id)
        {
            return _context.Clientes.Any(e => e.IdCliente == id);
        }

        public async Task<bool> Update(Cliente client)
        {
            try
            {
                _context.Clientes.Update(client);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(client.IdCliente))
                {
                    return false;
                }
            }
            return false;
        }
    }
}
