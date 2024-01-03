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
    [Route("api/Artist")]
    public class ArtistController : ControllerBase
    {
        private readonly IArtistRepository _artistRepository;
        private readonly ILogger<ArtistController> _logger;

        public ArtistController(IArtistRepository artistRepository, ILogger<ArtistController> logger)
        {
            _logger = logger;
            _artistRepository = artistRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var artists = await _artistRepository.GetAllAsync();
            return Ok(artists);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Artist>> Get(int id)
        {
            var artists = await _artistRepository.GetByIdAsync(id);
            if (artists == null)
            {
                return NotFound();
            }
            return Ok(artists);
        }
    }

}
