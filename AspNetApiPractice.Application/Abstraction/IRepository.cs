using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApiPractice.Application.Abstraction
{
    public interface IRepository<T> where T: class ,new()
    {

        Task<T?> GetByIdAsync(Guid id);
        Task<T?> GetByNameAsync(string name);
        Task<bool> AddAsync(T entity);
    }
}
