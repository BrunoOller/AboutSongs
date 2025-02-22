using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AboutSongs.Models;

[Table("ComentarioAlbum")]

public class ComentarioAlbum
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int AlbumId { get; set; }
    [ForeignKey("AlbumId")]
    public Album Album { get; set; }

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
