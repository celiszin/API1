using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YugiohDex.Models
{
    [Table("Tipo")]
    public class Tipo_Cartas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Carta_Id { get; set; }

        [Required(ErrorMessage = "Por Favor, Informe O Nome Do Tipo Da Carta")]
        [StringLength(30, ErrorMessage = "O Tipo Da Carta Deve Possuir No Maximo 30 Caracteres")]
        public string Carta_Nome { get; set; }

        [Required(ErrorMessage = "Por Favor, Informe a cor")]
        [StringLength(20, ErrorMessage = "A Cor Deve Possuir No Maximo 20 Caracteres")]
        public string Cor { get; set; }

        public ICollection<Yugioh> Yugiohs {get; set; }
    }
}