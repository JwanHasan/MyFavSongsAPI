using Microsoft.EntityFrameworkCore;

namespace MyFavSongsAPI.EF
{
    public class MySongContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source = MySongs.db");
        }
    }
}
