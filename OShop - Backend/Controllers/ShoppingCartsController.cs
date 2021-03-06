﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OShop___Backend.Infrastructure;
using Service.Dto;
using Service.Exceptions;
using Service.Services.Interfaces;

namespace OShop___Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShoppingCartsController : BaseApiController
    {
        private readonly IShoppingCartService _shoppingCartService;

        public ShoppingCartsController(IShoppingCartService shoppingCartService, ILogger logger) : base(logger)
        {
            _shoppingCartService = shoppingCartService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var cartDto = await _shoppingCartService.GetByID(id);
                return new JsonResult(cartDto);
            }
            catch (ShoppingCartNotFound ex)
            {
                return NotFound("Shopping cart not found");
            }
            catch (Exception ex)
            {
                Log(ex);
                return StatusCode(500);
            }
        }

        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ShoppingCartDto shoppingCartDto)
        {
            try
            {
                var saveResultDto = await _shoppingCartService.Add(shoppingCartDto);
                return Ok(saveResultDto);
            }
            catch (Exception ex)
            {
                Log(ex);
                return StatusCode(500);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ShoppingCartDto shoppingCartDto)
        {
            try
            {
                var saveResultDto = await _shoppingCartService.Update(shoppingCartDto, id);
                return Ok(saveResultDto);
            }
            catch (Exception ex)
            {
                Log(ex);
                return StatusCode(500);
            }
        }
    }
}
