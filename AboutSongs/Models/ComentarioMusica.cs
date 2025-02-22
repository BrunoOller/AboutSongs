using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AboutSongs.Models;

[Table("ComentarioMusica")]

public class ComentarioMusica
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int MusicaId { get; set; }
    [ForeignKey("MusicaId")]
    public Musica Musica { get; set; }

    [Required]
    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }

    [DataType(DataType.Date)]
    [StringLength(1000)]
    public DateTime DataDePublicacao { get; set; }

    [Required]
    [StringLength(1000)]
    public string Comentario { get; set; }
}
