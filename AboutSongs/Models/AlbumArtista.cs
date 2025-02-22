using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AboutSongs.Models;
[Table("AlbumArtista")]
public class AlbumArtista
{
    [Key, Column(Order = 1)]
    public int AlbumId { get; set; }
    [ForeignKey("AlbumId")]
    public Album Album { get; set; }

    [Key, Column(Order = 2)]
    public int ArtistaId { get; set; }
    [ForeignKey("ArtistaId")]
    public Artista Artista { get; set; }

    [Key, Column(Order = 3)]
    public int MusicaId { get; set; }
    [ForeignKey("MusicaId")]
    public Musica Musica { get; set; }
}