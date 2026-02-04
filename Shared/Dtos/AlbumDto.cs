using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Dtos
{
    internal class AlbumDto
    {
        public required string Name { get; set; }

        public int ArtistId { get; set; }
    }
}
