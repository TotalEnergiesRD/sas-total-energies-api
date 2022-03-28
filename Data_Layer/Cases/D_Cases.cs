using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Entity_Layer;
using Microsoft.EntityFrameworkCore;

namespace Data_Layer.Cases
{
    public class D_Cases
    {
        private SASContext _context = new SASContext();
        public async Task<List<Caso>> GetAll()
        {
            try
            {
                return await _context.Casos.ToListAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return new List<Caso>();
            }
        }

        public async Task<Caso> Get(int? id)
        {
            var caso = await _context.Casos
                .FirstOrDefaultAsync(m => m.IdCaso == id);
            if (caso == null)
            {
                return caso;
            }

            return caso;
        }


        public async Task<bool> Create(Caso casos)
        {
            try
            {
                _context.Add(casos);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                if (CaseExists(id))
                {
                    var caso = await _context.Casos.FindAsync(id);
                    _context.Casos.Remove(caso);
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

        private bool CaseExists(int id)
        {
            return _context.Casos.Any(e => e.IdCaso == id);
        }

        public async Task<bool> Update(Caso caso)
        {
            try
            {
                _context.Update(caso);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CaseExists(caso.IdCaso))
                {
                    return false;
                }
            }
            return false;
        }


    }
}

