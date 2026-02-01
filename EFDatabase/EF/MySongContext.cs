using EFDatabase.Moduls;
using Microsoft.EntityFrameworkCore;


namespace EFDatabase.EF
{



    
    public class MySongContext:DbContext
    {

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source= MySongs.db");
        }

       
        
    }
}
