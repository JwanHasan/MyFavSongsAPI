using Shared.Entities;

namespace MyFavSongsAPI.Services
{
    public class AlbumService : IAlbumService
    {
        public Task<Album> CreateAlbumAsync(string name, int artistId)
        {
            throw new NotImplementedException();
        }

        public Task<Album> DeleteAlbumAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Album> GetAlbumByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Album> GetAllAlbumAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Album> UpdateAlbumAsync(int id, Album album)
        {
            throw new NotImplementedException();
        }
    }
}
