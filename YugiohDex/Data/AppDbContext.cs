using Microsoft.EntityFrameworkCore;
using Yugiohdex.Models;
using YugiohDex.Models;

namespace Yugiohdex.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Carta> Cartas { get; set; }
    public DbSet<Tipo_carta> Tipos { get; set; }
    public DbSet<Nivel> Niveis { get; set; }
    public DbSet<Elemento> Elementos { get; set; }

}
