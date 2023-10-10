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
