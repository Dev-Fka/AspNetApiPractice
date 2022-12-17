using AspNetApiPractice.Application.Abstraction;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApiPractice.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork :IAsyncDisposable
    {
        Task<IDbContextTransaction> BeginTransactionAsync();
        public IProductRepository ProductRepository { get; }
        public IUserRepository UserRepository { get; }
    }

}

