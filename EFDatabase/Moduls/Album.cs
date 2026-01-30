using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFDatabase.Moduls
{
    public class Album
    {
        public int Id { get; set; }
        
        public required string Name { get; set; }

        public int ArtistId { get; set; }
        public required Artist Artist { get; set; }
        public required ICollection<Song> Songs { get; set; } 
    }
}
