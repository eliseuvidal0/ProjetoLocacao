using ProjetoLocacao.DAL;
using ProjetoLocacao.Model;
using ProjetoLocacao.Utility;
using System.Windows;

namespace ProjetoLocacao.View
{
    /// <summary>
    /// Interaction logic for frmConsultarLocacao.xaml
    /// </summary>
    public partial class frmConsultarLocacao : Window
    {
        public frmConsultarLocacao()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            string status;
            foreach (Locacao l in LocacaoDAO.Listar())
            {
                string x = l.totalLocacao.ToString("C2");
                if (l.devolvido)
                {
                    status = "Disponível";
                }
                else
                {
                    status = "Locado";
                }
                dtaLocacao.Items.Add(new DataGridItems
                {

                    Id = l.id.ToString(),
                    Cliente = l.cliente.nome,
                    Agente = l.agente.nome,
                    Veiculo = l.veiculo.modelo,
                    Locacao = status,
                    Previsao = l.previsaoEntrega.ToString(),
                    Preco = x
                });
            }
        }

    }
}
