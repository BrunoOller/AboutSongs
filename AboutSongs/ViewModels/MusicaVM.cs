using AboutSongs.Models;

namespace AboutSongs.ViewModels;

public class MusicaVM
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Foto { get; set; }
    public string Spotify { get; set; }
    public string AppleMusic { get; set; }
    public string Youtube { get; set; }
    public List<Album> Albuns { get; set; }
    public List<Artista> Artistas { get; set; }
    public List<Genero> Generos { get; set; }
    public List<ComentarioMusica> Comentarios { get; set; } = [];
}