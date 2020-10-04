using ProjetoLocacao.DAL;
using System.Windows;

namespace ProjetoLocacao.View
{
    /// <summary>
    /// Interaction logic for frmCadastrarDevolucao.xaml
    /// </summary>
    public partial class frmCadastrarDevolucao : Window
    {
        public frmCadastrarDevolucao()
        {
            InitializeComponent();
            clientesDevolucao.Focus();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //carregar dados do cliente
            clientesDevolucao.ItemsSource = ClienteDAO.Listar();
            clientesDevolucao.DisplayMemberPath = "nome";
            clientesDevolucao.SelectedValuePath = "id";

            //carregar dados do veiculo
            veiculosDevolucao.ItemsSource = VeiculoDAO.Listar();
            veiculosDevolucao.DisplayMemberPath = "modelo";
            veiculosDevolucao.SelectedValuePath = "id";


        }
        private void btnSalvarEntrega_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
