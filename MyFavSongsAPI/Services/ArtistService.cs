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

        public async Task<Artist> UpdateArtistByIdAsync(int id, Artist artist)
        {
            var result = await _service.Artists.FirstOrDefaultAsync(x => x.Id == id);
            if (result != null)
            {
                result.Name = artist.Name;
                result.songs = artist.songs;
                result.albums = artist.albums;
                await _service.SaveChangesAsync();
            }
            else throw new Exception($"the artist with id: {id} is not found ");

            return await  Task.FromResult(result);
        }

        public async Task<bool> DeleteArtistByIdAsync(int id)
        {
           
            var artist = await _service.Artists.FindAsync(id);

            if (artist == null)
                return false;

            _service.Artists.Remove(artist);
            await _service.SaveChangesAsync();

            return true;
        }

    
    }
}
