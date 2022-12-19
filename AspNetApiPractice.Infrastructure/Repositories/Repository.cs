using AspNetApiPractice.Application.Abstraction;
using AspNetApiPractice.Domain.Entities;
using AspNetApiPractice.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApiPractice.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext context;

        public Repository(AppDbContext dbContext)
        {
            this.context = dbContext;
        }

        public async Task<bool> AddAsync(T entity)
        {
            context.Set<T>().Add(entity);

            await context.SaveChangesAsync();

            return true;
        }


        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await context.FindAsync<T>(id);
        }

        public async Task<T?> GetByNameAsync(string name)
        {
            return await context.FindAsync<T>(name);

        }

        public async Task<List<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();

        }
    }
}
