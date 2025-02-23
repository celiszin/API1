using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Yugiohdex.Models;

namespace YugiohDex.Models
{
    [Table("Tipo")]
    public class Tipo_carta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a cor")]
        [StringLength(25, ErrorMessage = "A Cor deve possuir no máximo 25 caracteres")]
        public string Cor { get; set; }

        public ICollection<Carta> Cartas { get; set; }
        
        public Tipo_carta()
        {
            Cartas = new HashSet<Carta>();
        }
    }
}