using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Yugiohdex.Models;

namespace YugiohDex.Models
{
    public class AppDbSeed
    {
        public AppDbSeed (ModelBuilder builder)
        {
            List<Tipo_carta> tipo_cartas = new()
            {
                new Tipo_carta { Id = 1, Nome = "Armadilha", Cor = "Roxo" },
                new Tipo_carta { Id = 2, Nome = "Magia", Cor = "Verde" },
                new Tipo_carta { Id = 3, Nome = "Monstro Normal", Cor = "Amarelo" },
                new Tipo_carta { Id = 4, Nome = "Monstro Com Efeito", Cor = "Laranja" },
                new Tipo_carta { Id = 5, Nome = "Fusão", Cor = "Azul" },
                new Tipo_carta { Id = 6, Nome = "Ritual", Cor = "Branco" },
                new Tipo_carta { Id = 7, Nome = "Synchro", Cor = "Cinza" },
                new Tipo_carta { Id = 8, Nome = "Xyz", Cor = "Preto" },
                new Tipo_carta { Id = 9, Nome = "Pendulum", Cor = "Rosa" },
                new Tipo_carta { Id = 10, Nome = "Link", Cor = "Azul Claro" }
            };
            builder.Entity<Tipo_carta>().HasData(tipo_cartas);

            List<Carta> cartas = new()
            {
                // Armadilhas
                new Carta { Id = 1, Numero = 1,  Nome = "Força Espelho", Descricao = "Uma habilidade que reflete ataques inimigos de volta, surpreendendo adversários descuidados.", }
            };
            builder.Entity<Carta>().HasData(cartas);
        }
    }
}