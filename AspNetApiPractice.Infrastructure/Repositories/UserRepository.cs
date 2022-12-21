using AspNetApiPractice.Application.Abstraction;
using AspNetApiPractice.Application.Dtos;
using AspNetApiPractice.Application.Validator;
using AspNetApiPractice.Domain.Entities;
using AspNetApiPractice.Infrastructure.Context;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApiPractice.Infrastructure.Repositories
{
    public class UserRepository : Repository<User> ,IUserRepository
    {   
        private UserManager<User> UserManager { get; set; }
       // private SignInManager<User> signInManager { get; set; }

        public AppDbContext context;
        public UserRepository(AppDbContext context, UserManager<User> userManager) :base(context) {
            this.context = context;
            this.UserManager = userManager;
            //this.signInManager = signInManager;
            
        }

        public async Task<bool> AddUserAsync(CreateUserDto dto)
        {

            UserValidator validator = new();

            var result = validator.Validate(dto);

            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    Console.WriteLine(error.ToString());
                }

                return result.IsValid;
            }

            User newUser = new()
            {
                Email = dto.Email,
                UserName = dto.Email
            };

            var resNewUser = await UserManager.CreateAsync(newUser,dto.Password);

            return resNewUser.Succeeded;
        }

    }
}
