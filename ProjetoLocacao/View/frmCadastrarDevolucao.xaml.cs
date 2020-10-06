using ProjetoLocacao.DAL;
using ProjetoLocacao.Model;
using System;
using System.Collections.Generic;
using System.Windows;

namespace ProjetoLocacao.View
{
    /// <summary>
    /// Interaction logic for frmCadastrarDevolucao.xaml
    /// </summary>
    public partial class frmCadastrarDevolucao : Window
    {
        private List<dynamic> locacoesAtivas = new List<dynamic>();
        public frmCadastrarDevolucao()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Popular();
        }

        private void Popular()
        {
            string status;
            foreach (Locacao loc in LocacaoDAO.ListarLocado())
            {
                if (loc.devolvido)
                {
                    status = "Disponível";
                }
                else
                {
                    status = "Locado";
                }
                dynamic item = new
                {
                    id = loc.id,
                    cliente = loc.cliente.nome,
                    veiculo = loc.veiculo.modelo,
                    prevEntrega = loc.previsaoEntrega,
                    situacao = status
                };

                locacoesAtivas.Add(item);

            }

            dtaLocacoes.ItemsSource = locacoesAtivas;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            dynamic loc = dtaLocacoes.SelectedItem;

            Locacao lo = LocacaoDAO.BuscarPorId(loc.id);
            lo.dataEntrega = DateTime.Now;
            lo.devolvido = true;
            lo.veiculo.locado = false;


            if (lo.dataEntrega.Month > lo.previsaoEntrega.Month)
            {
                int dias = (lo.dataEntrega - lo.previsaoEntrega).Days;
                lo.custoVariavel = lo.veiculo.valorDiaria * dias;
                lo.totalLocacao += lo.custoVariavel;

                LocacaoDAO.Alterar(lo);
                MessageBox.Show($"Veículo entregue! Pelo atraso de {dias} dias, " +
                    $"houve a cobrança extra no valor de R$ {lo.custoVariavel}", "Locação - WPF",
                                        MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (lo.dataEntrega.Day > lo.previsaoEntrega.Day)
            {
                int atraso = lo.dataEntrega.Day - lo.previsaoEntrega.Day;
                lo.custoVariavel = lo.veiculo.valorDiaria * atraso;
                lo.totalLocacao += lo.custoVariavel;

                LocacaoDAO.Alterar(lo);
                MessageBox.Show($"Veículo entregue! Pelo atraso de {atraso} dias, " +
                    $"houve a cobrança extra no valor de R$ {lo.custoVariavel}", "Locação - WPF",
                                        MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (lo.dataEntrega.Day < lo.previsaoEntrega.Day)
            {


                int dias = lo.previsaoEntrega.Day - lo.dataEntrega.Day;
                lo.custoVariavel = lo.veiculo.valorDiaria * dias;
                lo.totalLocacao -= lo.custoVariavel;

                if (lo.totalLocacao == 0)
                {
                    lo.custoVariavel -= lo.veiculo.valorDiaria;
                    lo.totalLocacao = lo.veiculo.valorDiaria;

                    LocacaoDAO.Alterar(lo);
                    MessageBox.Show($"Veículo entregue! Pela entrega antecipada de {dias} dias, " +
                        $"houve o desconto de R$ {lo.custoVariavel}", "Locação - WPF",
                                            MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    LocacaoDAO.Alterar(lo);
                    MessageBox.Show($"Veículo entregue! Pela entrega antecipada de {dias} dias, " +
                        $"houve o desconto de R$ {lo.custoVariavel}", "Locação - WPF",
                                            MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                LocacaoDAO.Alterar(lo);
                MessageBox.Show($"Veículo entregue na data esperada!", "Locação - WPF",
                                        MessageBoxButton.OK, MessageBoxImage.Information);
            }

            List<Locacao> vazia = new List<Locacao>();
            locacoesAtivas.Clear();
            dtaLocacoes.ItemsSource = vazia;
            dtaLocacoes.Items.Refresh();
            Popular();
        }
    }
}
