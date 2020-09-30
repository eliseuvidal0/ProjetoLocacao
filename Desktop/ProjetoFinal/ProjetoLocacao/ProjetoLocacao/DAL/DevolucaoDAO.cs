using ProjetoLocacao.Model;

namespace ProjetoLocacao.DAL
{
    class DevolucaoDAO
    {
        private static Context _context = SingletonContext.getInstance();

        public static bool Salvar(Devolucao dev)
        {
            if (!dev.veiculo.locado)
            {
                return false;
            }
            else
            {
                _context.devolucoes.Add(dev);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
