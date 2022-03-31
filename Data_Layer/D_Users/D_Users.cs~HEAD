using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entity_Layer;
using Data_Layer.Auth;

namespace Data_Layer.D_Users
{
    public class D_Users
    {
        private SASContext _context = new SASContext();
        public async Task<List<User>> GetAll()
        {
            try
            {
                return await _context.Users.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public async Task<bool> Create(User user)
        {
            try
            {
                user.Password = Encrypt.GetMD5(user.Password);
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public async Task<User> Get(int id)
        {
            try
            {
                var usuario = await _context.Users.FirstOrDefaultAsync(c => c.IdUser == id);
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

        public async Task<bool> Update(User user)
        {
            try
            {
                user.Password = Encrypt.GetMD5(user.Password);
                _context.Users.Update(user);
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
                var user = await _context.Users.FirstOrDefaultAsync(c => c.IdUser == id);
                if (user != null)
                {
                    _context.Users.Remove(user);
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
