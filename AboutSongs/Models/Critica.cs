using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AboutSongs.Models;
[Table("Critica")]
public class Critica
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int Nota { get; set; }

    [StringLength(1000)]
    public string Comentario { get; set; }

    [DataType(DataType.Date)]
    public DateTime DataDePublicacao { get; set; }

}