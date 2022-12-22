using AspNetApiPractice.Application.Abstraction;
using AspNetApiPractice.Application.Validator;
using AspNetApiPractice.Domain.Dtos;
using AspNetApiPractice.Domain.Entities;
using AspNetApiPractice.Infrastructure.Context;
using AutoMapper;
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

        public IMapper mapper{ get; set; }
        public ProductRepository(AppDbContext context,IMapper mapper) : base(context)
        {
            this.context = context;

            this.mapper = mapper;
        }

        public async Task<bool> AddAsync(ProductDto dto)
        {
            ProductValidator validator= new();

            var res = validator.Validate(dto);
            if (res.IsValid)
            {
                var a = mapper.Map(dto, new Product { });

                await context.Set<Product>().AddAsync(a);
                await context.SaveChangesAsync();

                return true;
            }else
                return false;
 
        }
    }
}
