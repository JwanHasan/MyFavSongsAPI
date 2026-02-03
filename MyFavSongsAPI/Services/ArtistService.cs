using Microsoft.AspNetCore.Http.HttpResults;
using Shared.Entities;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using EFDatabase.EF;
using Microsoft.EntityFrameworkCore;

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

        public async Task<List<Artist>> GetAllArtistAsync()
        {
            var list =  await _service.Artists.ToListAsync();
            return list;
        }

        public async Task<Artist> GetArtistByIDAsync(int id)
        {
            var result= await _service.Artists.FirstOrDefaultAsync(x => x.Id == id);
            if (result == null)
                throw new Exception($"the artist with id: {id} is not found ");
            return  result;
        }

        public Task<Artist> UpdateArtistByIdAsync(int id, Artist artist)
        {
            
        }

        public Task<bool> DeleteArtistByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
