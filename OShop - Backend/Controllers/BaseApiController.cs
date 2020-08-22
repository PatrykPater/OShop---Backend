using Microsoft.AspNetCore.Mvc;
using OShop___Backend.Infrastructure;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OShop___Backend.Controllers
{
    public abstract class BaseApiController : ControllerBase
    {
        private readonly ILogger _logger;

        public BaseApiController(ILogger logger) : base()
        {
            _logger = logger;
        }

        public void Log(Exception ex)
        {
            _logger.Log(ex);
        }
    }
}
