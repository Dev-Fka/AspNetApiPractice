using AspNetApiPractice.Application.Abstraction;
using AspNetApiPractice.Domain.Entities;
using AspNetApiPractice.Infrastructure.Context;
using AspNetApiPractice.Infrastructure.Repositories;
using AspNetApiPractice.Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
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

            opt.UseSqlServer(configuration["ConnectionString"])

            );

            service.AddTransient<IUserRepository, UserRepository>();
            service.AddTransient<UserManager<User>>();
            service.AddTransient<IProductRepository, ProductRepository>();
            service.AddTransient<IUnitOfWork, UnitOfWork.UnitOfWork>();
            service.AddTransient<AppDbContext>();
            service.AddIdentity<User,Roles>(opt =>
            {
                opt.User.RequireUniqueEmail = true;
            
            }).AddEntityFrameworkStores<AppDbContext>();
        }

    }
}
