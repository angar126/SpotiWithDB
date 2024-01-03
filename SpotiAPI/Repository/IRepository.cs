using System.Collections.Generic;
using System.Threading.Tasks;
using SpotiAPI.Models;

namespace SpotiAPI.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
    public interface IAlbumRepository : IRepository<Album>
    {
    }
    public interface IArtistRepository : IRepository<Artist>
    {
    }
    public interface IPlaylistRepository : IRepository<Playlist>
    {
    }
    public interface IRadioRepository : IRepository<Radio>
    {
    }
    public interface ISongRepository : IRepository<Song>
    {
    }
    public interface IUserRepository : IRepository<User>
    {
    }
}
