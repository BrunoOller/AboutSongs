using System.ComponentModel.DataAnnotations;

namespace AboutSongs.ViewModels;

public class ComentarioVM
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string Comentario { get; set; }
}
