using AspNetApiPractice.Domain.Dtos;
using AspNetApiPractice.Domain.Entities;
using AspNetApiPractice.Infrastructure.UnitOfWork;
using AutoMapper;
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
        public IMapper mapper;
        public ProductController(IUnitOfWork unitOfWork, ILogger<ProductController> logger,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _logger = logger;
            this.mapper= mapper;
        }

        [HttpGet()]
        public async Task<IActionResult> GetProducts()
        {
            _logger.LogError("Ürünler Sorgulandı.");

            return Ok(await unitOfWork.ProductRepository.GetAllAsync());
        }

        [HttpPost("/add")]
        public async Task<IActionResult> AddProduct(ProductDto dto)
        {
            return Ok(await unitOfWork.ProductRepository.AddAsync(dto));
        }
    }
}
