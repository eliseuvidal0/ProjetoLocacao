using ProjetoLocacao.DAL;
using ProjetoLocacao.Model;
using System.Collections.Generic;
using System.Windows;

namespace ProjetoLocacao.View
{
    /// <summary>
    /// Interaction logic for frmConsultarVeiculo.xaml
    /// </summary>
    public partial class frmConsultarVeiculo : Window
    {
        private List<dynamic> veiculos = new List<dynamic>();
        public frmConsultarVeiculo()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string status;
            foreach (Veiculo vec in VeiculoDAO.Listar())
            {
                if (vec.locado)
                {
                    status = "Locado";
                }
                else
                {
                    status = "Disponível";
                }
                dynamic item = new
                {
                    marca = vec.marca,
                    modelo = vec.modelo,
                    placa = vec.placa,
                    tipo = vec.tipo,
                    cor = vec.cor,
                    valorDiaria = vec.valorDiaria,
                    situacao = status
                };

                veiculos.Add(item);
            }
            dtaVeiculos.ItemsSource = veiculos;
        }
    }
}
