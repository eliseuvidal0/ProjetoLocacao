using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProjetoLocacao.Model
{
    [Table("Devolucoes")]
    class Devolucao
    {
        [Key]
        public int id { get; set; }
        public Cliente cliente { get; set; }
        public Veiculo veiculo { get; set; }
        public DateTime dataEntrega { get; set; }
        // valor a ser cobrado a mais caso exceda o período inicial
        public double custoVariavel { get; set; }

        public Devolucao()
        {
            this.cliente = new Cliente();
            this.veiculo = new Veiculo();
            this.dataEntrega = DateTime.Now;
        }
    }
}
