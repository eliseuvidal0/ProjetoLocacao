using System.Windows;

namespace ProjetoLocacao.View
{
    /// <summary>
    /// Interaction logic for frmPrincipal.xaml
    /// </summary>
    public partial class frmPrincipal : Window
    {
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
    }
}
