using Microsoft.EntityFrameworkCore;
using ProjetoLocacao.Model;
using System;
using System.Collections.Generic;
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
        public static Cliente BuscarPorId(int id) => _context.clientes.Find(id);
        public static List<Cliente> Listar() => _context.clientes.ToList();
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
        public static void Remover(Cliente cliente)
        {
            _context.Database.ExecuteSqlRaw("ALTER TABLE Locacoes NOCHECK CONSTRAINT FK_Locacoes_Clientes_clienteid");
            _context.clientes.Remove(cliente);

            _context.SaveChanges();
        }
        public static void Alterar(Cliente cliente)
        {
            _context.clientes.Update(cliente);
            _context.SaveChanges();
        }
    }
}
