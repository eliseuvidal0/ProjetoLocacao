using ProjetoLocacao.DAL;
using ProjetoLocacao.Model;
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
                    cliente = loc.cliente.nome,
                    veiculo = loc.veiculo.modelo,
                    prevEntrega = loc.previsaoEntrega,
                    situacao = status
                };

                locacoesAtivas.Add(item);

            }

            dtaLocacoes.ItemsSource = locacoesAtivas;


        }

    }
}
