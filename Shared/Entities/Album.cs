namespace Shared.Entities;
    

    public class Album
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string ArtistName { get; set; }
        public List<Song>? Songs { get; set; }
    }

