using ProjetoLocacao.DAL;
using ProjetoLocacao.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo PLACA!!!", "Veiculo - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (veiculo != null)
            {
                VeiculoDAO.Remover(veiculo);
                MessageBox.Show("Veiculo removido com sucesso!!!", "Veiculo - WPF", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Veiculo não foi removido!!!", "Veiculo - WPF", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
