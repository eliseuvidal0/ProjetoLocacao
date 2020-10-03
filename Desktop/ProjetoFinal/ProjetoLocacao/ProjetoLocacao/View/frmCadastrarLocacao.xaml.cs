using ProjetoLocacao.DAL;
using System.Windows;

namespace ProjetoLocacao.View
{
    /// <summary>
    /// Interaction logic for frmCadastrarLocacao.xaml
    /// </summary>
    public partial class frmCadastrarLocacao : Window
    {
        public frmCadastrarLocacao()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //carregar dados do cliente
            cboClientes.ItemsSource = ClienteDAO.Listar();
            cboClientes.DisplayMemberPath = "nome";
            cboClientes.SelectedValuePath = "id";

            //carregar dados do veiculo
            cboVeiculos.ItemsSource = VeiculoDAO.Listar();
            cboVeiculos.DisplayMemberPath = "modelo";
            cboVeiculos.SelectedValuePath = "id";

            //carregar dados do funcionário
            cboFuncionarios.ItemsSource = AgenteDAO.Listar();
            cboFuncionarios.DisplayMemberPath = "nome";
            cboFuncionarios.SelectedValuePath = "id";
        }
    }
}
