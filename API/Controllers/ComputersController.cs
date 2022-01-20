using API.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputersController : ControllerBase
    {
        private readonly ComputerService computerService;

        public ComputersController(ComputerService computerService)
        {
            this.computerService = computerService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(computerService.GetComputers());
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute]Guid id)
        {
            var pc = computerService.GetComputerById(id);
            if (pc == null)
                return BadRequest();
            return Ok(pc);
        }
    }
}
