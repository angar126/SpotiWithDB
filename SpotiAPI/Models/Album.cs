﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SpotiAPI.Models
{
    public partial class Album
    {
        public Album()
        {
            Songs = new HashSet<Song>();
        }

        public int AlbumId { get; set; }
        public string Name { get; set; }
        public int? Rating { get; set; }
        public int? ArtistId { get; set; }
        public string Genre { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
