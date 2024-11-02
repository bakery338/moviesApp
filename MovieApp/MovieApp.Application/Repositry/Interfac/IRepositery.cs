using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Repositry.Interfac
{
    public interface IRepositery<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task <T> GetByIdAsync(int id);
        Task <T> AddAsync(T entity);
        Task <T> UpdateAsync(T entity);
        Task  DeleteAsync(int id);
       
    }
}
