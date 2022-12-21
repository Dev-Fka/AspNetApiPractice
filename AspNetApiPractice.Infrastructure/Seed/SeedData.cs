using AspNetApiPractice.Domain.Entities;
using AspNetApiPractice.Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApiPractice.Infrastructure.Seed
{
    public static class SeedData
    {
        public static void SeedingData(this IServiceProvider service)
        {

            var dbContext = service.GetRequiredService<AppDbContext>();

            var manager = service.GetRequiredService<UserManager<User>>();

                dbContext.Database.Migrate();

                if (!manager.Users.Any())
                {
                    manager.CreateAsync(new User() { Email = "deneme@gmail.com", UserName = "user1", } ,"Password1*");
                }

        }

    }
}
