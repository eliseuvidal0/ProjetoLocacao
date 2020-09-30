using ProjetoLocacao.Model;
using System;
using System.Linq;

namespace ProjetoLocacao.DAL
{
    class ClienteDAO
    {
        private static Context _context = SingletonContext.getInstance();

        public static bool Salvar(Cliente cliente)
        {
            if (BuscarCpf(cliente.cpf) != null)
            {
                return false;
            }
            else
            {
                _context.clientes.Add(cliente);
                _context.SaveChanges();
                return true;
            }
        }
        public static Cliente BuscarCpf(string cpf) => _context.clientes.FirstOrDefault(x => x.cpf.Equals(cpf));

        public static int CalcularIdade(DateTime data)
        {
            DateTime atual = DateTime.Now;

            if (data.Month <= atual.Month && data.Day <= atual.Day)
            {
                return atual.Year - data.Year;
            }
            else
            {
                return atual.Year - data.Year - 1;
            }
        }
    }
}
