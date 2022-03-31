using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entity_Layer;

namespace Data_Layer.D_Details
{
    public class D_Details
    {
        private SASContext _context = new SASContext();
        public async Task<List<Detail>> GetAll()
        {
            try
            {
                return await _context.Details.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public async Task<bool> Create(Detail detail)
        {
            try
            {
                _context.Details.Add(detail);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public async Task<Detail> Get(int id)
        {
            try
            {
                var detail = await _context.Details.FirstOrDefaultAsync(c => c.IdDetails == id);
                if (detail != null)
                {
                    return detail;

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

        public async Task<bool> Update(Detail detail)
        {
            try
            {
                _context.Details.Update(detail);
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
                var detail = await _context.Details.FirstOrDefaultAsync(c => c.IdDetails == id);
                if (detail != null)
                {
                    detail.Status = false;
                    _context.Details.Update(detail);
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
