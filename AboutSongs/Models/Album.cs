using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace AboutSongs.Models;
[Table("Album")]
public class Album
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Nome { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Título")]
    [StringLength(100)]
    public string Titulo { get; set; }

    [StringLength(100)]
    public string Foto { get; set; }

    [DataType(DataType.Date)]
    public DateTime DataDeLancamento { get; set; }

    public bool ExibirHome { get; set; } = false;

    public ICollection<AlbumArtista> Artistas { get; set; }
    public ICollection<AlbumGenero> Generos { get; set; }
    public ICollection<ComentarioAlbum> Comentarios { get; set; }
    
}