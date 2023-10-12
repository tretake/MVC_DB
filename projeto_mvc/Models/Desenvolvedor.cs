using System.ComponentModel.DataAnnotations;

namespace projeto_mvc.Models
{
    public class Desenvolvedor
    {

        [Key]
        public int Id { get; set; }
        public string LogoImg { get; set; }
        public string Nome { get; set; }

        public List<Jogo> jogos { get; set; }

    }
}
