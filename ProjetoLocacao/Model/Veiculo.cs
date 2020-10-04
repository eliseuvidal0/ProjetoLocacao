using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLocacao.Model
{
    [Table("veiculos")]
    class Veiculo
    {
        [Key]
        public int id { get; set; }
        public string placa { get; set; }
        public string tipo { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public double valorDiaria { get; set; }
        public bool locado { get; set; }
        public DateTime criadoEm { get; set; }

        public Veiculo()
        {
            this.criadoEm = DateTime.Now;
            this.locado = false;
        }
    }
}
