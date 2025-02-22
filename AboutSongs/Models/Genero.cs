using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AboutSongs.Models;
[Table("Genero")]
public class Genero
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, Informe o Nome")]
    public string Nome { get; set; }
    public ICollection<GeneroArtista> Artistas { get; set; }
    public ICollection<MusicaGenero> Musicas { get; set; }
    public ICollection<AlbumGenero> Albuns { get; set; }
}