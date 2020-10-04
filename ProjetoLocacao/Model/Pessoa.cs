using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoLocacao.Model
{
    public class Pessoa
    {
        public Pessoa()
        {
            this.criadoEm = DateTime.Now;
        }
        [Key]
        public virtual int id { get; set; }
        public virtual String cpf { get; set; }
        public virtual String nome { get; set; }
        public virtual String email { get; set; }
        public virtual DateTime criadoEm { get; set; }
        public virtual List<Locacao> locacoes { get; set; }
    }
}
