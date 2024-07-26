using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreApplication.Domain.Domain
{
    public class Album : BaseEntity
    {
        public string AlbumName {  get; set; }
        public string AlbumImage { get; set; }
        public Artist Artist { get; set; }
        public int Rating { get; set; }
        public string Genre { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
