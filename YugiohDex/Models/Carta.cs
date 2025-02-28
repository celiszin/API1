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

    [Required(ErrorMessage = "Informe O Id")]
    [StringLength(5, ErrorMessage = "O Id deve possuir no maximo 5 caracteres")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
    public string Nome { get; set; }

    [StringLength(1000)]
    public string Descricao { get; set; }

    public ICollection<Tipo_carta> TipoCartasId { get; set; }

    public List<CartaFoto> Fotos { get; set; }

}
