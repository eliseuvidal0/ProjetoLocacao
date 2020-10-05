using ProjetoLocacao.DAL;
using ProjetoLocacao.Model;
using System.Collections.Generic;
using System.Windows;

namespace ProjetoLocacao.View
{
    /// <summary>
    /// Interaction logic for frmConsultarCliente.xaml
    /// </summary>
    public partial class frmConsultarCliente : Window
    {
        private List<dynamic> clientes = new List<dynamic>();
        public frmConsultarCliente()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Cliente cli in ClienteDAO.Listar())
            {

                dynamic item = new
                {
                    nome = cli.nome,
                    cpf = cli.cpf,
                    email = cli.email,
                    telefone = cli.telefone,
                    cnh = cli.cnh,
                    idade = ClienteDAO.CalcularIdade(cli.nascimento)
                };

                clientes.Add(item);

            }

            dtaClientes.ItemsSource = clientes;
        }
    }
}
