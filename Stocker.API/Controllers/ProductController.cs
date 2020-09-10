using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Stocker.API.DTO;
using Stocker.Application.Interfaces;
using Stocker.Domain;

namespace Stocker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            this._productService = productService;
            this._mapper = mapper;
        }

        [HttpGet("{excludehighstock:bool?}")]
        public async Task<IActionResult> Get(bool excludehighstock)
        {
            return new OkObjectResult(await _productService.Get(excludehighstock));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return new OkObjectResult(await _productService.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ProductDTO productDTO)
        {
            await _productService.Add(_mapper.Map<Product>(productDTO));
            return new OkObjectResult(true);
        }

        [HttpPut]
        public IActionResult Update([FromBody] ProductDTO productDTO)
        {
            _productService.Update(_mapper.Map<Product>(productDTO));
            return new OkObjectResult(true);
        }

        [HttpPut("UpdateAll")]
        public async Task<IActionResult> UpdateAll([FromBody] ProductsArrayDTO productsDTO)
        {
            await _productService.UpdateAll(_mapper.Map<List<Product>>(productsDTO.Product));
            return new OkObjectResult(true);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _productService.Delete(id);
            return new OkObjectResult(true);
        }
    }
}