using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_mvc.Models
{
    public class Jogo
    {

        [Key]
        public int Id { get; set; }
        public string CapaImg { get; set; }
        public string Nome { get; set; }
        public DateTime DataLancamento { get; set;}


        //RELAÇÕES

        //PLATAFORMA
        public List<Plataforma_Jogo> plataforma_jogos { get; set; }
        public List<Plataforma> plataformas { get; set; }

        //DEVELOPER
        public int Id_Dev {  get; set; }

        [ForeignKey("Id_Dev")]
        public Desenvolvedor desenvolvedor { get; set; }


    }
}
