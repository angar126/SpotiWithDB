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
    [Route("api/Album")]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumRepository _albumRepository;
        private readonly ILogger<AlbumController> _logger;

        public AlbumController(IAlbumRepository albumRepository, ILogger<AlbumController> logger)
        {
            _logger = logger;
            _albumRepository = albumRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var albums = await _albumRepository.GetAllAsync();
            return Ok(albums);
        }
        //o faccio dei metodi sincroni
        [HttpGet]
        public IEnumerable<Album> GetAlls()
        {
            AlbumRepository ar = (AlbumRepository)_albumRepository;
            return ar.GetAlls() ;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Album>> Get(int id)
        {
            var album = await _albumRepository.GetByIdAsync(id);
            if (album == null)
            {
                return NotFound();
            }
            return Ok(album);
        }
        [HttpPost]
        public IActionResult Create(Album album)
        {
            _albumRepository.AddAsync(album);
            return CreatedAtAction(nameof(Get), new { id = album.AlbumId }, album);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Album album)
        {
            if (id != album.AlbumId)
                return BadRequest();

            var existingAlbum = _albumRepository.GetByIdAsync(id);
            if (existingAlbum is null)
                return NotFound();

            _albumRepository.UpdateAsync(album);

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var album = _albumRepository.GetByIdAsync(id);

            if (album is null)
                return NotFound();

            _albumRepository.DeleteAsync(album.Result);

            return NoContent();
        }
    }

}
