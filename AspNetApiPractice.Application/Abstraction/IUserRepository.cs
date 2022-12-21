using AspNetApiPractice.Application.Dtos;
using AspNetApiPractice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApiPractice.Application.Abstraction
{
    public interface IUserRepository : IRepository<User>
    {

        Task<bool> AddUserAsync(CreateUserDto dto);
        Task<bool> Login(string mail, string pass);
    }
}
