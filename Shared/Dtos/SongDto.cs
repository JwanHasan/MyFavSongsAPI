using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Dtos
{
    public class SongDto
    {
        public required string Name { get; set; }

        public int ArtistId { get; set; }
        public int AlbumsId { get; set; }


    }
}
