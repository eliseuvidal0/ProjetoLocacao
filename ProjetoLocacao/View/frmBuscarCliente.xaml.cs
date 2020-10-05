using ProjetoLocacao.DAL;
using ProjetoLocacao.Model;
using System;
using System.Windows;

namespace ProjetoLocacao.View
{
    /// <summary>
    /// Interaction logic for frmBuscarCliente.xaml
    /// </summary>
    public partial class frmBuscarCliente : Window
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
            txtCpf.Focus();
        }

        Cliente cliente = new Cliente();

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCpf.Text))
            {
                cliente = ClienteDAO.BuscarCpf(txtCpf.Text);
                if (cliente != null)
                {
                    txtNome.Text = cliente.nome;
                    txtCpf.Text = cliente.cpf;
                    txtEmail.Text = cliente.email;
                    txtTelefone.Text = cliente.telefone;
                    cboCnh.Text = cliente.cnh;

                    txtNome.IsEnabled = true;
                    txtEmail.IsEnabled = true;
                    txtTelefone.IsEnabled = true;
                    cboCnh.IsEnabled = true;
                    btnAlterar.IsEnabled = true;
                    btnRemover.IsEnabled = true;
                    btnBuscar.IsEnabled = false;
                }
                else
                {
                    MessageBox.Show("Cliente não existente!!!", "Cliente - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo CPF!!!", "Cliente - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            if (cliente != null)
            {
                cliente.nome = txtNome.Text;
                cliente.cpf = txtCpf.Text;
                cliente.email = txtEmail.Text;
                cliente.telefone = txtTelefone.Text;
                cliente.cnh = cboCnh.Text;
                ClienteDAO.Alterar(cliente);
                MessageBox.Show("Cliente alterado com sucesso!!!", "Cliente - WPF", MessageBoxButton.OK, MessageBoxImage.Information);
                LimparFormulario();

                txtNome.IsEnabled = false;
                txtEmail.IsEnabled = false;
                txtTelefone.IsEnabled = false;
                cboCnh.IsEnabled = false;
                btnAlterar.IsEnabled = false;
                btnRemover.IsEnabled = false;
                btnBuscar.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Cliente não foi alterado!!!", "Cliente - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (cliente != null)
            {
                ClienteDAO.Remover(cliente);
                MessageBox.Show("Cliente removido com sucesso!!!", "Funcionário - WPF", MessageBoxButton.OK, MessageBoxImage.Information);
                LimparFormulario();

                txtNome.IsEnabled = false;
                txtEmail.IsEnabled = false;
                txtTelefone.IsEnabled = false;
                cboCnh.IsEnabled = false;
                btnAlterar.IsEnabled = false;
                btnRemover.IsEnabled = false;
                btnBuscar.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Cliente não foi removido!!!", "Funcionário - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void LimparFormulario()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            cboCnh.Text = " ";
        }
    }
}
