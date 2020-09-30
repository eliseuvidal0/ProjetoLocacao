using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoLocacao.Model
{
    class Pessoa
    {
        public Pessoa()
        {
            this.criadoEm = DateTime.Now;
        }
        [Key]
        public int id { get; set; }
        public String cpf { get; set; }
        public String nome { get; set; }
        public String email { get; set; }
        public DateTime criadoEm { get; set; }
        public List<Locacao> locacoes { get; set; }
    }
}
