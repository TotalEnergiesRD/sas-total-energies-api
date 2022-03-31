using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entity_Layer;

namespace Data_Layer.D_SubCategory
{
    public class D_SubCategory
    {
        private SASContext _context = new SASContext();
        public async Task<List<SubCategory>> GetAll()
        {
            try
            {
                return await _context.SubCategories.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public async Task<bool> Create(SubCategory subCategory)
        {
            try
            {
                _context.SubCategories.Add(subCategory);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public async Task<SubCategory> Get(int id)
        {
            try
            {
                var subCategory = await _context.SubCategories.FirstOrDefaultAsync(c => c.IdSubCategory == id);
                if (subCategory != null)
                {
                    return subCategory;

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

        public async Task<bool> Update(SubCategory subCategory)
        {
            try
            {
                _context.SubCategories.Update(subCategory);
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
                var subCategory = await _context.SubCategories.FirstOrDefaultAsync(c => c.IdSubCategory == id);
                if (subCategory != null)
                {
                    subCategory.Status = false;
                    _context.SubCategories.Update(subCategory);
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
