using AboutSongs.Models;

namespace AboutSongs.ViewModels;

public class AlbumVM
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Foto { get; set; }
    public List<Musica> Musicas { get; set; }
    public List<Artista> Artistas { get; set; }
    public List<Genero> Generos { get; set; }
    public List<ComentarioAlbum> Comentarios { get; set; } = [];
}