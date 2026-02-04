

using Shared.Entities;

namespace MyFavSongsAPI.Services
{
    public interface IArtistService
    {
        Task<Artist?> CreateArtistAsync ( string name);
        Task<List<Artist>> GetAllArtistAsync ();
        Task<Artist> GetArtistByIDAsync ( int id);
        Task<Artist> UpdateArtistByIdAsync (int  id, string name);
        Task<bool> DeleteArtistByIdAsync ( int id);
    }
}
