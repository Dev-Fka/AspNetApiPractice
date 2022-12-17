using AspNetApiPractice.Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetApiPractice.Controllers
{
    public class AccountController : ControllerBase
    {   
        private readonly IUnitOfWork unitOfWork;
        public AccountController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> CreateUser([FromBody] string mail,string password)
        {

          return Ok(await unitOfWork.UserRepository.AddUserAsync(mail, password));

        }
    }
}
