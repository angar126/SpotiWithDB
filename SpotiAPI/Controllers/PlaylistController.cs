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
    [Route("api/Playlist")]
    public class PlaylistController : ControllerBase
    {
        private readonly IPlaylistRepository _repository;
        private readonly ILogger<PlaylistController> _logger;

        public PlaylistController(IPlaylistRepository repository, ILogger<PlaylistController> logger)
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
        public async Task<ActionResult<Playlist>> Get(int id)
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