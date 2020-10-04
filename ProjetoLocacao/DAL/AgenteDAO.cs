using ProjetoLocacao.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoLocacao.DAL
{
    class AgenteDAO
    {
        private static Context _context = SingletonContext.getInstance();
        public static bool Salvar(Agente agente)
        {
            if (BuscarCpf(agente.cpf) != null)
            {
                return false;
            }
            else
            {
                _context.agentes.Add(agente);
                _context.SaveChanges();
                return true;
            }
        }
        public static Agente BuscarPorId(int id) => _context.agentes.Find(id);
        public static List<Agente> Listar() => _context.agentes.ToList();
        public static Agente BuscarCpf(string cpf) => _context.agentes.FirstOrDefault(x => x.cpf.Equals(cpf));

        public static void Remover(Agente agente)
        {
            _context.agentes.Remove(agente);
            _context.SaveChanges();
        }

        public static void Alterar(Agente agente)
        {
            _context.agentes.Update(agente);
            _context.SaveChanges();
        }
    }
}
