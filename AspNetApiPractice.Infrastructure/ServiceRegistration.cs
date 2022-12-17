using AspNetApiPractice.Application.Abstraction;
using AspNetApiPractice.Domain.Entities;
using AspNetApiPractice.Infrastructure.Context;
using AspNetApiPractice.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApiPractice.Infrastructure
{
    public static class ServiceRegistration
    {
        
        public static void AddInfrastructureService(this IServiceCollection service,IConfiguration configuration)
        {
            service.AddDbContext<AppDbContext>(opt =>

            opt.UseSqlServer(configuration.GetConnectionString("ConnectionString"))

            );
            service.AddSingleton<IUserRepository, UserRepository>();
            service.AddSingleton<UserManager<User>>();
            service.AddSingleton<IProductRepository, ProductRepository>();
            
            
        }

    }
}
