using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YugiohDex.Models;

[Table("Nivel")]
public class Nivel
{
    public int Nivel_Id { get; set; }
}