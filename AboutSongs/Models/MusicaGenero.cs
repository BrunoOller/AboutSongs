using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AboutSongs.Models;
[Table("MusicaGenero")]
public class MusicaGenero
{
    [Key, Column(Order = 1)]
    public int MusicaId { get; set; }
    [ForeignKey("MusicaId")]
    public Musica Musica { get; set; }

    [Key, Column(Order = 2)]
    public int GeneroId { get; set; }
    [ForeignKey("GeneroId")]
    public Genero Genero { get; set;} 

}