using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Entity_Layer;
using Microsoft.EntityFrameworkCore;

namespace Data_Layer.D_Cases
{
    public class D_Cases
    {
        private SASContext _context = new SASContext();
        public async Task<List<CasesView>> GetAll()
        {
            try
            {
                return await _context.CasesViews.ToListAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return new List<CasesView>();
            }
        }


        public async Task<List<CasesTodayView>> GetToday()
        {
            try
            {
                return await _context.CasesTodayViews.ToListAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return new List<CasesTodayView>();
            }
        }

        public async Task<CasesView> Get(string? id)
        {
            var cases = await _context.CasesViews
                .FirstOrDefaultAsync(m => m.Code == id);
            if (cases == null)
            {
                return cases;
            }

            return cases;
        }


        public async Task<bool> Create(Case cases)
        {
            try
            {
                _context.Cases.Add(cases);
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
                if (CaseExists(id))
                {
                    var cases = await _context.Cases.FindAsync(id);
                    _context.Cases.Remove(cases);
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
            return _context.Cases.Any(e => e.IdCases == id);
        }

        public async Task<bool> Update(Case cases)
        {
            try
            {
                _context.Cases.Update(cases);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CaseExists(cases.IdCases))
                {
                    return false;
                }
            }
            return false;
        }

        //private string Code()
        //{
        //    string code = Codegenerator();
        //    while (CodeExists(code))
        //    {
        //        code = Codegenerator();
        //    }
        //    return code;
        //}

        //private string Codegenerator() 
        //{
        //    StringBuilder codigo = new StringBuilder();
        //    codigo.Append("CA");
        //    Random random = new Random();
        //    codigo.Append(random.Next(100000, 999999));
        //    return codigo.ToString();
        //}



        //private bool CodeExists(string caso)
        //{
        //    return _context.Casos.Any(e => e.Codigo == caso);
        //}


    }
}

