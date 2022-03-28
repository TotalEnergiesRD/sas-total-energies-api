using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entity_Layer;

namespace Data_Layer.Category
{
    public class D_Category
    {
        private SASContext _context = new SASContext();
        public async Task<List<Categorium>> GetAll()
        {
            try
            {
                return await _context.Categoria.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public async Task<bool> Create(Categorium category)
        {
            try
            {
                _context.Categoria.Add(category);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public async Task<Categorium> Get(int id)
        {
            try
            {
                var category = await _context.Categoria.FirstOrDefaultAsync(c => c.IdCategoria == id);
                if (category != null)
                {
                    return category;

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

        public async Task<bool> Edit(Categorium category)
        {
            try
            {
                _context.Categoria.Update(category);
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
                var category = await _context.Categoria.FirstOrDefaultAsync(c => c.IdCategoria == id);
                if (category != null)
                {
                    _context.Categoria.Remove(category);
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
