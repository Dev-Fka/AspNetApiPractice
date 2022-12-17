using AspNetApiPractice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApiPractice.Application.Abstraction
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
