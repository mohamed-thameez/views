using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebApplication1.Models
{
    public class CRUD<D,C> where D : DbContext where C : class
    {
        private D _db;
        public CRUD(D db)
        {
            _db = db;
        }

        public async Task<IQueryable<C>> GetAll()
        {
            try {
                return _db.Set<C>().AsNoTracking();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public async Task<C> GetById<U>(U id)
        {
            try
            {
                return await _db.Set<C>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<int> Create(C model)
        {
            try
            {
                _db.Set<C>().Add(model);
                return await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<int> Update<U>(C model, U id)
        {
            int result = 0;
            try
            {
                var exist = await _db.Set<C>().FindAsync(id);
                if (exist != null)
                {
                    _db.Entry(exist).CurrentValues.SetValues(model);
                    return await _db.SaveChangesAsync();
                }
                else
                    return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<int> Delete(C model) 
        {
            try {
                _db.Set<C>().Remove(model);
                return await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}