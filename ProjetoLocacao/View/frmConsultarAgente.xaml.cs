using ProjetoLocacao.DAL;
using ProjetoLocacao.Model;
using System.Collections.Generic;
using System.Windows;

namespace ProjetoLocacao.View
{

    /// <summary>
    /// Interaction logic for frmConsultarAgente.xaml
    /// </summary>
    public partial class frmConsultarAgente : Window
    {
        List<dynamic> agentes = new List<dynamic>();
        public frmConsultarAgente()
        {
            InitializeComponent();


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Agente ag in AgenteDAO.Listar())
            {
                dynamic item = new
                {
                    nome = ag.nome,
                    cpf = ag.cpf,
                    email = ag.email
                };
                agentes.Add(ag);
            }
            dtaAgentes.ItemsSource = agentes;
        }
    }
}
