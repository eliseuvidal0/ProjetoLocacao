using ProjetoLocacao.Model;
using System.Collections.Generic;
using System.Windows;

namespace ProjetoLocacao.View
{
    /// <summary>
    /// Interaction logic for frmPrincipal.xaml
    /// </summary>
    public partial class frmPrincipal : Window
    {
        private List<Cliente> clientes = new List<Cliente>();
        private List<Agente> agentes = new List<Agente>();
        private List<Veiculo> veiculos = new List<Veiculo>();
        private List<Locacao> locacaos = new List<Locacao>();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult resultado = MessageBox.Show("Deseja realmente sair?", "Sair WPF", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (resultado == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void menuCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarCliente frm = new frmCadastrarCliente();

            frm.ShowDialog();
        }

        private void menuCadastrarVeiculo_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarVeiculo frm = new frmCadastrarVeiculo();

            frm.ShowDialog();
        }

        private void menuCadastrarAgente_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarAgente frm = new frmCadastrarAgente();

            frm.ShowDialog();
        }

        private void menuCadastrarDevolucao_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarDevolucao frm = new frmCadastrarDevolucao();

            frm.ShowDialog();
        }

        private void menuCadastrarLocacao_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarLocacao frm = new frmCadastrarLocacao();

            frm.ShowDialog();
        }

        private void menuConsultarCliente_Click(object sender, RoutedEventArgs e)
        {
            frmConsultarCliente frm = new frmConsultarCliente();

            frm.ShowDialog();
        }

        private void menuConsultarAgente_Click(object sender, RoutedEventArgs e)
        {
            frmConsultarAgente frm = new frmConsultarAgente();

            frm.ShowDialog();
        }

        private void menuConsultarVeiculo_Click(object sender, RoutedEventArgs e)
        {
            frmConsultarVeiculo frm = new frmConsultarVeiculo();

            frm.ShowDialog();
        }

        private void menuConsultarLocacao_Click(object sender, RoutedEventArgs e)
        {
            frmConsultarLocacao frm = new frmConsultarLocacao();

            frm.ShowDialog();
        }

        private void menuConsultarDevolucao_Click(object sender, RoutedEventArgs e)
        {
            frmConsultarDevolucao frm = new frmConsultarDevolucao();

            frm.ShowDialog();
        }

        private void menuBuscarCliente_Click(object sender, RoutedEventArgs e)
        {
            frmBuscarCliente frm = new frmBuscarCliente();

            frm.ShowDialog();
        }

        private void menuBuscarAgente_Click(object sender, RoutedEventArgs e)
        {
            frmBuscarAgente frm = new frmBuscarAgente();

            frm.ShowDialog();
        }

        private void menuBuscarVeiculo_Click(object sender, RoutedEventArgs e)
        {
            frmBuscarVeiculo frm = new frmBuscarVeiculo();

            frm.ShowDialog();
        }

        private void menuBuscarLocacao_Click(object sender, RoutedEventArgs e)
        {
            frmBuscarLocacao frm = new frmBuscarLocacao();

            frm.ShowDialog();
        }

        private void menuBuscarDevolucao_Click(object sender, RoutedEventArgs e)
        {
            frmBuscarDevolucao frm = new frmBuscarDevolucao();

            frm.ShowDialog();
        }

    }
}
