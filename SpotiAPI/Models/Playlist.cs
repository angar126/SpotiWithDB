using System;
using System.Collections.Generic;

#nullable disable

namespace SpotiAPI.Models
{
    public partial class Playlist
    {
        public Playlist()
        {
            Radios = new HashSet<Radio>();
            Songs = new HashSet<Song>();
        }

        public int PlaylistId { get; set; }
        public string Name { get; set; }
        public int? Rating { get; set; }

        public virtual ICollection<Radio> Radios { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
