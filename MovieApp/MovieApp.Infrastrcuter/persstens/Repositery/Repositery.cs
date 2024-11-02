using Microsoft.EntityFrameworkCore;
using MovieApp.Application.Repositry.Interfac;
using MovieSystem.Domain.Entites.ApplicationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Infrastrcuter.persstens.Repositery
{
    public class Repositery<T> : IRepositery<T> where T : class
    {
        private readonly ApplicationContext _context;
        private readonly DbSet<T> _dbset;

        public Repositery(ApplicationContext context)
        {
            _context = context;
            _dbset = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbset.FindAsync(id);
        }
        public async Task<T> AddAsync(T entity)
        {
            await _dbset.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<T> UpdateAsync(T entity)
        {
            _dbset.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteAsync(int id)
        {
            var result = await GetByIdAsync(id);
            if (result != null)
            {
                _dbset.Remove(result);
                await _context.SaveChangesAsync();
            }

        }



    }
}
