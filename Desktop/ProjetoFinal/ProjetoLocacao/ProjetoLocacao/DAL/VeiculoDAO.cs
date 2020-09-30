using ProjetoLocacao.Model;
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

        public static Veiculo BuscarPlaca(string placa) => _context.veiculos.FirstOrDefault(x => x.placa.Equals(placa));
    }
}
