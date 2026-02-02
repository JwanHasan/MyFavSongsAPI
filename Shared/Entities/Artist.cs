namespace Shared.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        
        public ICollection<Song>? songs { get; set; } 
        public ICollection<Album>? albums { get; set; }
    }
}
