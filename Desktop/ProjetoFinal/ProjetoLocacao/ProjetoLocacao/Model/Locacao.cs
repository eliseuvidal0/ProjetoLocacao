using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLocacao.Model
{
    [Table("Locacoes")]
    class Locacao
    {
        [Key]
        public int id { get; set; }
        public Cliente cliente { get; set; }
        public Veiculo veiculo { get; set; }
        public Agente agente { get; set; }
        public string formaPagamento { get; set; }
        public double totalLocacao { get; set; }
        public DateTime previsaoEntrega { get; set; }
        public DateTime criadoEm { get; set; }

        public Locacao()
        {
            this.agente = new Agente();
            this.cliente = new Cliente();
            this.veiculo = new Veiculo();
            this.criadoEm = DateTime.Now;
        }
    }
}
