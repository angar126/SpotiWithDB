using System;
using System.Collections.Generic;

#nullable disable

namespace SpotiAPI.Models
{
    public partial class Radio
    {
        public int RadioId { get; set; }
        public string Name { get; set; }
        public int? Rating { get; set; }
        public int? PlaylistId { get; set; }

        public virtual Playlist Playlist { get; set; }
    }
}
