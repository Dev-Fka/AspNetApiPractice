using AspNetApiPractice.Infrastructure.Context;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetApiPractice.Application.Abstraction;

namespace AspNetApiPractice.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;

        public IProductRepository ProductRepository { get; set; }   

        public IUserRepository UserRepository { get; set; }

        public UnitOfWork(AppDbContext context, IProductRepository productRepository, IUserRepository userRepository)
        {
            this.context = context;
            this.ProductRepository = productRepository;
            this.UserRepository = userRepository;
        }
        public async Task<IDbContextTransaction> BeginTransactionAsync() => await context.Database.BeginTransactionAsync();
        public async ValueTask DisposeAsync() { }
    }
}
