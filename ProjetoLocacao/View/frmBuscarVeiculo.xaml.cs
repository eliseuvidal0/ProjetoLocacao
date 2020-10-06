using ProjetoLocacao.DAL;
using ProjetoLocacao.Model;
using System;
using System.Windows;

namespace ProjetoLocacao.View
{
    /// <summary>
    /// Interaction logic for frmBuscarVeiculo.xaml
    /// </summary>
    public partial class frmBuscarVeiculo : Window
    {
        public frmBuscarVeiculo()
        {
            InitializeComponent();
            txtPlaca.Focus();
        }

        Veiculo veiculo = new Veiculo();

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtPlaca.Text))
            {
                veiculo = VeiculoDAO.BuscarPlaca(txtPlaca.Text);
                if (veiculo != null)
                {
                    txtPlaca.Text = veiculo.placa;
                    txtTipo.Text = veiculo.tipo;
                    txtMarca.Text = veiculo.marca;
                    txtModelo.Text = veiculo.modelo;
                    txtCor.Text = veiculo.cor;
                    txtValorDiaria.Text = Convert.ToDouble(veiculo.valorDiaria).ToString();

                    txtPlaca.IsEnabled = false;
                    btnRemover.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("Veiculo não existente!!!", "Veiculo - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
                    LimparFormulario();
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo PLACA!!!", "Veiculo - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (!veiculo.locado)
            {
                VeiculoDAO.Remover(veiculo);
                MessageBox.Show("Veiculo removido com sucesso!!!", "Veiculo - WPF", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("Veiculo não pode ser removido pois está locado!!!", "Veiculo - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            txtPlaca.IsEnabled = true;
            btnBuscar.IsEnabled = true;
            btnRemover.IsEnabled = false;
            LimparFormulario();
        }
        private void LimparFormulario()
        {
            txtPlaca.Clear();
            txtTipo.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtCor.Clear();
            txtValorDiaria.Clear();
            txtPlaca.Focus();
        }
    }
}
