﻿using System.ComponentModel.DataAnnotations;

namespace projeto_mvc.Models
{
    public class Pessoa
    {

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

    }
}
