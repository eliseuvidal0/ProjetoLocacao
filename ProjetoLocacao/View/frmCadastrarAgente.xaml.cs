using ProjetoLocacao.DAL;
using ProjetoLocacao.Model;
using ProjetoLocacao.Utility;
using System;
using System.Windows;

namespace ProjetoLocacao.View
{
    /// <summary>
    /// Interaction logic for frmCadastrarAgente.xaml
    /// </summary>
    public partial class frmCadastrarAgente : Window
    {
        private static Agente agente;
        public frmCadastrarAgente()
        {
            InitializeComponent();
            txtNome.Focus();

        }

        private void btnSalvarAgente_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNome.Text) && !String.IsNullOrWhiteSpace(txtCpf.Text) &&
                !String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                agente = new Agente
                {
                    nome = txtNome.Text,
                    cpf = Validacao.Formatar(txtCpf.Text),
                    email = txtEmail.Text

                };

                if (Validacao.ValidarCpf(agente.cpf))
                {
                    if (AgenteDAO.Salvar(agente))
                    {
                        MessageBox.Show("Funcionário Cadastrado!", "Funcionário - WPF",
                            MessageBoxButton.OK, MessageBoxImage.Information);
                        LimparFormulario();
                    }
                    else
                    {
                        MessageBox.Show("Funcionário já existe!", "Funcionário - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("**Cpf inválido!**", "Funcionário - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente!",
                                    "Funcionário - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void LimparFormulario()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtNome.Focus();
        }
    }
}
