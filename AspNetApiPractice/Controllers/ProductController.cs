using AspNetApiPractice.Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace AspNetApiPractice.Controllers
{
    [ApiController]
    [Route("/api/[Controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet()]
        public async Task<IActionResult> Deneme()
        {
            return Ok(await unitOfWork.ProductRepository.GetAllAsync());
        }
    }
}
