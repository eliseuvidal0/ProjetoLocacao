using ProjetoLocacao.Model;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoLocacao.DAL
{
    class LocacaoDAO
    {
        private static Context _context = SingletonContext.getInstance();
        public static bool Salvar(Locacao locacao)
        {
            if (locacao.veiculo.locado)
            {
                return false;
            }
            else
            {
                _context.locacoes.Add(locacao);
                _context.SaveChanges();
                locacao.veiculo.locado = true;
                return false;
            }

        }

        /**
         * 
         *  _context.Database.ExecuteSqlRaw("ALTER TABLE NomeDaTabela NOCHECK CONSTRAINT FK_NomeDaFK");
         * 
         */
        public static Locacao BuscarPorId(int id) => _context.locacoes.Find(id);
        public static List<Locacao> Listar() => _context.locacoes.ToList();
        public static Veiculo BuscarVeiculo(string modelo) => _context.veiculos.FirstOrDefault(x => x.modelo.Equals(modelo));

        public static bool ValidarCatCnh(Locacao locacao)
        {
            if (locacao.veiculo.tipo == "Carro" && locacao.cliente.cnh == "A")
            {
                return false;
            }
            else if (locacao.veiculo.tipo == "Van" && locacao.cliente.cnh == "B" || locacao.cliente.cnh == "A"
                        || locacao.cliente.cnh == "AB")
            {
                return false;
            }
            else if (locacao.veiculo.tipo == "Moto" && locacao.cliente.cnh == "B" || locacao.cliente.cnh == "C"
                       || locacao.cliente.cnh == "D" || locacao.cliente.cnh == "E")
            {
                return false;
            }
            return true;
        }
     
    }
}
