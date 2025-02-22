using AboutSongs.ViewModels;

namespace AboutSongs.Services;
public interface IMusicService
{
    List<AlbumVM> GetAlbuns();
    AlbumVM GetAlbum(int id);
    List<MusicaVM> GetMusicas();
    MusicaVM GetMusica(int id);
}