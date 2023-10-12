using Microsoft.EntityFrameworkCore.Diagnostics;
using projeto_mvc.Models;

namespace projeto_mvc.Data
{
    public class ProjetoDbInicializador
    {

        public static void  Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope() )
            {   
                var context = serviceScope.ServiceProvider.GetService<ProjetoContext>();

                context.Database.EnsureCreated();

                //Desenvolvedor
                if (!context.Desenvolvedores.Any())
                {
                    context.Desenvolvedores.AddRange(new List<Desenvolvedor>()
                    {
                        new Desenvolvedor()
                        {
                            LogoImg = "https://cdn.mobygames.com/logos/4021-nintendo-co-ltd.png",
                            Nome = "Nintendo"
                        },
                        new Desenvolvedor()
                        {
                            LogoImg = "https://cdn.mobygames.com/logos/15569170-sega-corporation.png",
                            Nome = "Sega"
                        }

                    });
                    context.SaveChanges();
                }

                //Jogo
                if (!context.Jogos.Any())
                {
                    context.Jogos.AddRange(new List<Jogo>()
                    {
                        new Jogo()
                        {
                            CapaImg = "https://cdn.mobygames.com/covers/4046688-the-legend-of-zelda-majoras-mask-nintendo-64-front-cover.jpg",
                            Nome = "The Legend of Zelda: Majora's Mask",
                            DataLancamento = DateTime.Now,
                            Id_Dev = 1
                        },
                        new Jogo()
                        {
                            CapaImg = "https://cdn.mobygames.com/covers/4045638-the-legend-of-zelda-nes-front-cover.jpg",
                            Nome = "The Legend of Zelda",
                            DataLancamento = DateTime.Now,
                            Id_Dev = 1
                        },
                        new Jogo()
                        {
                            CapaImg = "https://cdn.mobygames.com/covers/4756691-the-legend-of-zelda-ocarina-of-time-nintendo-64-front-cover.jpg",
                            Nome = "The Legend of Zelda: Ocarina of Time",
                            DataLancamento = DateTime.Now,
                            Id_Dev = 1
                        },

                    }) ;
                    context.SaveChanges();
                }

                


                //Plataforma
                if (!context.Plataformas.Any())
                {
                    context.Plataformas.AddRange(new List<Plataforma>()
                    {
                        new Plataforma()
                        {
                            LogoImg = "https://www.liblogo.com/img-logo/max/ne7246n50d-nes-logo-nintendo-entertainment-system-zeldapedia-.png",
                            Nome = "NES",
                            DataLancamento = DateTime.Now,
                            Desenvolvedor = "Nintendo"
                        },
                        new Plataforma()
                        {
                            LogoImg = "https://upload.wikimedia.org/wikipedia/en/0/04/Nintendo_64_Logo.svg",
                            Nome = "Nintendo 64",
                            DataLancamento = DateTime.Now,
                            Desenvolvedor = "nintendo"
                        }
                    });
                    context.SaveChanges();
                }

                //PlataformaJogos
                if (!context.PlataformaJogos.Any())
                {
                    context.PlataformaJogos.AddRange(new List<Plataforma_Jogo>()
                    {
                        new Plataforma_Jogo()
                        {
                            IdPlataforma = 2,
                            IdJogo = 1
                        },
                        new Plataforma_Jogo()
                        {
                            IdPlataforma = 1,
                            IdJogo = 2

                        },
                        new Plataforma_Jogo()
                        {
                            
                            IdPlataforma = 2,
                            IdJogo = 3
                        }
                    });
                    context.SaveChanges();
                }

                //Pessoas
                if (!context.Pessoas.Any())
                {
                    context.Pessoas.AddRange(new List<Pessoa>()
                    {
                        new Pessoa()
                        {
                            Nome = "Ruan",
                            Cpf = "1594879156"
                        },
                        new Pessoa()
                        {
                            Nome = "Haru",
                            Cpf = "44894153145315"
                        },
                        new Pessoa()
                        {
                            Nome = "juliana",
                            Cpf = "9841531261615316"
                        },
                        new Pessoa()
                        {
                            Nome = "Emmily",
                            Cpf = "4468615341613"
                        },
                        new Pessoa()
                        {
                            Nome = "Fellype",
                            Cpf = "6186431843161"
                        },
                    }) ;

                    context.SaveChanges();
                }


            }

        }

    }
}
