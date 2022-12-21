using AspNetApiPractice.Application.Dtos;
using AspNetApiPractice.Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetApiPractice.Controllers
{
    [ApiController]
    [Route("/[Controller]")]
    public class AccountController : ControllerBase
    {   
        private readonly IUnitOfWork unitOfWork;
        public AccountController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDto dto)
        {

          return Ok(await unitOfWork.UserRepository.AddUserAsync(dto));

        }
    }
}
