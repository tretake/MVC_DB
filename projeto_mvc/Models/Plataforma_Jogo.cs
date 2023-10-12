namespace projeto_mvc.Models
{
    public class Plataforma_Jogo
    {

        public int IdPlataforma { get; set; }
        public Plataforma plataforma { get; set; }

        public int IdJogo { get; set; }
        public Jogo jogo { get; set; }
    }
}
