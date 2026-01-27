

namespace MyFavSongsAPI.Services
{
    public interface IArtistService
    {
        Task<Artist?> CreateArtistAsync ( Artist artist);
        Task<List<Artist>> GetAllArtistAsync ();
        Task<Artist> GetArtistByIDAsync ( int id);
        Task<Artist> UpdateArtistByIdAsync (int  id, Artist artist);
        Task<bool> DeleteArtistByIdAsync ( int id);
    }
}
