using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Services;
using Service.Services.Interfaces;

namespace OShop___Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriesController : BaseApiController
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ILogger logger, ICategoryService categoryService) : base(logger)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var categoriesDto = await _categoryService.GetAll();
                return new JsonResult(categoriesDto);
            }
            catch (Exception ex)
            {
                Log(ex);
                return StatusCode(500);
            }
        }
    }
}
