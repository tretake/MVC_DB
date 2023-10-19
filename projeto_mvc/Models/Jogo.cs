using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_mvc.Models
{
    public class Jogo
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="jogo precias de uma capa")]
        public string CapaImg { get; set; }

		[Required(ErrorMessage = "jogo precisa de um nome")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "jogo precias de uma data de lançamento")]
		public DateTime DataLancamento { get; set;}


		//RELAÇÕES


		//DEVELOPER
		[Required(ErrorMessage = "jogo precias de um desenvolvedor")]
		public int Id_Dev {  get; set; }

        [ForeignKey("Id_Dev")]
        public Desenvolvedor? desenvolvedor { get; set; }

		[Required(ErrorMessage = "jogo precias de uma plataforma")]
		public int Id_Plataforma { get; set; }
		[ForeignKey("Id_Plataforma")]
		public Plataforma? plataforma { get; set; }


    }
}
