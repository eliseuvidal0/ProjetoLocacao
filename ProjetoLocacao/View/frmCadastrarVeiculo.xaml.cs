using ProjetoLocacao.DAL;
using ProjetoLocacao.Model;
using ProjetoLocacao.Utility;
using System;
using System.Windows;

namespace ProjetoLocacao.View
{
    /// <summary>
    /// Interaction logic for frmCadastrarVeiculo.xaml
    /// </summary>
    public partial class frmCadastrarVeiculo : Window
    {
        public frmCadastrarVeiculo()
        {
            InitializeComponent();
            txtPlaca.Focus();
        }
        private Veiculo veiculo;
        private void btnSalvarVeiculo_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtPlaca.Text) && !String.IsNullOrWhiteSpace(txtMarca.Text) &&
                !String.IsNullOrWhiteSpace(txtModelo.Text) && !String.IsNullOrWhiteSpace(txtValorDiaria.Text) &&
                !String.IsNullOrWhiteSpace(txtCor.Text) && !String.IsNullOrWhiteSpace(txtTipo.Text))
            {
                veiculo = new Veiculo
                {
                    placa = txtPlaca.Text,
                    tipo = txtTipo.Text,
                    marca = txtMarca.Text,
                    modelo = txtModelo.Text,
                    cor = txtCor.Text,
                    valorDiaria = Convert.ToDouble(txtValorDiaria.Text)
                };

                if (Validacao.ValidarPlaca(veiculo.placa))
                {
                    if (VeiculoDAO.Salvar(veiculo))
                    {
                        MessageBox.Show("Veículo cadastrado!", "Veículo - WPF", MessageBoxButton.OK, MessageBoxImage.Information);
                        LimparFormulario();
                    }
                    else
                    {
                        MessageBox.Show("Placa já está cadastrada!", "Veículo - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Placa inválida!", "Veículo - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente!", "Veículo - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void LimparFormulario()
        {
            txtPlaca.Clear();

            txtMarca.Clear();
            txtModelo.Clear();
            txtCor.Clear();
            txtValorDiaria.Clear();
        }
    }
}
