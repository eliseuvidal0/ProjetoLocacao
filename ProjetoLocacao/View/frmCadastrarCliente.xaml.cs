using ProjetoLocacao.DAL;
using ProjetoLocacao.Model;
using ProjetoLocacao.Utility;
using System;
using System.Windows;
using System.Windows.Controls;

namespace ProjetoLocacao.View
{
    /// <summary>
    /// Interaction logic for frmCadastrarCliente.xaml
    /// </summary>
    public partial class frmCadastrarCliente : Window
    {
        private static Cliente cliente;
        public frmCadastrarCliente()
        {
            InitializeComponent();
            txtNome.Focus();
        }

        private void btnSalvarCli_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNome.Text) && !String.IsNullOrWhiteSpace(txtCpf.Text) &&
                !String.IsNullOrWhiteSpace(txtEmail.Text) && !String.IsNullOrWhiteSpace(txtTelefone.Text) &&
                !String.IsNullOrWhiteSpace(txtNascimento.Text) && !String.IsNullOrWhiteSpace(txtCnh.Text))
            {
                cliente = new Cliente
                {
                    nome = txtNome.Text,
                    cpf = txtCpf.Text,
                    email = txtEmail.Text,
                    telefone = txtTelefone.Text,
                    nascimento = Convert.ToDateTime(txtNascimento.Text),
                    cnh = txtCnh.Text

                };
                if (ClienteDAO.CalcularIdade(cliente.nascimento) > 17)
                {
                    if (Validacao.ValidarCpf(cliente.cpf))
                    {
                        if (ClienteDAO.Salvar(cliente))
                        {
                            MessageBox.Show("Cliente Cadastrado!", "Cliente - WPF",
                                MessageBoxButton.OK, MessageBoxImage.Information);
                            LimparFormulario();
                        }
                        else
                        {
                            MessageBox.Show("Cliente já existe!",
                            "Cliente - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("**Cpf inválido!**",
                        "Cliente - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Impossível cadastrar menor de idade",
                        "Cliente - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente!",
                        "Cliente - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtNascimento = new DatePicker();
            txtNascimento.Text = " ";
            txtCnh.Text = " ";
        }
    }
}
