using MusicStoreApp.Service.Interface;
using MusicStoreApplication.Domain.Domain;
using MusicStoreApplication.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreApp.Service.Implementation
{
    public class PlaylistService : IPlaylistService
    {
        private readonly IPlaylistRepository _playlistRepository;

        public PlaylistService(IPlaylistRepository playlistRepository)
        {
            _playlistRepository = playlistRepository;
        }

        public List<UserPlaylist> GetAllPlaylists()
        {
            return _playlistRepository.GetAllPlaylists();
        }

        public UserPlaylist GetDetailsForPlaylist(BaseEntity id)
        {
            return _playlistRepository.GetDetailsForPlaylist(id);
        }
    }
}
