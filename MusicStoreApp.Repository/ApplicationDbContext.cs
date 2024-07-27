using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicStoreApplication.Domain.Domain;
using MusicStoreApplication.Domain.Identity;

namespace MusicStoreApp.Repository

{
    public class ApplicationDbContext : IdentityDbContext<MusicStoreUser>
    {
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
        public virtual DbSet<UserPlaylist> Playlists { get; set; }
        public virtual DbSet<TrackInPlaylist> TrackInPlaylists { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
