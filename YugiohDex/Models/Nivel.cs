using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yugiohdex.Models;

[Table("Nivel")]
public class Nivel
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o nome")]
    [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
    public string Nome { get; set; }
}
