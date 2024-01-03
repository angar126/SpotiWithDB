using Microsoft.Extensions.Logging;
using SpotiAPI.Models;
namespace SpotiAPI.Repository
{
    public class PlaylistRepository : Repository<Playlist>, IPlaylistRepository
    {
        public PlaylistRepository(SpotifyContext context, ILogger<Repository<Playlist>> logger) : base(context, logger)
        {
        }
    }
}
