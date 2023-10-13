using System.ComponentModel.DataAnnotations;

namespace projeto_mvc.Models
{
    public class Plataforma_Jogo
    {

        public int PlataformaId { get; set; }

        [Key]
        public Plataforma plataforma { get; set; }

        public int JogoId { get; set; }

        [Key]
        public Jogo jogo { get; set; }
    }
}
