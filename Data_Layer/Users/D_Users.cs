using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entity_Layer;

namespace Data_Layer.Users
{
    public class D_Users
    {
        private SASContext _context = new SASContext();
        public async Task<List<Usuario>> GetAll()
        {
            try
            {
                return await _context.Usuarios.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public async Task<bool> Create(Usuario usuario)
        {
            try
            {
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public async Task<Usuario> Get(int id)
        {
            try
            {
                var usuario = await _context.Usuarios.FirstOrDefaultAsync(c => c.IdUsuario == id);
                if (usuario != null)
                {
                    return usuario;

                }
                else
                {
                    return null;
                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<bool> Update(Usuario usuario)
        {
            try
            {
                _context.Usuarios.Update(usuario);
                _context.SaveChanges();
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
                var usuario = await _context.Usuarios.FirstOrDefaultAsync(c => c.IdUsuario == id);
                if (usuario != null)
                {
                    _context.Usuarios.Remove(usuario);
                    await _context.SaveChangesAsync();

                }
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
    }
}
