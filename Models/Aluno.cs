using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDB.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Serie { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }

    }
}