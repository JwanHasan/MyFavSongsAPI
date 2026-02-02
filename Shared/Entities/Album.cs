namespace Shared.Entities;
    

    public class Album
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string ArtistName { get; set; }
        
        public int ArtistId { get; set; }
        public required Artist Artist { get; set; }
        public required ICollection<Song> Songs { get; set; }
    }

