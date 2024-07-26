using MusicStoreApplication.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreApplication.Domain.Domain
{
    public class UserPlaylist : BaseEntity
    {
        public string userId { get; set; }
        public MusicStoreUser Owner { get; set; }
        public virtual ICollection<TrackInPlaylist> TracksInPlaylist { get; set; }
    }
}
