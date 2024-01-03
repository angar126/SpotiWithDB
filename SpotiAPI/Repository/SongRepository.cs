using Microsoft.Extensions.Logging;
using SpotiAPI.Models;
namespace SpotiAPI.Repository
{
    public class SongRepository : Repository<Song>, ISongRepository
    {
        public SongRepository(SpotifyContext context, ILogger<Repository<Song>> logger) : base(context, logger)
        {
        }
    }
}
