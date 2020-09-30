using ProjetoLocacao.Model;
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

        public static Agente BuscarCpf(string cpf) => _context.agentes.FirstOrDefault(x => x.cpf.Equals(cpf));
    }
}
