using AutoMapper;
using EduSys.Core.DTOs;
using EduSys.Core.Models;
using EduSys.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduSys.API.Controllers
{

    public class ProductsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Product> _service;
        private readonly IProductService _productService;

        public ProductsController(IMapper mapper, IService<Product> service, IProductService productService)
        {
            _mapper = mapper;
            _service = service;
            _productService = productService;   

        }

        [HttpGet] 
        public async Task<IActionResult> All() 
        {
            var products = await _service.GetAllAsync();
            
            var productsDtos = _mapper.Map<List<ProductDto>>(products.ToList());

            return CreateActionResult (CustomResponseDTO<List<ProductDto>>.Success(200, productsDtos));
        }

        [HttpGet("{id}")] // www.proqramlasdirmakurslari.az/api/Products/5 (example url)
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _service.GetByIdAsync(id);

            var productsDto = _mapper.Map<ProductDto>(product);

            return CreateActionResult(CustomResponseDTO<ProductDto>.Success(200, productsDto));
        }


        [HttpPost]
        public async Task<IActionResult> Save(ProductDto productDto)
        {
            var product = await _service.AddAsync(_mapper.Map<Product>(productDto));

            var productsDto = _mapper.Map<ProductDto>(product);

            return CreateActionResult(CustomResponseDTO<ProductDto>.Success(200, productsDto));
        }


        [HttpPut]
        public async Task<IActionResult> Update(ProductDto productDto)
        {
            await _service.UpdateAsync(_mapper.Map<Product>(productDto));

            return CreateActionResult(CustomResponseDTO<NoContentDTO>.Success(204));
        }


        [HttpDelete] // www.proqramlasdirmakurslari.az/api/Products/5 (Example request url)
        public async Task<IActionResult> Remove(int id)
        {
            var product = await _service.GetByIdAsync(id);

            if (product == null) // Silenecek. Bu Hisse
            {
                return CreateActionResult(CustomResponseDTO<NoContentDTO>.Fail(404, "Bu id Netice tapilmadi"));
            }

            await _service.RemoveAsync(product);
            return CreateActionResult(CustomResponseDTO<NoContentDTO>.Success(204));
        }

        //GET/Api/Products/GetProductsWithCategory
        [HttpGet("[action]")]  

        public async Task<IActionResult> GetProductWithCategory()
        {
            var productsWithCategory = await _productService.GetProductWithCategory();
            return CreateActionResult(productsWithCategory);
        }
    }
}
