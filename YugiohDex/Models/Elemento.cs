using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yugiohdex.Models;

[Table("Elemento")]
public class Elemento
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o Elemento")]
    [StringLength(30, ErrorMessage = "O Elemento deve possuir no máximo 30 caracteres")]
    public string Nome { get; set; }
}
