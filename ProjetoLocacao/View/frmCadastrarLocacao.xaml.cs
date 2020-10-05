using ProjetoLocacao.DAL;
using ProjetoLocacao.Model;
using System;
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

        private static Locacao locacao;
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

        private void Salvar_Click_1(object sender, RoutedEventArgs e)
        {
            int idCliente = (int)cboClientes.SelectedValue;
            int idFuncionario = (int)cboFuncionarios.SelectedValue;
            int idVeiculo = (int)cboVeiculos.SelectedValue;

            locacao = new Locacao
            {
                cliente = ClienteDAO.BuscarPorId(idCliente),
                agente = AgenteDAO.BuscarPorId(idFuncionario),
                veiculo = VeiculoDAO.BuscarPorId(idVeiculo),
                formaPagamento = cboFormaPagamento.Text,
                previsaoEntrega = Convert.ToDateTime(txtDataEntrega.Text)
            };
            if (LocacaoDAO.ValidarCatCnh(locacao))
            {
                if (LocacaoDAO.Salvar(locacao))
                {
                    int dias = locacao.previsaoEntrega.Day - locacao.criadoEm.Day;
                    double total = locacao.veiculo.valorDiaria * dias;
                    LimparFormulario();
                    MessageBox.Show($"Locação Cadastrada no total de R$ {total}", "Locação - WPF",
                                    MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Veículo não etá disponível!",
                            "Locação - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {

                MessageBox.Show("Cliente não está habilitado para dirigir este veículo!",
                            "Locação - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void LimparFormulario()
        {
            cboClientes.Text = " ";
            cboFuncionarios.Text = " ";
            cboVeiculos.Text = " ";
            cboFormaPagamento.Text = " ";

        }
    }
}
