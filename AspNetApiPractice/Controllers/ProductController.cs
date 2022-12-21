using AspNetApiPractice.Domain.Entities;
using AspNetApiPractice.Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetApiPractice.Controllers
{
    [ApiController]
    [Route("/api/[Controller]")]
    [Authorize(Roles="Admin")]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ILogger<ProductController> _logger;
        public ProductController(IUnitOfWork unitOfWork, ILogger<ProductController> logger)
        {
            this.unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet()]
        public async Task<IActionResult> Deneme()
        {
            _logger.LogError("Ürünler Sorgulandı.");

            return Ok(await unitOfWork.ProductRepository.GetAllAsync());
        }
    }
}
