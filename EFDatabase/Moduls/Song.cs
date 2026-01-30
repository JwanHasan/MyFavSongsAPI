using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace EFDatabase.Moduls
{
    public class Song
    {
        public int Id { get; set; }
        public required string Name { get; set; }


        public int ArtistId { get; set; }
        public int AlbumsId{get; set;}

        public required Artist Artist { get; set;}

        public required Album Album { get; set;}
    }
}
