using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entity_Layer;

namespace Data_Layer.D_Category
{
    public class D_Category
    {
        private SASContext _context = new SASContext();
        public async Task<List<Category>> GetAll()
        {
            try
            {
                return await _context.Categories.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public async Task<bool> Create(Category category)
        {
            try
            {
                _context.Categories.Add(category);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public async Task<Category> Get(int id)
        {
            try
            {
                var category = await _context.Categories.FirstOrDefaultAsync(c => c.IdCategory == id);
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

        public async Task<bool> Update(Category category)
        {
            try
            {
                _context.Categories.Update(category);
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
                var category = await _context.Categories.FirstOrDefaultAsync(c => c.IdCategory == id);
                if (category != null)
                {
                    category.Status = false;
                    _context.Categories.Update(category);
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
