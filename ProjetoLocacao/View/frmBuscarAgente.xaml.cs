using ProjetoLocacao.DAL;
using ProjetoLocacao.Model;
using System;
using System.Windows;

namespace ProjetoLocacao.View
{
    /// <summary>
    /// Interaction logic for frmBuscarAgente.xaml
    /// </summary>
    public partial class frmBuscarAgente : Window
    {
        public frmBuscarAgente()
        {
            InitializeComponent();
            txtCpf.Focus();
        }

        Agente agente = new Agente();

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCpf.Text))
            {
                agente = AgenteDAO.BuscarCpf(txtCpf.Text);
                if (agente != null)
                {
                    txtNome.Text = agente.nome;
                    txtCpf.Text = agente.cpf;
                    txtEmail.Text = agente.email;

                    txtNome.IsEnabled = true;
                    txtEmail.IsEnabled = true;
                    btnAlterar.IsEnabled = true;
                    btnRemover.IsEnabled = true;
                    btnBuscar.IsEnabled = false;
                }
                else
                {
                    MessageBox.Show("Funcionário não existente!!!", "Funcionário - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo CPF!!!", "Funcionário - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            if (agente != null)
            {
                agente.nome = txtNome.Text;
                agente.cpf = txtCpf.Text;
                agente.email = txtEmail.Text;
                AgenteDAO.Alterar(agente);
                MessageBox.Show("Funcionário alterado com sucesso!!!", "Funcionário - WPF", MessageBoxButton.OK, MessageBoxImage.Information);
                LimparFormulario();

                txtNome.IsEnabled = false;
                txtEmail.IsEnabled = false;
                btnAlterar.IsEnabled = false;
                btnRemover.IsEnabled = false;
                btnBuscar.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Funcionário não foi alterado!!!", "Funcionário - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (agente != null)
            {
                AgenteDAO.Remover(agente);
                MessageBox.Show("Funcionário removido com sucesso!!!", "Funcionário - WPF", MessageBoxButton.OK, MessageBoxImage.Information);
                LimparFormulario();

                txtNome.IsEnabled = false;
                txtEmail.IsEnabled = false;
                btnAlterar.IsEnabled = false;
                btnRemover.IsEnabled = false;
                btnBuscar.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Funcionário não foi removido!!!", "Funcionário - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
        }
    }
}
