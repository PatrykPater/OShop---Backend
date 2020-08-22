using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Domain.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OShop___Backend.Infrastructure;
using Service.Dto;
using Service.Services.Interfaces;

namespace OShop___Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : BaseApiController
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService, ILogger logger) : base(logger)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var productsDto = await  _productService.GetAll();
                return new JsonResult(productsDto);
            }
            catch (Exception ex)
            {
                Log(ex);
                return StatusCode(500);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var productDto = await _productService.GetByID(id);
                return new JsonResult(productDto);
            }
            catch(ProductNotFound ex)
            {
                return NotFound("Product not found");
            }
            catch (Exception ex)
            {
                Log(ex);
                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductDto productDto)
        {
            try
            {
                var saveResultDto = await _productService.Add(productDto);
                return Ok(saveResultDto);
            }
            catch (Exception ex)
            {
                Log(ex);
                return StatusCode(500);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ProductDto productDto)
        {
            try
            {
                var saveResultDto = await _productService.Update(productDto, id);
                return Ok(saveResultDto);
            }
            catch (Exception ex)
            {
                Log(ex);
                return StatusCode(500);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _productService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                Log(ex);
                return StatusCode(500);
            }
        }
    }
}
