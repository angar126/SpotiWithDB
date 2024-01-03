using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SpotiAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpotiAPI.Models;

namespace SpotiAPI.Controllers
{
    [ApiController]
    [Route("api/Song")]
    public class SongController : ControllerBase
    {
        private readonly ISongRepository _repository;
        private readonly ILogger<SongController> _logger;

        public SongController(ISongRepository repository, ILogger<SongController> logger)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _repository.GetAllAsync();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Song>> Get(int id)
        {
            var items = await _repository.GetByIdAsync(id);
            if (items == null)
            {
                return NotFound();
            }
            return Ok(items);
        }
    }

}