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
                int dias = locacao.previsaoEntrega.Day - locacao.criadoEm.Day;
                locacao.totalLocacao = locacao.veiculo.valorDiaria * dias;
                locacao.veiculo.locado = true;

                _context.locacoes.Add(locacao);
                _context.SaveChanges();
                locacao.veiculo.locado = true;
                return true;
            }

        }


        public static Locacao BuscarPorId(int id) => _context.locacoes.Find(id);
        public static List<Locacao> Listar() => _context.locacoes.ToList();
        public static List<Locacao> ListarLocado() => _context.locacoes.Where(x => x.devolvido == false).ToList();
        public static List<Locacao> ListarLocPorCli(string cpf) => _context.locacoes.Where(x => x.cliente.cpf == cpf).ToList();
        public static Veiculo BuscarVeiculo(string modelo) => _context.veiculos.FirstOrDefault(x => x.modelo.Equals(modelo));

        public static bool ValidarCatCnh(Locacao locacao)
        {
            if (locacao.veiculo.tipo == "Carro" && locacao.cliente.cnh == "A")
            {
                return false;
            }
            else if (locacao.veiculo.tipo == "Caminhão" && locacao.cliente.cnh == "B")
            {
                return false;
            }
            else if (locacao.veiculo.tipo == "Caminhão" && locacao.cliente.cnh == "A")
            {
                return false;
            }
            else if (locacao.veiculo.tipo == "Caminhão" && locacao.cliente.cnh == "AB")
            {
                return false;
            }
            else if (locacao.veiculo.tipo == "Moto" && locacao.cliente.cnh == "B")
            {
                return false;
            }
            else if (locacao.veiculo.tipo == "Moto" && locacao.cliente.cnh == "C")
            {
                return false;
            }
            else if (locacao.veiculo.tipo == "Moto" && locacao.cliente.cnh == "D")
            {
                return false;
            }
            else if (locacao.veiculo.tipo == "Moto" && locacao.cliente.cnh == "E")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void Alterar(Locacao locacao)
        {
            _context.locacoes.Update(locacao);
            _context.SaveChanges();
        }
    }
}
