using Microsoft.Extensions.Logging;
using SpotiAPI.Models;
namespace SpotiAPI.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(SpotifyContext context, ILogger<Repository<User>> logger) : base(context, logger)
        {
        }
    }
}
