using ProjetoLocacao.DAL;
using ProjetoLocacao.Model;
using System.Collections.Generic;
using System.Windows;

namespace ProjetoLocacao.View
{
    /// <summary>
    /// Interaction logic for frmBuscarLocacao.xaml
    /// </summary>
    public partial class frmBuscarLocacao : Window
    {
        private List<dynamic> locacoes = new List<dynamic>();
        public frmBuscarLocacao()
        {
            InitializeComponent();
            txtCpf.Focus();
        }


        private void btnBuscar_Click_1(object sender, RoutedEventArgs e)
        {
            List<Locacao> vazia = new List<Locacao>();
            
            Cliente cli = ClienteDAO.BuscarCpf(txtCpf.Text);
            if (cli != null)
            {
                locacoes.Clear();
                string status;
                foreach (Locacao loc in LocacaoDAO.ListarLocPorCli(txtCpf.Text))
                {
                    if (loc.devolvido)
                    {
                        status = "Entregue";
                    }
                    else
                    {
                        status = "Com cliente";
                    }
                    dynamic item = new
                    {
                        cliente = cli.nome,
                        veiculo = loc.veiculo.modelo,
                        prevEntrega = loc.previsaoEntrega.ToString(),
                        situacao = status,
                        preco = loc.totalLocacao.ToString("C2")
                    };
                    locacoes.Add(item);
                }
                dtaLocacoes.ItemsSource = locacoes;
            }
            else
            {
                MessageBox.Show("Cliente não possui locações cadastradas!",
                                "Locação - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
                txtCpf.Clear();
                txtCpf.Focus();
            }
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            List<Locacao> vazia = new List<Locacao>();
            txtCpf.Clear();
            dtaLocacoes.ItemsSource = vazia;
            dtaLocacoes.Items.Refresh();
            txtCpf.Focus();
        }
    }
}
