using System;
using System.Collections.Generic;

#nullable disable

namespace SpotiAPI.Models
{
    public partial class Song
    {
        public int SongId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int? ArtistId { get; set; }
        public int? AlbumId { get; set; }
        public int? PlaylistId { get; set; }

        public virtual Album Album { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Playlist Playlist { get; set; }
    }
}
