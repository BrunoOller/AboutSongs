using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AboutSongs.Models;
[Table("AlbumGenero")]
public class AlbumGenero
{
    [Key, Column(Order = 1)]
    public int AlbumId { get; set; }
    [ForeignKey("AlbumId")]
    public Album Album  { get; set; }

    [Key, Column(Order = 2)]
    public int GeneroId { get; set; }
    [ForeignKey("GeneroId")]
    public Genero Genero { get; set;}
 
}
