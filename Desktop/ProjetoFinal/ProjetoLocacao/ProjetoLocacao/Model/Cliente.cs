using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLocacao.Model
{
    [Table("Clientes")]
    class Cliente : Pessoa
    {
        public DateTime nascimento { get; set; }
        public String telefone { get; set; }
        public String cnh { get; set; }

    }
}
