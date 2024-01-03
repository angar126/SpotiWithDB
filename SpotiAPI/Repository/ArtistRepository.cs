using Microsoft.Extensions.Logging;
using SpotiAPI.Models;
namespace SpotiAPI.Repository
{
    public class ArtistRepository : Repository<Artist>, IArtistRepository
    {
        public ArtistRepository(SpotifyContext context, ILogger<Repository<Artist>> logger) : base(context, logger)
        {
        }
    }
}
