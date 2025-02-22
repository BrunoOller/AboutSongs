using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AboutSongs.Models;
[Table("Artista")]
public class Artista
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(80, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
    public string Nome { get; set; }

    [StringLength(1000)]
    public string Biografia { get; set; }

    [DataType(DataType.Date)]
    public DateTime DataDeNascimento { get; set; }

    public ICollection<AlbumArtista> Albuns { get; set; }

    public ICollection<GeneroArtista> Generos { get; set; }
}