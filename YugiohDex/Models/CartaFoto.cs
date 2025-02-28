using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Yugiohdex.Models;

namespace YugiohDex.Models;
[Table("CartaFoto")]
    public class CartaFoto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A Carta Deve Ser Informada")]
        public int CartaId { get; set; }

        [ForeignKey(nameof(CartaId))]
        public Carta Carta { get; set; }

        [Required]
        [StringLength(300)]
        [Display(Name = "Arquivo da Foto")]    
        public string ArquivoFoto { get; set; }


        [Display(Name = "Descrição")]    
        [StringLength(60, ErrorMessage = "A Descrição deve possuir no máximo")]
        public string Descricao { get; set; }
    }