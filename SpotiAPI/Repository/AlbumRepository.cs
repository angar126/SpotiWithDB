using Microsoft.Extensions.Logging;
using SpotiAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpotiAPI.Repository
{
    public class AlbumRepository : Repository<Album>, IAlbumRepository
    {
        public AlbumRepository(SpotifyContext context, ILogger<Repository<Album>> logger) : base(context, logger)
        {     
        }
        public IEnumerable<Album> GetAlls()
        {
            return _context.Albums.ToList();
        }
    }
}
