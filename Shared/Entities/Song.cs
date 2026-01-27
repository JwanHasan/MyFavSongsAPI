namespace MyFavSongsAPI.Entities
{
    public class Song
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Artist { get; set; }
    }
}
