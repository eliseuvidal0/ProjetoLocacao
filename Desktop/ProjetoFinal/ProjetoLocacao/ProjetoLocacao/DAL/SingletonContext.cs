using ProjetoLocacao.Model;

namespace ProjetoLocacao.DAL
{
    class SingletonContext
    {
        private static Context _context;

        public static Context getInstance()
        {
            if (_context == null)
            {
                _context = new Context();
            }

            return _context;
        }
    }
}
