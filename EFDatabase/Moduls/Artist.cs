using System;
using System.Collections.Generic;
using System.Text;

namespace EFDatabase.Moduls
{
    public class Artist
    {
        public int Id { get; set; }
        public required string Name { get; set; }


        public ICollection<Song>? songs { get; set; } 
        public ICollection<Album>? albums { get; set; }

    }
}
