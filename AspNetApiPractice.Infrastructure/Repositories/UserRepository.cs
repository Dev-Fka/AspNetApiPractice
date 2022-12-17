using AspNetApiPractice.Application.Abstraction;
using AspNetApiPractice.Application.Validator;
using AspNetApiPractice.Domain.Entities;
using AspNetApiPractice.Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
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
        private SignInManager<User> signInManager { get; set; }

        public AppDbContext context;
        public UserRepository(AppDbContext context, UserManager<User> userManager, SignInManager<User> signInManager) :base(context) {
            this.context = context;
            this.UserManager = userManager;
            this.signInManager = signInManager;
            
        }

        public async Task<bool> AddUserAsync(string mail ,string passWord)
        {

            User newUser = new()
            {
                Email= mail
            };

            UserValidator validator = new();

            var result = validator.Validate(newUser);

            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    // Log.txt dosyasına yazılacak.
                }

                return result.IsValid;
            }

            var resNewUser = await UserManager.CreateAsync(newUser,passWord);

            return resNewUser.Succeeded;
        }

    }
}
