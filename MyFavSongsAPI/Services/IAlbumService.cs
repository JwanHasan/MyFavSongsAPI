using Shared.Entities;

namespace MyFavSongsAPI.Services
{
    public interface IAlbumService
    {
        Task<Album> CreateAlbumAsync(string name, int artistId);
        
        Task<Album> UpdateAlbumAsync(int id , Album album);
        Task<Album> DeleteAlbumAsync(int id);
        Task<Album> GetAllAlbumAsync();
        Task<Album> GetAlbumByIdAsync(int id);
    }
}
