using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreApplication.Domain.Domain
{
    public class Track : BaseEntity
    {
        public string TrackName { get; set; }
        public int Rating { get; set; } 
        public Album Album { get; set; }

    }
}
