using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YugiohDex.Models;

namespace Yugiohdex.Models;

[Table("Carta")]
public class Carta
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Numero { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
    public string Nome { get; set; }

    [StringLength(1000)]
    public string Descricao { get; set; }

    [Required]
    [Column(TypeName = "decimal(7,3)")]
    public decimal Imagem { get; set; }

    [StringLength(400)]
    public string Animacao { get; set; }

    public ICollection<Tipo_carta> tipo_cartas_id { get; set; }

}
