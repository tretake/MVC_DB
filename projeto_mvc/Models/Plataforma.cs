using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_mvc.Models
{
    public class Plataforma
    {
        [Key]
        public int Id { get; set; }
        public string LogoImg { get; set; }
        public string Nome { get; set; }
        public DateTime DataLancamento { get; set; }

        public string Desenvolvedor { get; set; }

        //RELAÇÕES

        //JOGO
        public List<Plataforma_Jogo> plataforma_jogos { get; set; }
        public List<Jogo> jogos { get; set; }

        /*
        //DEVELOPER
        public int Id_Dev { get; set; }

        [ForeignKey("Id_Dev")]
        public Desenvolvedor desenvolvedor { get; set; }*/


    }
}
