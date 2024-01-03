using Microsoft.Extensions.Logging;
using SpotiAPI.Models;
namespace SpotiAPI.Repository
{
    public class RadioRepository : Repository<Radio>, IRadioRepository
    {
        public RadioRepository(SpotifyContext context, ILogger<Repository<Radio>> logger) : base(context, logger)
        {
        }
    }
}
