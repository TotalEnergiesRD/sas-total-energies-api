using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entity_Layer;

namespace Data_Layer.N_CaseType
{
    public class D_CaseType
    {
        private SASContext _context = new SASContext();
        public async Task<List<CaseType>> GetAll()
        {
            try
            {
                return await _context.CaseTypes.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public async Task<bool> Create(CaseType caseType)
        {
            try
            {
                _context.CaseTypes.Add(caseType);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public async Task<CaseType> Get(int id)
        {
            try
            {
                var category = await _context.CaseTypes.FirstOrDefaultAsync(c => c.IdCaseType == id);
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

        public async Task<bool> Update(CaseType caseType)
        {
            try
            {
                _context.CaseTypes.Update(caseType);
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
                var caseType = await _context.CaseTypes.FirstOrDefaultAsync(c => c.IdCaseType == id);
                if (caseType != null)
                {
                    caseType.Status = false;
                    _context.CaseTypes.Update(caseType);
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
