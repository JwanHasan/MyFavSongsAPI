using EFDatabase.Moduls;
using Microsoft.EntityFrameworkCore;


namespace EFDatabase.EF
{
    
    public class MySongContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source = MySongs.db");
        }

        DbSet<Artist> Artists => Set<Artist>();
        DbSet<Song> Songs => Set<Song>();
        DbSet<Album>  Albums => Set<Album>();

    }
}
