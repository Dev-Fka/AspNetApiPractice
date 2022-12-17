using Microsoft.AspNetCore.Mvc;

namespace AspNetApiPractice.Controllers
{
    public class AccountController : ControllerBase
    {

        public AccountController()
        {

        }


        public async Task<IActionResult> CreateUser()
        {   


          return Ok(true);

        }
    }
}
