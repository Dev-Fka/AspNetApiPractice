using AspNetApiPractice.Application.Abstraction;
using AspNetApiPractice.Domain.Entities;
using AspNetApiPractice.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApiPractice.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>,IProductRepository
    {
        public AppDbContext context;
        public ProductRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }

    }
}
