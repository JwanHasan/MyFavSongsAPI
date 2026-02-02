using Microsoft.AspNetCore.Http.HttpResults;
using Shared.Entities;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using EFDatabase.EF;

namespace MyFavSongsAPI.Services
{
     
    public class ArtistService: IArtistService

    {
        private  MySongContext _service;
        

        public ArtistService(MySongContext context)
        {
            _service = context;
        }
        public async Task<Artist?> CreateArtistAsync(Artist artist)
        {
           await _service.Artists.AddAsync(new Artist() { Name = artist.Name });
           await _service.SaveChangesAsync();
           return artist;
        }

        public Task<List<Artist>> GetAllArtistAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Artist> GetArtistByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Artist> UpdateArtistByIdAsync(int id, Artist artist)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteArtistByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
