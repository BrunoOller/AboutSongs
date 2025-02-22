using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AboutSongs.Models;
[Table("GeneroArtista")]
public class GeneroArtista
{
    [Key, Column(Order = 1)]
    public int GeneroId { get; set; }
    [ForeignKey("GeneroId")]
    public Genero Genero { get; set; }

    [Key, Column(Order = 2)]
    public int ArtistaId { get; set; }
    [ForeignKey("ArtistaId")]
    public Artista Artista { get; set; }
}