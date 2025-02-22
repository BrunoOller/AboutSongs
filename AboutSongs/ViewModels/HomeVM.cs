using AboutSongs.Models;

namespace AboutSongs.ViewModels;

public class HomeVM
{
    public List<AlbumVM> Albuns { get; set; } = [];
    public List<MusicaVM> Musicas { get; set; } = [];
}