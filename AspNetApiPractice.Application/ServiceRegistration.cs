using AspNetApiPractice.Application.Abstraction;
using AspNetApiPractice.Application.Validator;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApiPractice.Application
{   
    public static class Application
    {

        public static void AddApplicationServices(this IServiceCollection services)
        {

            services.AddValidatorsFromAssemblyContaining<UserValidator>();

        }
    }

}
