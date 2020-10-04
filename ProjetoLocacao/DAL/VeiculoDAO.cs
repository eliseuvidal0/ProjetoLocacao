using ProjetoLocacao.Model;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoLocacao.DAL
{
    class VeiculoDAO
    {
        private static Context _context = SingletonContext.getInstance();

        public static bool Salvar(Veiculo veiculo)
        {
            if (BuscarPlaca(veiculo.placa) != null)
            {
                return false;
            }
            else
            {
                _context.veiculos.Add(veiculo);
                _context.SaveChanges();
                return true;
            }
        }
        public static Veiculo BuscarPorId(int id) => _context.veiculos.Find(id);
        public static List<Veiculo> Listar() => _context.veiculos.ToList();
        public static Veiculo BuscarPlaca(string placa) => _context.veiculos.FirstOrDefault(x => x.placa.Equals(placa));

        public static void Remover(Veiculo veiculo)
        {
            //_context.Database.ExecuteSqlRaw("ALTER TABLE NomeDaTabela NOCHECK CONSTRAINT FK_NomeDaFK");
            _context.veiculos.Remove(veiculo);
            _context.SaveChanges();
        }
    }

}
