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


        public async Task<bool> Create(Caso casoss)
        {
            try
            {
                _context.Casos.Add(casoss);
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

        private bool CaseExists(int id)
        {
            return _context.Casos.Any(e => e.IdCaso == id);
        }

        public async Task<bool> Update(Caso caso)
        {
            try
            {
                _context.Casos.Update(caso);
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

